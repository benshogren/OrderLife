using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderLife.Controllers;

namespace OrderLife.Domain {
    public class LogonAuthorize : AuthorizeAttribute {
        public override void OnAuthorization(AuthorizationContext filterContext) {
            if (!(filterContext.Controller is AccountController))
                base.OnAuthorization(filterContext);
        }
    }
}