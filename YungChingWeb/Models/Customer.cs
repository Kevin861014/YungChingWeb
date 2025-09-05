using System;
using System.Web;

namespace YungChingWeb.Models
{
    /// <summary>
    /// 客戶資料
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
