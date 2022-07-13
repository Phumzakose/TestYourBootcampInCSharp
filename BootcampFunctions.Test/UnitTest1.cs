namespace BootcampFunctions.Test;

public class GreetTest
{
  [Fact]
  public void ShouldBeAbleToGreetUser()
  {
    Assert.Equal("Hello, Phumza", Greet.Greetings("Phumza"));
  }
  // [Fact]
  // public void ShouldBeAbleToReturnError()
  // {
  //     Assert.Equal("Error", Greet.Greetings(2));
  // }
}