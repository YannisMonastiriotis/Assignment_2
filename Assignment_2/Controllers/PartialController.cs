using Assignment_2.Repositories;
using Assignment_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2.Controllers
{
    public class PartialController : HomeController
    {
      
            private readonly TrainerCrudRepository _trainerRepos;
            // GET: Trainer

            public PartialController()
            {
                _trainerRepos = new TrainerCrudRepository();
            }

        
            //public ActionResult _TableOutput()
            //{
            //    var partialView = new PartialTrainerViewModel();

            //    var trainerViewModel = new TrainerViewModel();
            //    var trainerViewModels = partialView.TrainerViewModels = new List<TrainerViewModel>();
            //    var trainers = _trainerRepos.GetAll();

            //    //foreach (var trainer in trainers)
            //    //{
            //    //    trainerViewModels.Add(_trainerRepos.CreateTrainerViewModel(trainer));
            //    //}

            //    partialView = new PartialTrainerViewModel()
            //    {
            //        Trainers = trainerViewModel.Trainers.ToList(),
            //        TrainerViewModels = trainerViewModels
            //    };

            //    return View("_TableOutput", partialView);
            //}

            //[HttpPost]
            //[ChildActionOnly]
            public ActionResult GetAction()
            {
                var trainers = _trainerRepos.GetAll();

            var partialView = new PartialTrainerViewModel()
            {
                TrainerViewModel = new TrainerViewModel
                {
                    Trainers = trainers.ToList()
                }            
            };

                return View(partialView);
            }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _trainerRepos.Dispose();
            }
            base.Dispose(disposing);
        }

    }
    }