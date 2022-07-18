namespace BootcampFunctions.Test
{

  public class CountRegistrationNumberTest
  {
    [Fact]

    public void ShouldBeAbleToCountTheRegistrationNumbers()
    {
      Assert.Equal(3, CountRegistrationNumber.RegNumbers("CA 182736,CY 523519,CJ 812328"));
      Assert.Equal(1, CountRegistrationNumber.RegNumbers("CA 182736"));
    }
    [Fact]
    public void ShouldBeAbleToReturnAnEmptyArrayIfThereAreNoRegistrationNumbers()
    {
      Assert.Equal(0, CountRegistrationNumber.RegNumbers(""));
    }
  }
}
