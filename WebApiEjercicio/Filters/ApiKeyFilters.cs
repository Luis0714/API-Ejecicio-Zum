using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiEjercicio.Filters
{
    public class ApiKeyFilters : ActionFilterAttribute
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //throw new NotImplementedException();

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
           // throw new NotImplementedException();

        }
    }
}