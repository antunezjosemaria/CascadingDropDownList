using CascadingDropDownList.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CascadingDropDownList.Controllers
{
    public class HomeController : Controller
    {
        MVCTutorialEntities db = new MVCTutorialEntities();

        public ActionResult Index()
        {
            List<Ta_Country> CountryList = db.Ta_Country.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "CountryId", "CountryName");

            return View();
        }        
    }
}