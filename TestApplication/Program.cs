using System.Globalization;
using TestApplication;

namespace main.application {
    public class Program
    {
        public static void Main(string[] args)
        {
            Function fun = new Function();
            Console.WriteLine("input string");
            string input = Console.ReadLine();
            Console.WriteLine("uppercase value: " + fun.ToUpperCase(input));
            Console.WriteLine("input number between 0 to 1000");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value: " + fun.checkRange(input2));
            Console.WriteLine("numerator");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("denominator");
            int den = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value: " + fun.divide(num, den));
            Console.WriteLine("input number");
            double sqrt = double.Parse(Console.ReadLine());
            Console.WriteLine("value: " + fun.squareroot(num));
            Console.WriteLine("input int32");
            string interger = Console.ReadLine();
            Console.WriteLine("value: " + fun.checkInt32(interger));
            Console.WriteLine("enter date (dd/mm/yyyy)");
            string date = Console.ReadLine();
            Console.WriteLine("value: " + fun.checkDateTimeFormat(date));

        }
    }
}

