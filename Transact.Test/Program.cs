using System;
using System.Reflection;

namespace Transact.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter lower value ");
            var lowerValue = GetValue();
            Console.WriteLine("Your input: {0}", lowerValue);

            Console.WriteLine("Please enter higher value ");
            var higherValue = GetValue();
            Console.WriteLine("Your input: {0}", higherValue);


            Console.WriteLine("Please enter first value ");
            var a = GetValidValue(lowerValue, higherValue);
            Console.WriteLine("Your input: {0}", a);

            Console.WriteLine("Please enter second value ");
            var b = GetValidValue(lowerValue, higherValue);
            Console.WriteLine("Your input: {0}", b);

            for (int i = lowerValue; i < higherValue; i++)
            {
                IsDivisible(i, a, b);
            }

            Console.ReadKey();

        }

        private static int GetValue()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Wrong input! Please enter numeric value");
            }

             
            return choice;
        }

        private static int GetValidValue(int lowerValue, int higherValue)
        {
            var result = GetValue();

            if (result >= lowerValue && result <= higherValue) 
                return result;

            Console.WriteLine($"Invalid Input, Please enter a value between {lowerValue} to {higherValue} ");
            GetValidValue(lowerValue, higherValue);

            return result;
        }

        private static void IsDivisible(int currentIndex, int a, int b)
        {
            if (currentIndex % a == 0)
            {
                Console.WriteLine("Fancy");
            }

            if (currentIndex % b == 0)
            {
                Console.WriteLine("Pants");
            }

            if (currentIndex % a == 0 && currentIndex % b == 0)
            {
                Console.WriteLine("FancyPants");
            }
        }
    }
}
