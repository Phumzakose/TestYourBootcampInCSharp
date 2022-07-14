namespace BootcampFunctions.Test
{
  public class FindItemsOverTest
  {
    [Fact]
    public void ShouldBeAbleToReturnItemsOverThreshold()
    {
      List<Items> itemsList = new List<Items>()
       {
       {
          new Items() {Name = "peaches",Qty = 10}
        },
       {
        new Items() {Name = "pears",Qty = 37}
       },

       {
        new Items() {Name = "oranges",Qty = 27}
       },
       {
        new Items() {Name = "grapes",Qty = 3}
       }
       };

      List<Items> newList = new List<Items>()
         {
          {
        new Items() {Name = "pears",Qty = 37}
       },
         };

      Assert.Equal(newList.ToString(), FindItemsOver.ItemsOverThreshold(itemsList, 30).ToString());
    }
    [Fact]
    public void ShouldBeAbleToReturnAnEmptyList()
    {
      List<Items> itemsList = new List<Items>()
       {
       {
          new Items() {Name = "peaches",Qty = 10}
        },
       {
        new Items() {Name = "pears",Qty = 37}
       },

       {
        new Items() {Name = "oranges",Qty = 27}
       },
       {
        new Items() {Name = "grapes",Qty = 3}
       }
       };

      List<Items> newList = new List<Items>()
      {
      };

      Assert.Equal(newList, FindItemsOver.ItemsOverThreshold(itemsList, 40));
    }
  }
}


