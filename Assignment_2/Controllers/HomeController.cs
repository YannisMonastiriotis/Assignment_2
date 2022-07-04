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
            return View();
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