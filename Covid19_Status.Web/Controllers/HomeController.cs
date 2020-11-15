using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Covid19_Status.Services;

namespace Covid19_Status.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CountryService _countryService;

        public HomeController(CountryService countryService)
        {
            this._countryService = countryService ?? throw new ArgumentNullException(nameof(countryService));
        }

        public async Task<ActionResult> Index()
        {
            string result = await this._countryService.GetAllCountries();
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
    }
}