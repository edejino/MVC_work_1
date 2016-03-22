using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_work_1.Models
{
	public class 客戶資料ViewModels
	{
		public string 客戶名稱 { get; set; }
	    public Nullable<int> 聯絡人數量 { get; set; }
		public Nullable<int> 銀行帳戶數量 { get; set; }
	}
}