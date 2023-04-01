using System;

namespace Methods
{
    class Program
    {
        static double Tg(double x) => Math.Sin(x) / Math.Cos(x);

        static double Rad(double x)

        {
            return ((Math.PI * x) / 180);
        }

        static int Len(string x)
        {
            string[] splitted = x.Split('.');
            string result = String.Join(' ', splitted);
            string res = result.Replace(" ", "");
            return res.Length;
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a float number to calculate: c = y * tg(y) + tg(y), where y - entered float number. ");
            string enter = Console.ReadLine();
            double num = Double.Parse(enter);

            Console.WriteLine("c = " + ( num * Tg(num) + Tg(num)) );


//////////////////////////////////////////////////////////////////////////////////////////////////////////


            Console.WriteLine("\nEnter a degrees value to convert it in radians");
            string degrees = Console.ReadLine();
            double deg = Double.Parse(degrees);

            Console.WriteLine($"It will be {Rad(deg)} radians");


/////////////////////////////////////////////////////////////////////////////////////////////////////////


            Console.WriteLine("\nEnter a number to learn about quantity of numbers in it: ");

            string number = Console.ReadLine();
            Console.WriteLine($"Amount of numbers: {Len(number)}");

        }



    }
}
