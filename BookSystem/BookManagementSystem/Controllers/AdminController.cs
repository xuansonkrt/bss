using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookManagementSystem.Models;


namespace BookManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        // tao list Admin
        public ActionResult List()
        {
            List<Admin> list = new List<Admin>();
            for (int i = 0; i <= 10; i++)
            {
                Admin Admin = new Admin();
                Admin.Id = i;
                Admin.Name = " Admin " + i;
                Admin.TaiKhoan = " TaiKhoan " + i;
                Admin.MatKhau = " MatKhau " + i;
                list.Add(Admin);
            }
            return View(list);
        }
        //tao Admin moi
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Admin _Admin)
        {
            return RedirectToAction("List");
        }
        // Sua Admin duoc chon
        public ActionResult Edit(int id)
        {
            Admin Admin = new Admin(id, " Admin 3","TaiKhoan 2", "matKhau");
            return View(Admin);
        }
        [HttpPost]
        public ActionResult Edit(Admin Admin)
        {
            return RedirectToAction("List");
        }
        // chi tiet Admin duoc chon
        public ActionResult Details(int id)
        {
            Admin Admin = new Admin(id, " Admin 3", "TaiKhoan 2", "matKhau");
            return View(Admin);
        }
        [HttpPost]
        public ActionResult Details()
        {

            return RedirectToAction("List");
        }
        // xoa Admin duoc chon   
        public ActionResult Delete(int id)
        {
            Admin Admin = new Admin(id, " Admin 3", "TaiKhoan 2", "matKhau");
            return View(Admin);

        }
        [HttpPost]
        public ActionResult Delete(Admin Admin)
        {
            return RedirectToAction("List");
        }
    }
}