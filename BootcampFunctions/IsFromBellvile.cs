namespace BootcampFunctions
{
public class IsFromBellville
{
  public static bool CheckReg(string reg)
  {
    if(reg.StartsWith("CY")){
      return true;
    }
    else{
      return false;
    }
  }
}

}

