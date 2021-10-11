using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpert_ThreadedProject3
{
    public static class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value." + LineEnd;
            }
            return msg;
        }

        
        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value." + LineEnd;
            }
            return msg;
        }
        public static string IsInt32_2(string value)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += " must be a valid integer value." + LineEnd;
            }
            return msg;
        }


        public static string IsDate(string value, string name)
        {
            string msg = "";
            if (!DateTime.TryParse(value, out _))
            {
                msg += name + " must be a valid Date." + LineEnd;
            }
            return msg;
        }

        public static string IsWithinRange(string value, string name, decimal min,
            decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + "." + LineEnd;
                }
            }
            return msg;
        }

        public static string IsWithinNumber(string value, string name, int min,
            int max)
        {
            string msg = "";
            int number = value.Length;

            if (number < min || number > max)
            {
                msg += name + " must be between " + min + " characters and " + max + " characters." + LineEnd;
            }

            return msg;
        }

        public static string IsStartEndDate(string value1, string value2)
        {
            string msg = "";

            var date1 = Convert.ToDateTime(value1);
            var date2 = Convert.ToDateTime(value2);

            if (date1 >= date2)
            {
                msg += " The Package End Date must be later than the Package Start Date " + LineEnd;
            }

            return msg;
        }

        public static string IsCommission(string value1, string value2)
        {
            string msg = "";


            if (Decimal.TryParse(value1, out decimal basePrice) && Decimal.TryParse(value2, out decimal commission))
            {
                if (basePrice < commission)
                {
                    msg += " The Agency Commission cannot be greater than the Base Price " + LineEnd;
                }
               
            }
            return msg;


        }



    }
}
