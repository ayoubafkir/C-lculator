using System;

namespace Calculator
{
    class MyCalculator
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-----------------");
        
        // Ask user for first number 
        Console.Write("Enter the first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        
        // Ask the user for an operator
        Console.Write("Enter an operator (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        // Ask the user for a second number 
        Console.Write("Enter a second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        
        // Perform Calculation
        double result = 0;
        bool validOperation = true;

        switch (op)
        {
            case '+': 
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by 0");
                    validOperation = false;
                }

                break;
            default:
                Console.WriteLine("Error Invalid operator");
                validOperation = false;
                break;
        }
        
        // Display results
        if (validOperation) {
            Console.WriteLine($"Result:{firstNumber} + {secondNumber} = {result}");
        }

        Console.WriteLine("Press any ket to exit...");
        Console.ReadKey();

    }
    }
}

