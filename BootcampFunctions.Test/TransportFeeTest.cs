namespace BootcampFunctions.Test;

public class TransportFeeTest
{
  [Fact]
  public void ShouldBeAbleToCheckWhichShiftToReturnThePrice()
  {
    Assert.Equal("R20", TransportFee.TransportFeeShift("Morning"));
    Assert.Equal("R10", TransportFee.TransportFeeShift("Afternoon"));
    Assert.Equal("Free", TransportFee.TransportFeeShift("Nightshift"));

  }
}