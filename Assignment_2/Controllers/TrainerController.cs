using Assignment_2.Models;
using Assignment_2.Repositories;
using Assignment_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2.Controllers
{
    public class TrainerController : Controller
    {
        private readonly TrainerCrudRepository _trainerRepos;
        // GET: Trainer

        public TrainerController()
        {
            _trainerRepos = new TrainerCrudRepository();
        }
        public ActionResult Index()
        {
            return View();
        }

       
        // GET: Trainer/Details/5
        public ActionResult Details(int? id)
        {
            var viewModel = _trainerRepos.MatchTrainerViewModel(id);
            return View(viewModel);
        }

        // GET: Trainer/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: Trainer/Create
        [HttpPost]
        public ActionResult Create(Trainer trainer)
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

        // GET: Trainer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trainer/Edit/5
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

        // GET: Trainer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trainer/Delete/5
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
