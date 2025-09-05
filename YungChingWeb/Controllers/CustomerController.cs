using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YungChingWeb.Models;
using YungChingWeb.Services;

namespace YungChingWeb.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        /// <summary>
        /// 顯示客戶資訊
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

        /// <summary>
        /// 新增客戶資料
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        // 新增客戶
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.CreatedAt = DateTime.Now;
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        /// <summary>
        /// 編輯客戶資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
