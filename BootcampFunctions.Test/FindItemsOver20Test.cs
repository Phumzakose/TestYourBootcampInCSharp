using Newtonsoft.Json;
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

      Assert.Equal(JsonConvert.SerializeObject(expectedList), JsonConvert.SerializeObject(FindItemsOver20.ItemsOver20(li)));
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

      Assert.Equal(JsonConvert.SerializeObject(results), JsonConvert.SerializeObject(FindItemsOver20.ItemsOver20(secondList)));
    }
    [Fact]
    public void ShouldBeAbleToReturnAnEmptyListIfThereAreNoItemsOver20()
    {
      List<Item> thirdList = new List<Item>()
       {
       {
          new Item() {Name = "apples",Qty = 5}
        },
       {
        new Item() {Name = "pears",Qty = 7}
       },
       {
        new Item() {Name = "grapes",Qty = 3}
       }
       };
      List<Item> result = new List<Item>()
      {

      };
      Assert.Equal(JsonConvert.SerializeObject(result), JsonConvert.SerializeObject(FindItemsOver20.ItemsOver20(thirdList)));
    }
  }
}