using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class Function
    {
        // item 9
        public string ToUpperCase(string val)
        {
            return val.ToUpper();
        }

        public int checkRange(int val)
        {
            try {
                if (val >= 0 && val <= 1000)
                {
                    return val;
                }
                throw new Exception("out of range of 0 to 1000");
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            return 0;
        }

        public int divide(int numerator, int denominator)
        {
            try
            {
                if (denominator != 0) { 
                    return numerator / denominator;
                }
                throw new Exception("0 denominator");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            
        }

        public double squareroot(double val)
        {
            try
            {
                if (val < 0)
                {
                    return Math.Sqrt(val);
                }
                throw new Exception("negative value");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }

        public int checkInt32(string val)
        {
            try
            {
                if (int.TryParse(val, out int value))
                {
                    return value;
                }
                throw new Exception("out of range of int32");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }

        public string checkDateTimeFormat(string val)
        {
            try
            {
                DateTime d;
                bool checkFormat = DateTime.TryParseExact(val, "dd/mm/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None, out d);
                if (checkFormat)
                {
                    return "date format is valid: " + val;
                }
                throw new Exception("date format is invalid: " + val);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }

        }
    }
}
