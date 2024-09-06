using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha03.Controllers
{
    public class TinhToanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MayTinh(int a, int b, string pheptinh)
        {
            int ketqua = 0;
            string message = "";

            if (pheptinh == "cong") ketqua = a + b;
            else if (pheptinh == "tru") ketqua = a - b;
            else if (pheptinh == "nhan") ketqua = a * b;
            else if (pheptinh == "chia")
                message = b != 0 ? (ketqua = a / b).ToString() : "Không thể chia cho 0!";
            else
                message = "Phép tính không hợp lệ!";

            ViewBag.KetQua = ketqua;
            ViewBag.Message = message;
            return View();
        }
    }
}
