using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;            // Database.SetInitialize
using OrderLife.Models;
using OrderLife.Domain;              // MovieInitializer

namespace OrderLife
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogonAuthorize());
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
            Database.SetInitializer<DailyDietEntryDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<DailyDietEntryDBContext>());
            Database.SetInitializer<WorkoutDescriptionDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<WorkoutDescriptionDBContext>());
            Database.SetInitializer<AppointmentsDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<AppointmentsDBContext>());
            Database.SetInitializer<FinancesDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<FinancesDBContext>());
            Database.SetInitializer<DoctorDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<DoctorDBContext>());
            Database.SetInitializer<ExercisesDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<ExercisesDBContext>());
            Database.SetInitializer<AccountsDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<AccountsDBContext>());
            Database.SetInitializer<DailyDietDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<DailyDietDBContext>());
            Database.SetInitializer<HobbiesDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<HobbiesDBContext>());
            Database.SetInitializer<RecipesDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<RecipesDBContext>());
            Database.SetInitializer<MedicationsDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<MedicationsDBContext>());
            Database.SetInitializer<WeeklyDietEntryDBContext>(new Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<WeeklyDietEntryDBContext>());
            

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}