using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21_part2
{
    public delegate T Operation<T>(T num1, T num2);

    class Program
    {
       
        public static T Add<T>(T a, T b) => (dynamic)a + b;
        public static T Subtract<T>(T a, T b) => (dynamic)a - b;
        public static T Multiply<T>(T a, T b) => (dynamic)a * b;
        public static T Divide<T>(T a, T b)
        {
            if (b.Equals((dynamic)0))
            {
                Console.WriteLine("Cannot divide by zero. Returning default value.");
                return default(T);
            }
            else
                return (dynamic)a / b;
        }

        static void Main()
        {
            
            Operation<int> addDelegate = Add;
            Operation<int> subtractDelegate = Subtract;
            Operation<int> multiplyDelegate = Multiply;
            Operation<int> divideDelegate = Divide;

           
            Console.Write("Enter the first value: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second value: ");
            int num2 = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            
            int choice = int.Parse(Console.ReadLine());
            int result = 0;

            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    break;
                case 4:
                    result = divideDelegate(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }

    }
}
