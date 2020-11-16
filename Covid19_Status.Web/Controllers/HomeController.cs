using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Covid19_Status.Models;
using Covid19_Status.Services;
using Covid19_Status.Web.Models;

namespace Covid19_Status.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CountryService _countryService;
        private readonly CovidStatusService _covidStatusService;

        public HomeController(CountryService countryService, CovidStatusService covidStatusService)
        {
            this._countryService = countryService ?? throw new ArgumentNullException(nameof(countryService));
            this._covidStatusService = covidStatusService ?? throw new ArgumentNullException(nameof(covidStatusService));
        }

        public async Task<ActionResult> Index()
        {
            List<CountryModel> countries = await this._countryService.GetAllCountries();
            //ViewBag.Countries = new SelectList(countries, "Slug", "Country");
            ViewBag.Countries = countries;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> About(Filters filters)
        {
            List<CovidStatus> covidStatuses = await this._covidStatusService.GetStatus(filters.Country, filters.From, filters.To);
            ViewBag.Results = covidStatuses;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}