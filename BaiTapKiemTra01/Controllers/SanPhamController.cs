using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BaiTap2()
        {
            var sanpham = new SanPhamViewModel();
            {
                ViewBag.TenSanPham = "Laptop Acer";
                ViewBag.Gia = "21000000";
                ViewData["MoTa"] = "/images/laptop-acer-nitro 5-tiger-2022-10_1661479517.jpg";
            };
            return View(sanpham);
        }
    }
}
