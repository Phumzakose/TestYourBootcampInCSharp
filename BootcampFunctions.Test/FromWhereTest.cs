namespace BootcampFunctions.Test
{
public class FromWhereTest
{
  [Fact]
  public void ShouldBeToCheckIfTheRegistrationBelongsToBellville ()
  {
    Assert.Equal("Bellville",FromWhere.FromWhichTown("CY 768-876"));
  }
   [Fact]
  public void ShouldBeToCheckIfTheRegistrationBelongsToCapeTown ()
  {
    Assert.Equal("Cape Town",FromWhere.FromWhichTown("CA 768-876"));
  }
  [Fact]
  public void ShouldBeToCheckIfTheRegistrationBelongsToPaarl ()
  {
    Assert.Equal("Paarl",FromWhere.FromWhichTown("CJ 768-876"));
  }
   [Fact]
  public void ShouldBeToCheckWhereDoesTheRegistrationNumberBelong ()
  {
    Assert.Equal("Other",FromWhere.FromWhichTown("EC 768-876"));
  }
}
}