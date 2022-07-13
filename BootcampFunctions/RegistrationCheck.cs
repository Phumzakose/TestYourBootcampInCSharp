namespace BootcampFunctions
{
public class RegistrationCheck
{
  public static bool RegCheck(string reg1, string reg2)
  {
    if(reg1.EndsWith(reg2)){
      return true;
    }
    else{
      return false;
    }
  }
}

}
