namespace BootcampFunctions
{

public class YearsAgo
{
  public static int CountYearsAgo(int year)
  {
    int currentYear = DateTime.Now.Year;
    int howLongAgo = currentYear - year;

    return howLongAgo;
  }
}
}
