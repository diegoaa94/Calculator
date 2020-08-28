using System;

public class Calculator
{
    public int Add(int a, int b) { return a + b; }
}

public class Logger
{
    public void Log(string message) { Console.WriteLine(message); }
}

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();
        Calculator calculator = new Calculator();
        int firstNumber;
        int secondNumber;
        int result;

        logger.Log("Enter first number: ");
        firstNumber = Convert.ToInt32(Console.ReadLine());
            
        logger.Log("Enter second number: ");
        secondNumber = Convert.ToInt32(Console.ReadLine());
            
        result = calculator.Add(firstNumber, secondNumber);

        logger.Log("Result:\n" + firstNumber + " + " + secondNumber + " = " + result);
    }
}
