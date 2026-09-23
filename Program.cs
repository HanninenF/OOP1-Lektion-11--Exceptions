namespace P01;

internal enum PracticeTask
{
  FångaUndantag,
}

internal static class Program
{
  internal static void Main()
  {
    PracticeTask exercise = PracticeTask.FångaUndantag;
    switch (exercise)
    {
      case PracticeTask.FångaUndantag:
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
            int input = int.Parse(userInput);
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
    }
  }
}
