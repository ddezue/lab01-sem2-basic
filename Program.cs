using System;

namespace Assignment1
{
  public class PowerCalculator
  {
    public static long CalculatePower(long baseNumber, long exponent)
    {
      int ExponentZeroResult = 1;

      if (exponent == 0) {
        return ExponentZeroResult;
      }

      long result = baseNumber;

      for (int currentIteration = 1; currentIteration < exponent; ++currentIteration) {
        result *= baseNumber;
      }

      return result;
    }
  }

  public class NumberTransformer
  {
    private int MinimumNumberLength = 3;
    private int SecondDigitIndex = 1;

    public static int TransformNumber(int originalNumber)
    {
      string numberAsString = originalNumber.ToString();

      if (numberAsString.Length < MinimumNumberLength) {
        return originalNumber;
      }

      char secondDigit = numberAsString[SecondDigitIndex];
      string withoutSecondDigit = numberAsString.Remove(SecondDigitIndex, 1);

      string resultAsString = withoutSecondDigit + secondDigit;
      int transformedResult = int.Parse(resultAsString);

      return transformedResult;
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      ExecuteFirstTask();
      ExecuteSecondTask();
    }

    private static void ExecuteFirstTask()
    {
      Console.WriteLine("Task 1: a^n ");

      Console.Write("Insert a: ");
      int baseNumber = int.Parse(Console.ReadLine());

      Console.Write("Insert n: ");
      int exponent = int.Parse(Console.ReadLine());

      long powerResult = PowerCalculator.CalculatePower(baseNumber, exponent);
      Console.WriteLine("Result: " + powerResult);
    }

    private static void ExecuteSecondTask()
    {
      Console.WriteLine("Task 2: Number Transformation ");

      Console.Write("Insert x (>= 100): ");
      int originalNumber = int.Parse(Console.ReadLine());

      int transformedResult = NumberTransformer.TransformNumber(originalNumber);
      Console.WriteLine("Result: " + transformedResult);
    }
  }
}