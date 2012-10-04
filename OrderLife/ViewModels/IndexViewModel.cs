using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderLife.Models;

namespace OrderLife.ViewModels
{
    public class IndexViewModel
    {

        public Medications meds { get; set; }
        public Doctor doc { get; set; }
    }
}