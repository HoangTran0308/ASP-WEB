using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangKy(TaiKhoanViewModel model)
        {
            if (model.Username != null && model.FullName != null && model.Old > 0 && model.Password != null)
            {
                return Content($"Username: {model.Username}, Họ tên: {model.FullName}, Tuổi: {model.Old}, Password: {model.Password}");
            }
            return View();
        }
    }
}
