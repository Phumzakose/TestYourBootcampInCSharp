namespace BootcampFunctions
{

public class TransportFee
{
  public static string TransportFeeShift(string shift)
  {
    if(shift == "Morning"){
      return "R20";
    }
    else if(shift == "Afternoon"){
      return "R10";
    }
    else if(shift == "Nightshift"){
      return "Free";
    }else{
    return "";
    }

  }
}
}
