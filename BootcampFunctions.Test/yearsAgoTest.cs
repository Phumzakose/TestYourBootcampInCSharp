namespace BootcampFunctions.Test
{

public class YearsAgoTest
{
  [Fact]
  public void ShouldBeAbleToCountHowManyYearsAgoFromTheCurrentYear()
  {
    Assert.Equal(46, YearsAgo.CountYearsAgo(1976));
     Assert.Equal(26, YearsAgo.CountYearsAgo(1996));
  }
}

}