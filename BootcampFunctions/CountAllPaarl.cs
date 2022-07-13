namespace BootcampFunctions
{
public class CountAllPaarl
{
  public static int CountAllPaarReg(string regNumbers)
  {
    int count = 0;
    string[] array = regNumbers.Split(",");
    for(int i=0; i<array.Length; i++){
      string paarl = array[i].Trim();
      if(paarl.StartsWith("CJ"))
      {
        count++;
      }
    } 
    return count;
  }
}
}
