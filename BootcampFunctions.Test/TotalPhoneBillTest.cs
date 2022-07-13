namespace BootcampFunctions.Test
{

public class TotalPhoneBillTest
{
  [Fact]
  public void ShouldBeAbleToCalculateTheTotalPhoneBillForCallsAndSms()
  {
    Assert.Equal("R8,9", TotalPhoneBill.PhoneBill("call, sms, call, call"));
  }
  [Fact]
  public void ShouldBeAbleToCalculateTheTotalPhoneBillForCallsSmsAndData()
  {
    Assert.Equal("R14,65", TotalPhoneBill.PhoneBill("call, sms, call, call, data, data, call"));
  }
  [Fact]
  public void ShouldBeAbleToCalculateTheTotalPhoneBillForCalls()
  {
    Assert.Equal("R11", TotalPhoneBill.PhoneBill("call, call, call, call"));
  }
  }
}

