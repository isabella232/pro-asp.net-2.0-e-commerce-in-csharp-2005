using System;
using System.Collections.Generic;
using System.Text;

namespace LittleItalyVineyard.DataAccess
{
	public class StoredProcedure
	{
		public enum Name
		{
			ProductByID_Select ,
			Products_Select ,
			ProductImage_Select ,
			Products_SelectSearch ,
			ShoppingCart_Insert ,
            ShoppingCart_Select ,
            ShoppingCart_Update ,
            ShoppingCart_Delete ,
			Order_Insert ,
			OrderDetails_Insert ,
			EndUserLogin_Select ,
			Address_Select ,
			ContactInformation_Select
		}
	}
}
