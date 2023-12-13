using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Generate random numbers
        Random random = new Random();
        double commonNumber1 = random.NextDouble();
        double commonNumber2 = random.NextDouble();

        // Add two numbers as floats and measure time
        Stopwatch floatStopwatch = Stopwatch.StartNew();
        float floatResult = AddFloats((float)commonNumber1, (float)commonNumber2);
        floatStopwatch.Stop();
        Console.WriteLine($"Group A Number 1 Results");
        Console.WriteLine($"Float Result: {floatResult}");
        Console.WriteLine($"Time taken to add two floats: {floatStopwatch.Elapsed}");

        // Add two numbers as doubles and measure time
        Stopwatch doubleStopwatch = Stopwatch.StartNew();
        double doubleResult = AddDoubles(commonNumber1, commonNumber2);
        doubleStopwatch.Stop();

        Console.WriteLine($"Double Result: {doubleResult}");
        Console.WriteLine($"Time taken to add two doubles: {doubleStopwatch.Elapsed}");
   


//This is the end of Group A question and the Start of Group B Question





        // Generate a random number
        Random random1 = new Random();
        double randomNumber = random.NextDouble();

        // Measure time for direct multiplication
        Stopwatch directMultiplicationStopwatch = Stopwatch.StartNew();
        double directMultiplicationResult = SquareByMultiplication(randomNumber);
        directMultiplicationStopwatch.Stop();

        Console.WriteLine($"Group B Number 3 Results");
        Console.WriteLine($"Direct Multiplication Result: {directMultiplicationResult}");
        Console.WriteLine($"Time taken for direct multiplication: {directMultiplicationStopwatch.Elapsed}");

        // Measure time for Math.Pow
        Stopwatch mathPowStopwatch = Stopwatch.StartNew();
        double mathPowResult = SquareByMathPow(randomNumber);
        mathPowStopwatch.Stop();

        Console.WriteLine($"Math.Pow Result: {mathPowResult}");
        Console.WriteLine($"Time taken for Math.Pow: {mathPowStopwatch.Elapsed}");

        //Measure time for Math.sqrt
        Stopwatch sqrtStopwatch = Stopwatch.StartNew();
        double sqrtResult = SquareRoot(randomNumber);
        sqrtStopwatch.Stop();

        Console.WriteLine($"Square Root Result: {sqrtResult}");
        Console.WriteLine($"Time taken for Math.Sqrt: {sqrtStopwatch.Elapsed}");
    }

    static float AddFloats(float a, float b)
    {
        return a + b;
    }

    static double AddDoubles(double a, double b)
    {
        return a + b;
    }

    static double SquareByMultiplication(double number)
    {
        return number * number;
    }

    static double SquareByMathPow(double number)
    {
        return Math.Pow(number, 2);
    }

    static double SquareRoot(double number)
    {
        return Math.Sqrt(number);
    }
}
