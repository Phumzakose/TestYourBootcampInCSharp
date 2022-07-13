namespace BootcampFunctions
{
  public class FromWhere
  {
    public static string FromWhichTown(string regNumber)
    {
      if(regNumber.StartsWith("CY")){
        return "Bellville";
      }
      else if(regNumber.StartsWith("CA")){
        return "Cape Town";
      }
      else if(regNumber.StartsWith("CJ")){
        return "Paarl";
      }
      else
      {
        return "Other";
      }
    }
  }
}