namespace BootcampFunctions.Test
{

  public class CountAllFromTownTest
  {
    [Fact]
    public void ShouldBeAbleToCountAllTheRegistrationNumbersFromTown()
    {
      Assert.Equal(3, CountAllFromTown.AllFromTownRegNumbers("CL 124,CY 567,CL 345, CJ 456,CL 341", "CL"));
      Assert.Equal(1, CountAllFromTown.AllFromTownRegNumbers("CJ 124,CY 567,CL 345, CF 456, CL 341", "CF"));
      Assert.Equal(0, CountAllFromTown.AllFromTownRegNumbers("CJ 124,CF 567,CL 345, CF 456, CL 341", "CY"));

    }
  }

}