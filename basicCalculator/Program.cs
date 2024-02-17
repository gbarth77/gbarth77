internal class Program
{
    private static void Main(string[] args)
    {
        /* Basic operating calculator based on the 2 typed int numbers
        that will be shown in 'result'*/
        Console.WriteLine("Insert your first number, please.");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Insert your second number.");
        int number2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Please select 1 of our math operators.");
        System.Console.WriteLine("Press 'a' to add, press 's' to subtract, press 'm' to multiplie and press 'd' to divide");
        string? answer = Console.ReadLine();
        
        if (answer == "a")
        {
            int result = number1 + number2;
            System.Console.WriteLine($"{number1} + {number2} = {result}");
        }
        else if (answer == "s")
        {
            int result = number1 - number2;
            System.Console.WriteLine($"{number1} - {number2} = {result}");
        }
        else if (answer == "m")
        {
            int result = number1 * number2;
            System.Console.WriteLine($"{number1} x {number2} = {result}");
        }
        else if (answer == "d")
        {
            int result = number1 / number2;
            System.Console.WriteLine($"{number1} / {number2} = {result}");
        }
        
        else
        {
            System.Console.WriteLine("Please type a valid answer");
        }
    }
}