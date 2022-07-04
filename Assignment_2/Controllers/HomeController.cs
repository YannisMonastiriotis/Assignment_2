using Assignment_2.Repositories;
using Assignment_2.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Assignment_2.Controllers
{
    public class HomeController : Controller 
    {
        private readonly TrainerCrudRepository _trainerRepos;
        // GET: Trainer

        public HomeController()
        {
            _trainerRepos = new TrainerCrudRepository();
        }

        public ActionResult Index()
        {
            var model = new TrainerViewModel
            {
                Trainers = _trainerRepos.GetAll().ToList()
            };
            return View(model);
        }

        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _trainerRepos.Dispose();
            base.Dispose(disposing);
        }
    }
}