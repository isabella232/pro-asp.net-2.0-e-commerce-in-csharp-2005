using System;
using System.Collections.Generic;
using System.Text;

using LittleItalyVineyard.Common;
using LittleItalyVineyard.DataAccess.Insert;

namespace LittleItalyVineyard.BusinessLogic
{
	public class ProcessAddEndUser : IBusinessLogic
	{
		private EndUser _enduser;

		public ProcessAddEndUser()
		{

		}

		public bool Invoke()
		{
			bool complete = false;

			try
			{
				EndUserInsertData enduserdata = new EndUserInsertData();
				enduserdata.EndUser = this.EndUser;
				enduserdata.Add();

				this.EndUser.EndUserID = enduserdata.EndUser.EndUserID;

				complete = true;
			}
			catch ( Exception ex )
			{
				throw ex;
			}

			return complete;
		}

		public EndUser EndUser
		{
			get { return _enduser; }
			set { _enduser = value; }
		}
	}
}
