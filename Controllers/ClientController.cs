using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            //ViewBag.TKey = TempData["tKey"];
            return View();
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(Client client)
        {
            //var errors = ModelState.Values.SelectMany(v => v.Errors);
            //Check if all validations set into model is valid or no.
            if(ModelState.IsValid)
            {
                ViewBag.CName = client.Name;
                return View();
            }
            return View("Index");
            
        }

        // POST: Client/Create
        /*[HttpPost]
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
        }*/

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
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

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
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

        [HttpGet]
        public new ActionResult Profile(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProfile(Client client)
        {
            return View();
        }
        [HttpPut]
        public ActionResult UpdateProfile(int id,Client client)
        {
            return View();
        }
        [HttpDelete]
        public ActionResult DeleteProfile(int id)
        {
            return View();
        }
    }
}
