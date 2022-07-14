using static BootcampFunctions.MostProfitableDepartment;

namespace BootcampFunctions.Test
{
  public class MostProfitableDepartmentTest
  {
    [Fact]
    public void ShouldBeAbleToReturnTheHighestDepartment()
    {
      List<Depart> itemsList = new List<Depart>()
      {
        { new Depart() { Department = "hardware", Sales = 4500, Day = "Monday" }},
        { new Depart() { Department = "outdoor", Sales = 1500, Day = "Monday" }},
        { new Depart() { Department = "carpentry", Sales = 5500, Day = "Monday" }},
        { new Depart() { Department = "hardware", Sales = 7500, Day = "Tuesday" }},
        { new Depart() { Department = "outdoor", Sales = 2505, Day = "Tuesday" }},
        { new Depart() { Department = "carpentry", Sales = 1540, Day = "Tuesday" }},
        { new Depart() { Department = "hardware", Sales = 1500, Day = "Wednesday" }},
        { new Depart() { Department = "outdoor", Sales = 8507, Day = "Wednesday" }},
        { new Depart() { Department = "carpentry", Sales = 8009, Day = "Wednesday" }},
        { new Depart() { Department = "hardware", Sales = 12000, Day = "Thursday" }},
        { new Depart() { Department = "outdoor", Sales = 18007, Day = "Thursday" }},
        { new Depart() { Department = "carpentry", Sales = 6109, Day = "Thursday" }},
        { new Depart() { Department = "hardware", Sales = 7005, Day = "Friday" }},
        { new Depart() { Department = "outdoor", Sales = 12006, Day = "Friday" }},
        { new Depart() { Department = "carpentry", Sales = 16109, Day = "Friday" }},
      };



      Assert.Equal("outdoor", MostProfitableDepartment.ProfitableDep(itemsList));
    }
    [Fact]
    public void ShouldBeAbleToReturnTheDepartment()
    {
      List<Depart> highestDep = new List<Depart>()
      {
    {new Depart() {Department = "electronics", Sales = 4500, Day = "Monday"}},
    {new Depart() {Department = "outdoor", Sales = 1500, Day = "Monday"}},
    {new Depart() {Department = "carpentry", Sales = 5500, Day = "Monday"}},
    {new Depart() {Department = "steelwork", Sales = 7500, Day = "Tuesday"}},
    {new Depart() {Department = "outdoor", Sales = 2505, Day = "Tuesday"}},
    {new Depart() {Department = "carpentry", Sales = 1540, Day = "Tuesday"}},
    {new Depart() {Department = "hardware", Sales = 1500, Day = "Wednesday"}},
    {new Depart() {Department = "outdoor", Sales = 8507, Day = "Wednesday"}},
    {new Depart() {Department = "carpentry", Sales = 8009, Day = "Wednesday"}},
    {new Depart() {Department = "hardware", Sales = 12000, Day = "Thursday"}},
    {new Depart() {Department = "carpentry", Sales = 6109, Day = "Thursday"}},
    {new Depart() {Department = "hardware", Sales = 7005, Day = "Friday"}},
    {new Depart() {Department = "electronics", Sales = 12006, Day = "Friday"}},
    {new Depart() {Department = "electronics", Sales = 16109, Day = "Saturday"}},
    {new Depart() {Department = "steelwork", Sales = 7500, Day = "Tuesday"}},
    {new Depart() {Department = "outdoor", Sales = 2505, Day = "Tuesday"}},
    {new Depart() {Department = "carpentry", Sales = 1540, Day = "Tuesday"}},
    {new Depart() {Department = "steelwork", Sales = 1500, Day = "Wednesday"}},
    {new Depart() {Department = "carpentry", Sales = 8009, Day = "Wednesday"}},

      };
      Assert.Equal("electronics", MostProfitableDepartment.ProfitableDep(highestDep));

    }
  }
}