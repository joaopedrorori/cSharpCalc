using System;
using System.Globalization;
namespace CalcProject
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello! What is the mathematic operation that you want to do?");
      Console.WriteLine("Type 1 if you want to make an addition!");
      Console.WriteLine("Type 2 if you want to make a subtraction!");
      Console.WriteLine("Type 3 if you want to make a multiplication!");
      Console.WriteLine("Type 4 if you want to make a division!");
      int operationOption = int.Parse(Console.ReadLine());

      Console.WriteLine("Ok! Now tell me the first number you want to use.");
      double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//para padronizar
      Console.WriteLine("Now tell me the second number you want to use.");
      double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//para padronizar

      double result = 0;

      switch (operationOption)
      {
        case 1:
          result = Add(num1, num2);
          Console.WriteLine($"The result of yout addition is: {result}");
        break;
        case 2:
          result = Sub(num1, num2);
          Console.WriteLine($"The result of yout subtraction is: {result}");
        break;
        case 3:
          result = Mult(num1, num2);
          Console.WriteLine($"The result of yout multiplication is: {result}");
        break;
        case 4:
          result = Div(num1, num2);
          Console.WriteLine($"The result of yout division is: {result}");
        break;
        default:
          Console.WriteLine("You can only choose one of the options above.");
        break;
      }
    }
    static double Add(double num1, double num2)
    {
      return num1 + num2;
    }
    static double Sub(double num1, double num2)
    {
      return num1 - num2;
    }
    static double Div(double num1, double num2)
    {
      return num1 / num2;
    }
    static double Mult(double num1, double num2)
    {
      return num1 * num2;
    }
  }
}