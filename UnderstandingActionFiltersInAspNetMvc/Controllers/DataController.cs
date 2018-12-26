using System;
using System.Web.Mvc;
using UnderstandingActionFiltersInAspNetMvc.Filters;

namespace UnderstandingActionFiltersInAspNetMvc.Controllers
{
    [LogActionFilter]
    public class DataController : Controller
    {
        [OutputCache(Duration=10)]
        public string Time()
        {
            return DateTime.Now.ToString("T");
        }
    }
}