namespace MVC_work_1.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	[MetadataType(typeof(客戶聯絡人MetaData))]
	public partial class 客戶聯絡人 : IValidatableObject
	{
		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			var data = new 客戶資料Entities();
			if (this.Id == 0)
			{
				if (data.客戶聯絡人.Where(m=>m.客戶Id==this.客戶Id&&m.Email.Equals(this.Email)).Any())
				{
					yield return new ValidationResult("Email 重覆(create)", new string[] { "Email" });
				}
				
			}
			else
			{
				if (data.客戶聯絡人.Where(m => m.客戶Id == this.客戶Id && m.Id != this.Id && m.Email.Equals(this.Email)).Any())
				{
					yield return new ValidationResult("Email 重覆(update)", new string[] { "Email" });
				}
			}

			yield return ValidationResult.Success;
		}
	}

	public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 職稱 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 姓名 { get; set; }
        
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        [Required]
		[EmailAddress]
        public string Email { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
		[RegularExpression(@"\d{4}-\d{6}",ErrorMessage = "電話格式必須為(e.g.0911-111111)")]
		//[輸入合法手機號碼(ErrorMessage = "電話格式必須為(e.g.0911-111111)")]
		public string 手機 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
