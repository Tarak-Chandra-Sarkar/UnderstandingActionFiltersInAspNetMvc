using System;
using System.Web;
using System.Web.Mvc;

namespace UnderstandingActionFiltersInAspNetMvc.Filters
{
    public class MyCustomErrorHandler : FilterAttribute, IExceptionFilter
    {
        void IExceptionFilter.OnException(ExceptionContext filterContext)
        {
            LogError(filterContext.Exception);
        }

        private void LogError(Exception exception)
        {
            var msg =exception.Message +Environment.NewLine + exception.StackTrace;

            System.IO.File.AppendAllText(HttpContext.Current.Server.MapPath("~/App_Data/MyCustomErrorHandler.log"), msg + Environment.NewLine, System.Text.Encoding.UTF8);
        }
    }
}