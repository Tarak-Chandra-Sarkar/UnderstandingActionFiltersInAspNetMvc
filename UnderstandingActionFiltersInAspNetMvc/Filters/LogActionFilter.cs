using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UnderstandingActionFiltersInAspNetMvc.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("OnResultExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);
        }

        private void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];

            var msg = String.Format($"ActionFiter Log:  {methodName} controller: {controllerName} action: {actionName}");

            // Debug.WriteLine(msg, "ActionFilter Log");

            System.IO.File.AppendAllText(HttpContext.Current.Server.MapPath("~/App_Data/ActionFilterLog.log"), msg + Environment.NewLine, System.Text.Encoding.UTF8);
        }
    }
}