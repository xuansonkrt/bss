﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookManagementSystem.Models;

namespace BookManagementSystem.Controllers
{
    public class CuonSachController : Controller
    {
        // GET: CuonSach
        public ActionResult Index()
        {
            return View();
        }
        // tao list CuonSach
        public ActionResult List()
        {
            List<CuonSach> list = new List<CuonSach>();
            for (int i = 0; i <= 10; i++)
            {
                CuonSach CuonSach = new CuonSach();
                CuonSach.Id = i;
                CuonSach.Name = " CuonSach " + i;
                CuonSach.GiaTien = 200 * i;
                CuonSach.GioiThieu = " gioi thieu " + i;
                CuonSach.Id_NXB = i + 10;
                CuonSach.ID_TheLoai = i + 20;
                CuonSach.SoLuong = i + 3;
                CuonSach.MainImage = " Image" + i;
                list.Add(CuonSach);
            }
            return View(list);
        }
        //tao CuonSach moi
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CuonSach _CuonSach)
        {
            return RedirectToAction("List");
        }
        // Sua CuonSach duoc chon
        public ActionResult Edit(int id)
        {
            CuonSach CuonSach = new CuonSach(id, " CuonSach 3","GioiThieu",123,2,2,4,"Image ");
            return View(CuonSach);
        }
        [HttpPost]
        public ActionResult Edit(CuonSach CuonSach)
        {
            return RedirectToAction("List");
        }
        // chi tiet CuonSach duoc chon
        public ActionResult Details(int id)
        {
            CuonSach CuonSach = new CuonSach(id, " CuonSach 3", "GioiThieu", 123, 2, 2, 4, "Image ");
            return View(CuonSach);
        }
        [HttpPost]
        public ActionResult Details()
        {

            return RedirectToAction("List");
        }
        // xoa CuonSach duoc chon   
        public ActionResult Delete(int id)
        {
            CuonSach CuonSach = new CuonSach(id, " CuonSach 3", "GioiThieu", 123, 2, 2, 4, "Image ");
            return View(CuonSach);

        }
        [HttpPost]
        public ActionResult Delete(CuonSach CuonSach)
        {
            return RedirectToAction("List");
        }
    }
}