namespace BootcampFunctions
{
  public class MostProfitableDepartment
  {
    public static string ProfitableDep(List<Depart> Items)
    {
      Dictionary<string, int> dep = new Dictionary<String, int>();

      foreach (var department in Items)
      {
        if (!dep.ContainsKey(department.Department))
        {
          dep.Add(department.Department, department.Sales);
        }
        else
        {
          dep[department.Department] += department.Sales;
        }
      }
      var highestSales = 0;
      var profitableDep = "";

      foreach (var item in dep.Keys)
      {
        if (dep[item] > highestSales)
        {
          highestSales = dep[item];
          profitableDep = item;
        }
      }
      return profitableDep;

    }
    public class Depart
    {
      public string Department { get; set; } = string.Empty;

      public int Sales { get; set; }

      public string Day { get; set; } = string.Empty;


    }
  }
}












