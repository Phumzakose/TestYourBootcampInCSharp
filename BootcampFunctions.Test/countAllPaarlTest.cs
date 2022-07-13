namespace BootcampFunctions.Test
{

public class CountAllPaarlTest
{

  [Fact]
  public void ShouldBeAbleToCountAllTheRegistrationNumbersFromPaarl()
  {
    Assert.Equal(2, CountAllPaarl.CountAllPaarReg("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864"));
  }

  public void ShouldBeAbleToCountIfThereIsRegistrationNumbersFromPaarl()
  {
    Assert.Equal(0, CountAllPaarl.CountAllPaarReg("124,CY 567,CL 345, CF 456,CL 341"));
  }

}
}
