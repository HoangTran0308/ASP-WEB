using Microsoft.AspNetCore.Mvc;

namespace BaiTap05.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ngay = "Ngay 28";
            ViewBag.Thang = "Thang 02";
            ViewData["Nam"] = "Nam 2030";
            return View();
        }
    }
}
