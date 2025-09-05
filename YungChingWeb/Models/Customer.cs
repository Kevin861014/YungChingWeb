using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace YungChingWeb.Models
{
    /// <summary>
    /// 客戶資料
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "名稱必填")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email必填")]
        [EmailAddress(ErrorMessage = "Email格式不正確")]
        public string Email { get; set; }

        [Required(ErrorMessage = "電話必填")]
        [RegularExpression(@"^(09\d{8}|0\d{1,2}-\d{7,8})$", ErrorMessage = "電話格式不正確")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "地址必填")]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
