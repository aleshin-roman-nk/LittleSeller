using Newtonsoft.Json;
using LittleSellerKost.BL.adv;
using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.BL.adv.Models;
using LittleSellerKost.Forms;
using LittleSellerKost.Models;
using LittleSellerKost.Presenters.SrvPresenters;
using LittleSellerKost.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LettleSellerKost.BL.adv;
using LettleSellerKost.Presenters.SrvPresenters;
using LettleSellerKost.BL.Web;
using TransacSender;
using LettleSellerKost.BL.adv.DbLayer;

namespace LittleSellerKost.Presenters
{
	public class MainPresenterAdv
	{
		IViewMain view;
		TransactionManager transactionManager;
		ShiftMenuBox shiftMenu;
		CashBox cashBox;
		Category currentCategory { get; set; } = null;

		public MainPresenterAdv(IViewMain v)
		{
			view = v;
			view.SetCategories(DbCategory.FindAll());

			// Открытие смены сделать как то более явным. С авторизацией.
			// Запрет на работу без авторизации.
			// Первым открывать окно авторизации.

			view.EditShiftMenu += View_EditShiftMenu;
			view.MainViewReady += View_MainViewReady;
			view.AddReceiptItem += View_AddReceiptItem;
			view.DoSell += View_DoSell;
			view.DeleteReceiptItem += View_DeleteReceiptItem;
			view.CategoryChanged += View_CategoryChanged;
			view.CloseShift += View_CloseShift;
			view.OpenShift += View_OpenShift;
			view.ShutdownProgram += View_ShutdownProgram;
			view.ShowReceiptsHistoryView += View_ShowReceiptsHistoryView;

			shiftMenu = new ShiftMenuBox(DateTime.Today);
			shiftMenu.MenuItemsChanged += ShiftMenu_MenuItemsChanged;
			shiftMenu.Load();

			cashBox = new CashBox();
			view.SetShiftState(cashBox.ShiftState);
			updateViewShift();

			transactionManager = new TransactionManager();
			transactionManager.Updated += TransactionManager_Updated;
			transactionManager.Error += TransactionManager_Error;
			transactionManager.Start();
		}

		private void View_ShowReceiptsHistoryView()
		{
			ReceiptsHistoryPresenter.Go();
		}

		private void TransactionManager_Error(string obj)
		{
			ShowDebug.LogObject(obj);
		}

		private void TransactionManager_Updated(int obj)
		{
			view.SetWebBufferState(obj);
		}

		private void ShiftMenu_MenuItemsChanged(IEnumerable<ShiftMenuItem> obj)
		{
			view.SetShiftMenuItems(obj);
		}

		private void View_ShutdownProgram(ShutdownArgs obj)
		{
			if(cashBox.IsShiftOpened)
			{
				if (!view.UserAnswerYes("Смена не закрыта.\n[Да] - Выйти из программы, оставив смену открытой\n[Нет] - Не выходить из программы."))
					obj.Close =false;
			}
		}


		private void View_OpenShift()
		{
			if (!cashBox.KktReady)
			{
				view.ShowMessage("ККТ не готова");
				return;
			}

			if (!view.UserAnswerYes("Открыть смену?")) return;

			if (cashBox.IsShiftOpened)
			{
				view.ShowMessage("В данный момент смена уже открыта");
				return;
			}

			view.ShowMessage(cashBox.OpenShift(DateTime.Now));
			view.SetShiftState(cashBox.ShiftState);
			updateViewShift();
		}

		private void View_CloseShift()
		{

			if (cashBox.IsShiftClosed || cashBox.IsShiftExpired)
			{
				view.ShowMessage("Смена закрыта или истекла");
				return;
			}

			if (cashBox.ReceiptBox.IsOpened)
			{
				view.ShowMessage("Запрещено закрывать смену при открытом чеке");
				return;
			}

			if (!view.UserAnswerYes("Смена будет закрыта. Пожалуйста, подтвердите")) return;

			cashBox.CloseShift();
			view.SetShiftState(cashBox.ShiftState);
		}

		private void View_CategoryChanged(Category obj)
		{
			currentCategory = obj;
			view.SetCurrentCategory(currentCategory == null ? "ВСЕ" : currentCategory.Name.ToUpper());
			shiftMenu.SetCategory(obj);
		}

		private void View_DeleteReceiptItem(ReceiptItem obj)
		{
			cashBox.ReceiptBox.RemovePosition(obj);
			updateViewReceiptItems();
		}

		private void View_DoSell()
		{
			if (!cashBox.ReceiptBox.IsOpened || cashBox.ReceiptBox.Items.Count() == 0)
			{
				view.ShowMessage("Чек не открыт или пустой");
				return;
			}

			// 1. Ловим чек
			var receipt = cashBox.ReceiptBox.Receipt;

			// 2. Предпродажное окно. Пользователь отмечает необходимость резервирования
			var res = CommitSellPresenter.Go(cashBox.ReceiptBox.ReceiptAmount);
			if (!res.Ok) return;

			// 4*. Если пользователь отметил резерв, создаем в таблице ссылку на чек
			if (res.IsReserved)
				receipt.Reserved = true;

			// 3. Продаем. Ссылка теряется. Чек получает ID
			// 3.1. Ссылка на чек в cashBox теряется
			var r = cashBox.Sell(false);

			//// 4. Если пользователь отметил резерв, создаем в таблице ссылку на чек
			//if (res.IsReserved)
			//	DbReservedReceipts.Add(receipt);

			updateViewReceiptItems();
			updateViewShift();
			shiftMenu.IncreaseCounts(receipt.ReceiptItems);

#if !DEBUG
			// Поместить чек в очередь транзакций
			transactionManager.RegisterReceiptTrans(receipt);
#endif
		}

		private void View_AddReceiptItem(ShiftMenuItem obj)
		{
			if (!cashBox.IsShiftOpened)
			{
				view.ShowMessage("Смена не открыта или истекла.");
				return;
			}

			var x = new ReceiptPositionBuilderPresenter().Go(obj);

			if (x == null) return;

			cashBox.AddReceiptPosition(obj, x);
			updateViewReceiptItems();
		}

		private void View_MainViewReady()
		{
			//PreLoader.go();
			new WaitingPresenter().Go(() =>
			{
				System.Threading.Thread.Sleep(2000);
				using (DbAppData db = new DbAppData())
				{
					db.Categories.ToArray();
				}
			});
		}

		private void View_EditShiftMenu()
		{
			_ = new TodayMenuPresenterAdv(new FormTodayMenuEditor());
			shiftMenu.Load();
		}

		void updateViewReceiptItems()
		{
			view.SetThisReceiptItems(cashBox.ReceiptBox.Items.ToArray());
			view.SetThisReceiptAmount(cashBox.ReceiptBox.ReceiptAmount);
		}

		// >>>
		// Доступ к свойствам только для чтения, методам - ок. Не нравится когда что то типа cashBox.ShiftBox.State == ShiftState.Opened
		//	Лучше придерживаться однообразия. Т.е. если решил спрятать объект, то все операции прокидывать через адаптер-методы.
		//		Либо в классе cashBox перенести IsShiftExpired в ShiftBox и обращатьса cashBox.ShiftBox.IsShiftExpired.
		//			Иначе логика будет сломана - непонятно, когда я должен обратиться к вложенному объекту, когда к адаптер-методу хост-объекта.
		void updateViewShift()
		{
			cashBox.ReloadShiftInfo();
			view.SetAllReceiptsAmount(cashBox.ShiftBox.ReceiptsAmount);
			view.SetReceiptCount(cashBox.ShiftBox.ReceiptsCount);
		}
	}
}
