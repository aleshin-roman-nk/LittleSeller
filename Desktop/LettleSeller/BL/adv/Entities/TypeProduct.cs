using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.BL.adv.Entities
{
	/*
	 * Имеем две коллекции объектов.
	 * Одна загруженная data-коллекция, вторая ui-коллекция
	 * 
	 */

		/*
		 * Коллекция типов загружается из сервера.
		 *	Или локально из sqlite, если связи нет
		 * 
		 */
	public class TypeProduct: IEditableProductItem
	{
		public int Id { get; set; }
		//Нет надобности т.к. объект будет висеть с id=0 пока не получит идентификатор с сервера
		// Хотя при сохранении в SQLite локально, всеравно ему припишется локальный Id.
		// Так что всеравно нужен серверный, глобальный идентификатор
		// Такая же история с клоном-экземпляром в меню.
		//		только там еще нужен id-указатель на базовый тип
		// Проблему однозначной идентификации можно решить следующим способом
		//		На сервере регистрируем экемпляр машины, сервер выделяет уникальный токен машины.
		//			При запуске, если в настройках программы не присвоен токен, машина делает запрос.
		//			Машина сохраняет этот токен. И теперь все локальные идентификаторы 
		//			при обращении к серверну формируются из локльного id и уникального токена машины.
		//			Все запросы содержат токен.
		//				Вместо токена можно присвоить имя машины и попытаться зарегистрировать на сервере.
		//					Если такая машина уже есть, ответить соответственно.
		//			На сервере таблица "А": id; token; localid
		//			Целевая таблица имеет id-ссылку на А.id
		//				Таким образом это дает большие возможности.
		//				Например если добавить в таблице "А" поле status, то при обрыве обратной связи
		//				машина может повторно запросить. И если на сервере есть эта запись,
		//				то он отвечает что все хорошо и машина может запросить удаление этой регистрации из таблицы "А"
		//			
		//			
		//			
		public int UKey { get; set; }
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public string WPInfo
		{
			get
			{
				return wpinfo;
			}
			set
			{
				wpinfo = value;
				UpdateWP();
			}
		}

		string wpinfo = "{}";

		//public static TypeProduct FromProduct(Product p)
		//{
		//	return new TypeProduct
		//	{
		//		UKey = p.ukey,
		//		CategoryId = p.CategoryID,
		//		Name = p.Name,
		//		WPInfo = JsonConvert.SerializeObject(p.WPinfo)
		//	};
		//}

		public void SetFrom(TypeProduct p)
		{
			CategoryId = p.CategoryId;
			Name = p.Name;
			WPInfo = p.WPInfo;
		}

		public TypeProduct GetTemp()
		{
			return new TypeProduct
			{
				Id = Id,
				Name = Name,
				CategoryId = CategoryId,
				WPInfo = WPInfo,
				UKey = UKey
			};
		}

		#region UI
		[NotMapped]
		public Dictionary<int, int> WP { get; set; }

		public void UpdateWP()
		{
//			if (string.IsNullOrEmpty(WPInfo)) WPInfo = "{}";
			WP = JsonConvert.DeserializeObject<Dictionary<int, int>>(WPInfo);
		}

		[NotMapped]
		public string Weight
		{
			get
			{
				if (WP == null) return "-";
				string res = "";
				foreach (var item in WP)
				{
					res += item.Key.ToString() + "/";
				}

				res = res.TrimEnd('/');

				return res;
			}
		}
		[NotMapped]
		public string Price
		{
			get
			{
				if (WP == null) return "-";
				string res = "";
				foreach (var item in WP)
				{
					res += item.Value.ToString() + "/";
				}

				res = res.TrimEnd('/');

				return res;
			}
		}
		#endregion
	}

// Попробовать поменять подход к работе с DataGridView следующим образом:
//		в ручную создавать все настройки сетки
//			ручное заполнение.
//			Такое же использование BindingSource
//			Эта идея пришла от того, как в php-проекте я строю красивые таблицы
//		Или встеки использовать UI-враппер. Но не наследоваться, и держать ссылку на объект бд
//			и отображать нужные поля через проперти-прокидывания посредством get
//				таким образом можно скрывать неотображаемые свойства объекта бд

	// Сохраним конструкцию, приведенную ниже, как вариант на будущее, если будет что то более сложное.
	//		В данном случае можно было бы просто добавить свойство WP, Weight, Price в сущность TypeProduct
	//		Ниже приведенная конструкция еще выполняет роль обеспечения чистоты кода с точки зрения единственной
	//			ответственности.

	/// <summary>
	/// TypeProductUI предназначен для отрисовки в UI
	/// </summary>
	//public class TypeProductUI: TypeProduct
	//{
	//	public TypeProductUI(TypeProduct type)
	//	{
	//		this.Id = type.Id;
	//		this.UKey = type.UKey;
	//		this.CategoryId = type.CategoryId;
	//		this.Name = type.Name;
	//		this.WPInfo = type.WPInfo;
	//	}

	//	//public static TypeProductUI FromType(TypeProduct type)
	//	//{
	//	//	return new TypeProductUI
	//	//	{

	//	//	};
	//	//}

	//	public TypeProduct ToTypeProduct()
	//	{
	//		return new TypeProduct
	//		{

	//		};
	//	}

	//	public Dictionary<int, int> WP { get; }
	//	public string Weight
	//	{
	//		get
	//		{
	//			string res = "";
	//			foreach (var item in WP)
	//			{
	//				res += item.Key + '/';
	//			}

	//			res.TrimEnd('/');

	//			return res;
	//		}
	//	}

	//	public string Price
	//	{
	//		get
	//		{
	//			string res = "";
	//			foreach (var item in WP)
	//			{
	//				res += item.Value + '/';
	//			}

	//			res.TrimEnd('/');

	//			return res;
	//		}
	//	}
	//}
}
