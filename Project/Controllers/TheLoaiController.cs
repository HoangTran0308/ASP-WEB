using Project.Data;
using Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Area("Admin")]
    public class TheLoaiController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TheLoaiController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var theloai = _db.TheLoai.ToList();
            var filteredTheLoai = _db.TheLoai.Where(t => t.Id > 3).ToList();
            var filteredByDate = _db.TheLoai.Where(t => t.DateCreated < new DateTime(2222, 02, 22)).ToList();
            ViewBag.FilteredTheLoaiById = filteredTheLoai;
            ViewBag.FilteredTheLoaiByDate = filteredByDate;
            ViewBag.TheLoai = theloai;
            return View(filteredTheLoai);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TheLoai theLoai)
        {
            if (ModelState.IsValid)
            {
                // thêm thông tin vào bảng theloai
                _db.TheLoai.Add(theLoai);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }
        [HttpPost]
        public IActionResult Edit(TheLoai theLoai)
        {
            if (ModelState.IsValid)
            {
                // thêm thông tin vào bảng theloai
                _db.TheLoai.Update(theLoai);
                // Lưu lại
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var theloai = _db.TheLoai.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            _db.TheLoai.Remove(theloai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }
        [HttpGet]
        public IActionResult Search(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                // Sử dụng LINQ để tìm kiếm
                var theloai = _db.TheLoai.
                    Where(tl => tl.Name.Contains(searchString)).ToList();

                ViewBag.SearchString = searchString;
                ViewBag.TheLoai = theloai;
            }
            else
            {
                var theloai = _db.TheLoai.ToList();
                ViewBag.TheLoai = theloai;
            }

            return View("Index"); // Sử dụng lại View Index

        }
    }
}
