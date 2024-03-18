using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GA_Recursion_TylerSimpson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //testing method
            PrintNumbersFrom1To10(1);
            Console.WriteLine("--------------------------------");
            CountDownAndUp(5);
            Console.WriteLine("--------------------------------");

            int[] numbers = { 12, 45, 7, 23, 9 }; // Adding 5 hardcoded numbers to the array

            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            int sum = CalculateSum(numbers, 0);
            Console.WriteLine($"\nSum of the array elements: {sum}");

            Console.WriteLine("--------------------------------");

            int n = 10; // Change n to the desired Fibonacci sequence length
            Console.WriteLine($"Fibonacci sequence of length {n}:");
            for (int i = 0; i < n; i++)
            {
                int result = Fibonacci(i);
                Console.Write(result + " ");
            }
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static int CalculateSum(int[] arr, int index)
        {
            // Base Case: If the index is equal to the array length, return 0 (no elements to add)
            if (index == arr.Length)
            {
                return 0;
            }
            else
            {
                // Recursive Case:
                // Add the current element (at the current index) to the sum of the rest of the elements
                int currentElement = arr[index];
                int restOfTheSum = CalculateSum(arr, index + 1);
                return currentElement + restOfTheSum;
            }
        }
        static void CountDownAndUp(int currentNumber)
        {
            // Base Case Check for Counting Down: Ensure we don't continue indefinitely while counting down
            if (currentNumber >= 1)
            {
                //Console.WriteLine($"Before Recursive Call: {currentNumber}");

                // Recursive Call: Recursively count down
                CountDownAndUp(currentNumber - 1);

                Console.WriteLine($"After Recursive Call: {currentNumber}");

                // Print the same number while counting up
            }
        }
        static void PrintNumbersFrom1To10(int currentNumber)
        {
            // Step 1: Check if the current number is less than or equal to 10 and go through if statement if it is. Ensure we don't continue indefinitely
            if (currentNumber <= 10)
            {
                // Step 2: Print/output the current number
                Console.WriteLine(currentNumber);
                // Step 3: Increase the current number by 1 and assign to new variable. Move towards the base case (line 12)
                int nextNumber = currentNumber + 1;
                // Step 4: Recursively call(method calling itself) the function with the next number
                PrintNumbersFrom1To10(nextNumber);

                // Step 5: Base Case exit when the recursion reaches 11, it stops automatically because the statment on line 12 is no longer true.
                //This eliminates the need for an else statment. 
            }
        }

        //When a function is called in a program, it's like adding a new plate to the stack.
        //nformation about that function (like variables) is put on that plate
        //If that function calls another function its like stacking another plate on top, and is taken off the stack when said function finishes.
        //adding too many plates causes "stack overflow"
    }
}
