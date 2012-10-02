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
                case 1:
                    return "Sunday";
                    break;
                case 2:
                    return "Monday";
                    break;
                case 3:
                    return "Tuesday";
                    break;
                case 4:
                    return "Wed";
                    break;
                case 5:
                    return "Thurds";
                    break;
                case 6:
                    return "Fri";
                    break;
                case 7:
                    return "Sat";
                    break;
                default:
                    return "Not a day";
            }
        }
    }
}