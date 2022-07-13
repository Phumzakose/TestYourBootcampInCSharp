namespace BootcampFunctions.Test;

public class IsWeekDayTest
{
  [Fact]
 public void ShouldBeAbleToCheckIfTheDayPassedIsAWeekday()
 {
  Assert.Equal(true, IsWeekDay.CheckWeekday("Monday"));
 }
 [Fact]
 public void ShouldBeAbleToCheckIfTheDayPassedIsNotWeekday()
 {
  Assert.Equal(false, IsWeekDay.CheckWeekday("Sunday"));
 }
}