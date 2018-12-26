using System;
using System.Web.Mvc;
using UnderstandingActionFiltersInAspNetMvc.Filters;

namespace UnderstandingActionFiltersInAspNetMvc.Controllers
{
    [LogActionFilter]
    [MyCustomErrorHandler]
    public class DataController : Controller
    {
        [OutputCache(Duration=10)]
        public string Time()
        {
            return DateTime.Now.ToString("T");
        }
         
        
        public ActionResult Error()
        {
            // Throw a new Exception
            throw new Exception("An Exception Occured at Error action of Data controller");

            return View();
        }
    }
}