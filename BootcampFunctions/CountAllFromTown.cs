namespace BootcampFunctions
{

public class CountAllFromTown
{
  public static int AllFromTownRegNumbers(string regA, string regB)
  {
    int count = 0;
   string[] newArray = regA.Split(",");
   for(int i=0; i<newArray.Length; i++){
    string regNum = newArray[i].Trim();
    if(regNum.StartsWith(regB)){
      count++;
    }
   }
   return count;
  }
}
}

