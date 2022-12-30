using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eventsite.Models.EFModels;
using Eventsite.Models.Repository;
using Eventsite.Models.Services;

namespace Eventsite.Controllers
{
    public class RegistersController : Controller
    {
        public ActionResult Index()
        {
            var data = new RegisterRepository().GetAll();
            return View(data);
        }

        // GET: Registers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            try
            {
                Register register = new Registers_Service().Find(id.Value);
                return View(register);
                //Register register = db.Registers.Find(id);
                //if (register == null)
                //{
                //    return HttpNotFound();
                //}
            }
            catch (Exception ex)
            {
                return HttpNotFound();
            }


        }

        // GET: Registers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registers/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email")] Register register)
        {
            try
            {
                new Registers_Service().Create(register);

                //var dataInDb = db.Registers.FirstOrDefault(x => x.Email == register.Email);
                //if (dataInDb != null)
                //{
                //   throw new Exception("Email 已經報名過了,無法再度報名");
                //}

                //register.CreatedTime = DateTime.Now;

                //db.Registers.Add(register);
                //db.SaveChanges();

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(register);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
