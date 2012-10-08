using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderLife.Domain
{
    public class DatePretty
    {
        public string Prettify(int Day)
        {
            switch (Day)
            {
                case 0:
                    return "Sunday";
                    break;
                case 1:
                    return "Monday";
                    break;
                case 2:
                    return "Tuesday";
                    break;
                case 3:
                    return "Wednesday";
                    break;
                case 4:
                    return "Thursday";
                    break;
                case 5:
                    return "Friday";
                    break;
                case 6:
                    return "Saturday";
                    break;
                default:
                    return "Not a day";
            }
        }
    }
}