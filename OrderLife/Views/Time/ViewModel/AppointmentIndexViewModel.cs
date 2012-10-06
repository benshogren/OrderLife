using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderLife.Models;

namespace OrderLife.Views.Time.ViewModel
{
    public class AppointmentIndexViewModel
    {
        public List<AppointmentViewModel> appointments;
        public List<Hobbies> hobbies;
        public AppointmentViewModel[,] calendarTableData;
    }
}