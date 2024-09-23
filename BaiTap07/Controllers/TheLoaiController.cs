﻿using BaiTap07.Data;
using BaiTap07.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap07.Controllers
{
    public class TheLoaiController : Controller
    {
        private readonly ApplicationDbContext _db;
        public  TheLoaiController(ApplicationDbContext db)
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
            if (ModelState.IsValid) { 
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
        public IActionResult Details(int id)
        {
            var theLoai = _db.TheLoai.FirstOrDefault(t => t.Id == id);
            if (theLoai == null)
            {
                return NotFound();
            }
            return View(theLoai);
        }

    }
}
