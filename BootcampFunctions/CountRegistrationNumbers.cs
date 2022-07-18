namespace BootcampFunctions
{
  public class CountRegistrationNumber
  {
    public static int RegNumbers(string regNumbers)
    {
      if (regNumbers == "")
      {
        return 0;
      }
      else
      {
        string[] str = regNumbers.Split(",");
        return str.Length;

      }
    }
  }

}


