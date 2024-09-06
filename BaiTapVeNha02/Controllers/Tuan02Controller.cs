using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha02.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Trần Thanh Hoàng";
            ViewBag.MSSV = "1822040206";
            ViewBag.Nam = "Trần Thanh Hoàng - 2024";
            return View();
        }
    }
}
