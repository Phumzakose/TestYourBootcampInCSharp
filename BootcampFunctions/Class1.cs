namespace BootcampFunctions;
public class Greet
{
  public static string Greetings(string name)
  {
    if (name != "")
    {
      return "Hello, " + name;

    }
    else
    {
      return "Please enter your name";
    }

  }

}
