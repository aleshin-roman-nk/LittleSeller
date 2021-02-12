using LittleSellerKost.BL.adv.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSellerKost.Views
{
	// Интерфейс может возвращать другие интерфейсы.
	// Придаточные view, либо инкапсулировать их показ


	public interface IViewMain
	{
		void SetThisReceiptItems(ReceiptItem[] items);
		void SetShiftMenuItems(IEnumerable<ShiftMenuItem> items);
		void SetCategories(Category[] items);

		void SetReceiptCount(int v);
		void SetAllReceiptsAmount(decimal v);
		void SetThisReceiptAmount(decimal v);
		void SetCurrentCategory(string item);
		void SetShiftState(ShiftState state);
		void SetWebBufferState(int state);

		event Action<Category> CategoryChanged;
		event Action WebLoadShiftMenu;
		event Action<ShiftMenuItem> DiscountChange;
		event Action<ShiftMenuItem> BalanceChange;
		event Action<IEditableProductItem> EditMenuItemWeights; // Редактирование сменного меню не реализовано
		event Action<ShiftMenuItem> AddReceiptItem;
		event Action<ReceiptItem> DeleteReceiptItem;
		event Action EditShiftMenu;
		event Action MainViewReady;
		event Action KeyboardIdle;
		event Action DoSell;
		event Action ShowReceiptsHistoryView;

		event Action CloseShift;
		event Action OpenShift;
		event Action<ShutdownArgs> ShutdownProgram;

		void ShowMessage(string msg);
		bool ShowGetNumber(string msg, out decimal v);

		void ShowView();
		bool UserAnswerYes(string question);
	}

	public class ShutdownArgs
	{
		public bool Close { get; set; }
	}
}
