namespace BootcampFunctions
{
  public class FindItemsOver
  {
    public static List<Items> ItemsOverThreshold(List<Items> itemsList, int threshold)
    {
      List<Items> greaterItems = new List<Items>();

      // for(int i=0; i<li.Count; i++)
      foreach (var i in itemsList)
      {
        if (i.Qty > threshold) greaterItems.Add(i);
      }
      return greaterItems;
    }
  }
  public class Items
  {
    public string Name { get; set; } = string.Empty;
    public int Qty { get; set; }
  }
}