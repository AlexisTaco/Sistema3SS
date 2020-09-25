using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema3SS_2020.Models;

namespace Sistema3SS_2020.Controllers
{
    public class GranjaController : Controller
    {
        
        // GET: GranjaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GranjaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GranjaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GranjaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction(nameof(Index));
                

            }
            catch
            {
                return View();
            }
        }

        // GET: GranjaController/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: GranjaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection keyValues)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GranjaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GranjaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
