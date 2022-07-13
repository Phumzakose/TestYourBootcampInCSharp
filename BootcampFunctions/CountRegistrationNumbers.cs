namespace BootcampFunctions
{
public class CountRegistrationNumber
{
  public static int RegNumbers(string regNumbers)
  {
    string[] str = regNumbers.Split(",");
      return str.Length;
  }
} 

}


