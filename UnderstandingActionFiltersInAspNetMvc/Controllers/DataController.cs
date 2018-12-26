using System;
using System.Web.Mvc;

namespace UnderstandingActionFiltersInAspNetMvc.Controllers
{
    public class DataController : Controller
    {
        [OutputCache(Duration=10)]
        public string Time()
        {
            return DateTime.Now.ToString("T");
        }
    }
}