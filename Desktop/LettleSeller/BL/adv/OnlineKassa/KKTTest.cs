using LittleSellerKost.BL.adv.Entities;
using LittleSellerKost.BL.adv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettleSellerKost.BL
{
	public class KKTTest : IKktDevice
	{
		public bool IsShiftOpened => true;

		public bool IsShiftClosed => false;

		public bool IsShiftExpired => false;

		public bool Ready => true;

		public ShiftState ShiftState => ShiftState.Opened;

		public void AddRecieptPosition(string name, int price, decimal quantity)
		{
			
		}

		public string CloseReceipt()
		{
			return null;
		}

		public string CloseShift()
		{
			return null;
		}

		public void OpenReceipt()
		{

		}

		public string OpenShift()
		{
			return null;
		}

		public void Payment(bool cash, double sum)
		{
			
		}
	}
}
