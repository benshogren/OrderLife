using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;            // Database.SetInitialize
using OrderLife.Models;              // MovieInitializer

namespace OrderLife
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            Database.SetInitializer<WorkoutDescriptionDBContext>(new WorkoutInitialized());
            Database.SetInitializer<AppointmentsDBContext>(new SchedInitializer());
            Database.SetInitializer<FinancesDBContext>(new FinanceInitializer());
            Database.SetInitializer<DoctorDBContext>(new DoctorInitializer());
            Database.SetInitializer<ExercisesDBContext>(new ExercisesInitializer());
            Database.SetInitializer<DailyDietDBContext>(new DailyDietInitializer());
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}