﻿using BaiTap05.Models;
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
        public IActionResult Index2()
        {
            var theloai = new TheLoaiViewModel
            {
                Id = 1,
                Name = "Trinh thám"
            };
            
            return View(theloai);
        }
    }
}
