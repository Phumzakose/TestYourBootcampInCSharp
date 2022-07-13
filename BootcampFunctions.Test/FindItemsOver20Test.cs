namespace BootcampFunctions.Test
{
  public class FindItemsOver20Test
  {
    [Fact]
    public void ShouldBeAbleToReturnItemsOver20()
    {
      List<Item> li = new List<Item>()
       {
       {
          new Item() {Name = "apples",Qty = 10}
        },
       {
        new Item() {Name = "pears",Qty = 37}
       },

       {
        new Item() {Name = "banana",Qty = 27}
       },
       {
        new Item() {Name = "grapes",Qty = 3}
       }
       };

      List<Item> expectedList = new List<Item>()
         {
          {
        new Item() {Name = "pears",Qty = 37}
       },

       {
        new Item() {Name = "banana",Qty = 27}
       }
         };

      Assert.Equal(expectedList.ToString(), FindItemsOver20.ItemsOver20(li).ToString());
    }
    [Fact]
    public void ShouldBeAbleToReturnAllItemsOver20()
    {
      List<Item> secondList = new List<Item>()
       {
       {
          new Item() {Name = "apples",Qty = 10}
        },
       {
        new Item() {Name = "pears",Qty = 37}
       },
       {
        new Item() {Name = "grapes",Qty = 3}
       }
       };
      List<Item> results = new List<Item>()
         {
          {
        new Item() {Name = "pears",Qty = 37}
       },
         };

      Assert.Equal(results.ToString(), FindItemsOver20.ItemsOver20(secondList).ToString());
    }
  }
}