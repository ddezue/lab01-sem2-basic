using System;

namespace Assignment1
{
 
  public class PowerCalculator
  {
    public static long CalculatePower(long baseNumber, long exponent)
    {
      int currentIteration;
      int ExponentZeroResult;
      long result;

      ExponentZeroResult = 1;

      if (exponent == 0) {
        return ExponentZeroResult;
      }
      
      result = baseNumber;

      for (currentIteration = 1; currentIteration < exponent; ++currentIteration) {
        result *= baseNumber;
      }

      return result;
    }
  }

  public class NumberTransformer
  {
    private static int MinimumNumberLength;
    private static int SecondDigitIndex;

    static NumberTransformer()
    {
      MinimumNumberLength = 3;
      SecondDigitIndex = 1;
    }

    public static int TransformNumber(int originalNumber)
    {
      string numberAsString;
      char secondDigit;
      string withoutSecondDigit;
      string resultAsString;
      int transformedResult;

      numberAsString = originalNumber.ToString();

      if (numberAsString.Length < MinimumNumberLength) {
        return originalNumber;
      }

      
      secondDigit = numberAsString[SecondDigitIndex];
      withoutSecondDigit = numberAsString.Remove(SecondDigitIndex, 1);
      
      resultAsString = withoutSecondDigit + secondDigit;
      transformedResult = int.Parse(resultAsString);

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
      int baseNumber;
      int exponent;
      long powerResult;

      Console.Write("Task 1: a^n \nInsert a: ");
      baseNumber = int.Parse(Console.ReadLine());

      Console.Write("Insert n: ");
      exponent = int.Parse(Console.ReadLine());

      powerResult = PowerCalculator.CalculatePower(baseNumber, exponent);
      Console.WriteLine("Result: " + powerResult);
    }

    private static void ExecuteSecondTask()
    {
      int originalNumber;
      int transformedResult;

      Console.Write("\nTask 2: Number Transformation \nInsert x (>= 100): ");
      originalNumber = int.Parse(Console.ReadLine());

      transformedResult = NumberTransformer.TransformNumber(originalNumber);
      Console.WriteLine("Result: " + transformedResult);
    }
  }
}