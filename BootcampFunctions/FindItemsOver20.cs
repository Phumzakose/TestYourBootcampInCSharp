namespace BootcampFunctions
{
  public class FindItemsOver20
  {
    public static List<Item> ItemsOver20(List<Item> li)
    {
      List<Item> list = new List<Item>();

      // for(int i=0; i<li.Count; i++)
      foreach (var items in li)
      {
        if (items.Qty > 20) list.Add(items);
      }
      return list;
    }
  }
  public class Item
  {
    public string Name { get; set; } = string.Empty;
    public int Qty { get; set; }
  }
}
