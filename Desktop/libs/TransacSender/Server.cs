using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacSender
{
	// Это обертка абстракции сервера. Предоставляет необходимые функции работы с удаленными ресурсами
	//		Инкапсулирует методы работы с удаленным веб-сервером.


	internal class service_web
	{
		public static string ExecuteGetReguest(string BaseUrl, string controller, string action, string Data)
		{
			var web = new System.Net.WebClient();

			web.Headers.Add("user-agent", "Only a test!");
			web.Encoding = Encoding.UTF8;

			return web.DownloadString($"{BaseUrl}/{controller}/{action}?{Data}");
		}

		// Сразу обращение на контроллер обработки json запроса
		// наверное лучше перевести в Server так как этот класс другого слоя
		public static string ExecuteGetRequestJsonService()
		{
			throw new NotImplementedException();
		}
	}


	internal class Server
	{
		string baseUrl;

		public Server(string bu)
		{
			baseUrl = bu;
		}

		public Response SendTransaction(Transaction tr)
		{
			// Connection text
			//try
			//{
			//	var tr_tst_conn = new Transaction("conn_text");
			//	var str = SendJSON(tr_tst_conn.ToJSON());
			//}
			//catch (Exception)
			//{
			//	return new Response { error_code = ResponseErrorCodes.ErrInternetConnection, error_msg = "Отсутствует подключение к серверу" };
			//}

			// Проработать механизм определения отсутствия интернета и внутренней ошибки сервера.
			string strResponse;
			try
			{
				//Logger.Write(">>>");
				//Logger.Write(tr.ToJSON());
				strResponse = SendJSON(tr.ToJSON());
				//Logger.Write("<<<");
				//Logger.Write(strResponse);
			}
			catch (Exception ex)// Ошибки сервера: отсутствует подключение либо ошибки скрипта на сервере.
			{
				//return new Response { error_msg = "Internet connection error", error_code = ResponseError.ErrInternetConnection };
				return new Response { error_msg = ex.Message, error_code = ResponseErrorCodes.ErrInternetConnection };
			}

			Response resp;
			try
			{
				resp = JsonConvert.DeserializeObject<Response>(strResponse);
			}
			catch (Exception)
			{
				return new Response { error_msg = $"Response deserialisation error: {strResponse}", error_code = ResponseErrorCodes.ErrDeserialisation };
			}
			
			/////////Валидация структуры
			if(resp == null)
			{
				return new Response { error_msg = $"resp == null Json structure mismatch to protocol {strResponse}", error_code = ResponseErrorCodes.ErrJsonStructureMismutch };
			}
			if(resp.head == null)// определить валидатор протокола вместо resp.head == null
			{
				return new Response { error_msg = $"resp.head == null Json structure mismatch to protocol {strResponse}", error_code = ResponseErrorCodes.ErrJsonStructureMismutch };
			}
			/////////////////////

			if(resp.error_code != ResponseErrorCodes.Ok)// Сервер вернул определенную на его стороне ошибку
			{
				return new Response { error_msg = resp.error_msg, error_code = resp.error_code };
			}

			resp.error_code = ResponseErrorCodes.Ok;

			return resp;
		}

		string SendJSON(string param)
		{
			return service_web.ExecuteGetReguest(baseUrl, "jsonsrv", "index", $"j={param}");
		}
	}

	public enum TransactionStates { Incompleted = 0, Completed = 1 }
	/*
	 * (!>Утверждено<)
	 * Отправляем транзакцию на сервер.
	 *			>server-side Сервер выполняет транзакцию и сохраняет ее в своей таблице транзакций.
	 *			>server-side Сервер отправляет отчет о выполнении клиенту.
	 *			>server-side Если во врема мгновения ответа сервера произошел сбой и клиент не получил отчета о выполнении
	 *	Клиент повторно отправляет транзакцию на выполнение.
	 *		В этом случае сервер ответит, что транзакция уже выполнена.
	 * (>Утверждено<!)
	 */
	public class Transaction: IRepoItem
	{
		public int id { get; set; }
		public object data_request { get; set; }// Возможно хранить в формате json
		public object data_response { get; set; }// Возможно хранить в формате json, или по крайней мере для вывода сделать get-проперти с выводом json для datagridview
		public string cmd { get; set; }
		public TransactionStates state { get; set; }
		public DateTime Date { get; set; }
		public long GKey { get; set; }
		public string error_msg { get; set; }
		public ResponseErrorCodes error_code { get; set; }
		public bool HasGKey
		{
			get
			{
				return GKey > 0;
			}
		}

		public Transaction(string cmd, object data = null)
		{
			this.data_request = data;
			this.cmd = cmd;
			state = TransactionStates.Incompleted;
			GKey = -1;
			error_code = ResponseErrorCodes.Undefined;
		}

		public string ToJSON()
		{
			var jo = new { cmd = this.cmd, data = this.data_request, gkey = GKey };
			return JsonConvert.SerializeObject(jo);
		}
	}
	public enum ResponseErrorCodes { Undefined = -1, Ok = 0, ErrInternetConnection = 1, ErrDeserialisation = 2, ErrJsonStructureMismutch = 3, TransactionAlready = 4, ErrServerInternalError = 5 };
	// может быть Response сделать вложенным в Transaction. Тогда меньше путанницы в полях ошибок
	public class Response
	{
		public string head { get; set; }
		public object data { get; set; }
		public string error_msg { get; set; }
		public ResponseErrorCodes error_code { get; set; }

		public bool HasError
		{
			get
			{
				return !(error_code == ResponseErrorCodes.Ok);
			}
		}
	}

	internal class Errors
	{

	}
}
