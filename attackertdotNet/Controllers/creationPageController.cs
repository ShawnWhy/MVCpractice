using DatalibraryMonster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace attackertdotNet.Controllers
{
    public class creationPageController : Controller


    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: creationPage
       
            [HttpPost]
            public ActionResult CreateMonster(MonsterModel model)
            {
                if (ModelState.IsValid)
                {
                    int recordsCreated = DatalibraryMonster.Logic.monsterProcess.CreateMonster(model.Name,
                        model.MonsterHTML, model.Creator);

                }
            return Json(new { success = "true" });


        }


        // GET: creationPage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: creationPage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: creationPage/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: creationPage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: creationPage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: creationPage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: creationPage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
