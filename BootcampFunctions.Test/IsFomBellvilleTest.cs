namespace BootcampFunctions.Test
{

public class IsFromBellvilleTest
{
  [Fact]
  public void ShouldBeAbleToCheckRegistrationIfItsFromBellville()
  {
    Assert.Equal(true, IsFromBellville.CheckReg("CY 546-098"));
    Assert.Equal(false, IsFromBellville.CheckReg("CF 546-098"));
  }

 }
}
