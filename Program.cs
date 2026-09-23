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
        break;
    }
  }
}
