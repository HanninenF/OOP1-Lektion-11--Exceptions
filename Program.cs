namespace P01;

internal enum PracticeTask
{
  ParseIntegerWithExceptionHandling,
  DivideTwoNumbers,
}

internal static class Program
{
  internal static void Main()
  {
    PracticeTask exercise = PracticeTask.DivideTwoNumbers;
    switch (exercise)
    {
      case PracticeTask.ParseIntegerWithExceptionHandling:
        /*  Övning 1 - Konvertera sträng till tal */

        /*  Använd try/catch för att hantera FormatException om strängen inte är ett giltigt tal.
   Lägg även till en OverflowException-hantering om talet är för stort eller för litet för en int.
   Skriv ut ett trevligt felmeddelande i båda fallen.
   Testa att skapa en loop som fortsätter fråga användaren om ett tal tills en giltig inmatning ges.
   Startkod */
        while (true)
        {
          string userInput = Console.ReadLine() ?? "";
          try
          {
            int parsedNumber = int.Parse(userInput);
            break;
          }
          catch (FormatException)
          {
            Console.WriteLine("Det var inte ett giltigt nummer");
          }
          catch (OverflowException)
          {
            Console.WriteLine("Numret är för stort");
          }
        }

        break;
      case PracticeTask.DivideTwoNumbers:
        decimal numerator = ReadValidDecimalFromUser();
        decimal denominator = ReadValidDecimalFromUser();

        try
        {
          decimal divisionResult = DivideTwoNumbers(numerator, denominator);
          Console.WriteLine($"Resultatet blir: {divisionResult}");
        }
        catch (DivideByZeroException)
        {
          Console.WriteLine("Du kan inte dela med noll");
        }

        break;
    }
    decimal DivideTwoNumbers(decimal numerator, decimal denominator)
    {
      return numerator / denominator;
    }

    decimal ReadValidDecimalFromUser()
    {
      while (true)
      {
        string userInput = ReadNumberInputFromUser();
        decimal? parsedNumber = TryParseDecimal(userInput);

        if (parsedNumber.HasValue)
        {
          return parsedNumber.Value;
        }
      }
    }

    string ReadNumberInputFromUser()
    {
      Console.WriteLine("skriv ett tal");
      string userInput = Console.ReadLine() ?? "";
      return userInput;
    }

    decimal? TryParseDecimal(string userInput)
    {
      try
      {
        return decimal.Parse(userInput);
      }
      catch (FormatException)
      {
        Console.WriteLine("Skriv ut ett giltigt tal");
        return null;
      }
      catch
      {
        Console.WriteLine("Något gick fel");
        return null;
      }
    }
  }
}
