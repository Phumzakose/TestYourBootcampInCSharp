namespace BootcampFunctions.Test;

public class RegistrationCheckTest
{
  [Fact]
  public void ShouldBeAbleToCheckIfRegistrationIsFromGauteng()
  {
    Assert.Equal(true, RegistrationCheck.RegCheck("DC 55 YU GP", "GP"));

  }
  [Fact]
  public void ShouldBeAbleToCheckIfRegistrationIsFromEasternCape()
  {
    Assert.Equal(true, RegistrationCheck.RegCheck("ERT 123 EC","EC"));
  }
  [Fact]
  public void  ShouldBeAbleToCheckIfRegistrationIsFromLimpompo()
  {
    Assert.Equal(false, RegistrationCheck.RegCheck("FGT 123 MP","GP"));
  }
}