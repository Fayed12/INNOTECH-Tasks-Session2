namespace testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 2: Summation from 1 to N

            Console.WriteLine("Enter a number N to calculate the sum from 1 to N:");

            string? numberInput = Console.ReadLine();
            if (int.TryParse(numberInput, out int numberAfterParsing))
            {
                // Using the formula for the sum of the first N natural numbers
                int sumUsingFomula = (numberAfterParsing * (numberAfterParsing + 1)) / 2;
                int sumUsingForLoop = 0;

                // Using a for loop to calculate the sum from 1 to N
                for (int i = 1; i <= numberAfterParsing; i++)
                {
                    sumUsingForLoop += i;
                }
                Console.WriteLine($"The sum from 1 to {numberAfterParsing} by loop is: {sumUsingForLoop} and the Time Complexity is O(N)");
                Console.WriteLine($"The sum from 1 to {numberAfterParsing} by formula is: {sumUsingFomula} and the Time Complexity is O(C)");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}