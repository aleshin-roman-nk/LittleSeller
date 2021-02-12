using LettleSellerKost.Forms.SrvForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettleSellerKost.Presenters.SrvPresenters
{
	public class WaitingPresenter
	{
		WaitingForm waitingForm;
		Task blockWindowTask;

		public async void Go(Action action)
		{
			BlockView();
			await Task.Run(() => action());
			UnblockView();
		}

		void BlockView()
		{
			waitingForm = new WaitingForm();
			blockWindowTask = waitingForm.ShowDialogAsync();
		}

		async void UnblockView()
		{
			if (waitingForm == null) return;

			waitingForm.Close();
			await blockWindowTask;

			waitingForm.Dispose();
			waitingForm = null;
		}
	}
}
