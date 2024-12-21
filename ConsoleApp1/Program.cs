using System.ComponentModel;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Value Types: Store actual data, copied on assignment, stored in the stack.
            //static void PassByValue(int x)
            //{
            //    x = 20; // Changes only the local copy
            //}
            //int num = 10;
            //Console.WriteLine("Before method call: " + num); // Outputs: 10
            //PassByValue(num);
            //Console.WriteLine("After method call: " + num); // Outputs: 10
            #endregion
            #region Q2
            //Reference Types: Store a reference to data, shared on assignment, stored in the heap.
            //static void PassByReference(ref int[] array)
            //{
            //    array[0] = 99; // Modifies the original array object
            //}
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine("Before method call: " + arr[0]); // Outputs: 1
            //PassByReference(ref arr);
            //Console.WriteLine("After method call: " + arr[0]); // Outputs: 99
            #endregion
            #region Q3

            //static void Calculate(int num1, int num2, int num3, int num4)
            //{
            //    int summation = num1 + num2 - num3 - num4;
            //    Console.WriteLine($"Summation of the numbers: {summation}");
            //}

            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter third number: ");
            //int num3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter fourth number: ");
            //int num4 = int.Parse(Console.ReadLine());
            //Calculate(num1, num2, num3, num4);
            #endregion
            #region Q4
            //static int SumOfDigits(int number)
            //{
            //    int sum = 0;
            //    while (number > 0)
            //    {
            //        sum += number % 10; 
            //        number /= 10; 
            //    }
            //    return sum;
            //}
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int result = SumOfDigits(number);
            //Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
            #endregion
            #region Q5
            //static bool IsPrime(int number)
            //{
            //    if (number <= 1)
            //        return false;

            //    for (int i = 2; i * i <= number; i++)
            //    {
            //        if (number % i == 0) 
            //            return false;
            //    }

            //    return true; 
            //}
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //bool result = IsPrime(number);
            //if (result)
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            #endregion
            #region Q6
            //static void MinMaxArray(int[] array, ref int min, ref int max)
            //{
            //    min = array[0];
            //    max = array[0];
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i] < min)
            //            min = array[i]; 
            //        if (array[i] > max)
            //            max = array[i]; 
            //    }
            //}
            //int[] numbers = { 10, 20, 5, 8, 30, 15 };
            //int min = 0, max = 0;
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"Minimum value in the array: {min}");
            //Console.WriteLine($"Maximum value in the array: {max}");
            #endregion
            #region Q7
            //static long Factorial(int number)
            //{
            //    long result = 1;

            //    for (int i = 1; i <= number; i++)
            //    {
            //        result *= i; 
            //    }

            //    return result; 
            //}
            //Console.Write("Enter a number to calculate its factorial: ");
            //int number = int.Parse(Console.ReadLine());
            //long factorial = Factorial(number);
            //Console.WriteLine($"The factorial of {number} is: {factorial}");
            #endregion
            #region Q8
            //static string ChangeChar(string input, int position, char newChar)
            //{
            //    if (position < 0 || position >= input.Length)
            //    {
            //        return "Invalid position."; 
            //    }
            //    return input.Substring(0, position) + newChar + input.Substring(position + 1);
            //}
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter the position (0-based index) to modify: ");
            //int position = int.Parse(Console.ReadLine());

            //Console.Write("Enter the new character: ");
            //char newChar = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //string result = ChangeChar(input, position, newChar);
            //Console.WriteLine($"Result: {result}");
            #endregion
        }
    }
}
