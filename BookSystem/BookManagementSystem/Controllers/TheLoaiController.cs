using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookManagementSystem.Models;

namespace BookManagementSystem.Controllers
{
    public class TheLoaiController : Controller
    {
        // GET: TheLoai
        public ActionResult Index()
        {
            return View();
        }
        //tao mot list the loai
        public ActionResult List()
        {
            List<TheLoai> list = new List<TheLoai>();
            for(int i=0; i<=10; i++)
            {
                TheLoai theLoai = new TheLoai();
                theLoai.ID = i;
                theLoai.Name = "The loai " + i;
                list.Add(theLoai);
            }
            return View(list);
            
        }
        // tao mot the loai moi va them vao list
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( TheLoai _theLoai)
        {
            return RedirectToAction("List");
        }
        // Sua the loai duoc chon
        public ActionResult Edit( int id)
        {
            TheLoai theLoai = new TheLoai(id, " the loai 123");
            return View(theLoai);
        }
        [HttpPost]
        public ActionResult Edit( TheLoai theLoai)
        {
            return RedirectToAction("List");
        }
        // chi tiet the loai duoc chon
        public ActionResult Details(int id)
        {
            TheLoai the = new TheLoai(id, "name");
            return View(the);
        }
        [HttpPost]
        public ActionResult Details()
        {

            return RedirectToAction("List");
        }
        // xoa the loai duoc chon   
        public ActionResult Delete(int id)
        {
            TheLoai theLoai = new TheLoai(id, " the loai ");
            return View(theLoai);

        }
        [HttpPost]
        public ActionResult Delete( TheLoai theLoai)
        {
            return RedirectToAction("List");
        }
        
    }   
}