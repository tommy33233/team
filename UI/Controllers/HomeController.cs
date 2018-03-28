using System.Linq;
using System.Web.Mvc;
using BLL.Interfaces;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private IAppService service;

        public HomeController(IAppService serv)
        {
            service = serv;
        }

        public ActionResult Index()
        {
            var peopleDTO = service.GetAllPersons();
            var people = peopleDTO.Select(x => PersonViewModel.PersonToView(x)).ToList();
            return View(people);
        }
    }
}