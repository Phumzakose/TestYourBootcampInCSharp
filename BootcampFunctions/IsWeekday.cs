namespace BootcampFunctions
{

public class IsWeekDay
{
  public static bool CheckWeekday(string days)
  {
    string weekDays = days.ToLower();
    if(weekDays.StartsWith("s")){
      return false;
    }
    else{
      return true;
    }
  }
}

}
