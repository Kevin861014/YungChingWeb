using System;
using System.Web;
using System.Web.Mvc;
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
            return View();
        }

        /// <summary>
        /// 新增客戶資料
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
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
