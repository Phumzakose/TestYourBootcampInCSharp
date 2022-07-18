namespace BootcampFunctions.Test;

public class GreetTest
{
  [Fact]
  public void ShouldBeAbleToGreetUser()
  {
    Assert.Equal("Hello, Phumza", Greet.Greetings("Phumza"));
  }
  [Fact]
  public void ShouldBeAbleToReturnErrorMessage()
  {
    Assert.Equal("Please enter your name", Greet.Greetings(""));
  }
}