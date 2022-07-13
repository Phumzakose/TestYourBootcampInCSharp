namespace BootcampFunctions
{

public class TotalPhoneBill
{
  public static String PhoneBill(string bill)
  {
    double totalPhoneBill = 0;
    
    string [] callsAndSms = bill.Split(",");
    for(int i=0; i<callsAndSms.Length; i++){
      string callsAndSmsMade = callsAndSms[i].Trim();
      if(callsAndSmsMade == "call"){
        totalPhoneBill+=2.75;
      }
      else if(callsAndSmsMade == "sms"){
        totalPhoneBill += 0.65;
      }
      else if(callsAndSmsMade == "data"){
        totalPhoneBill+= 1.50;
      }
    
    }
    return "R" + totalPhoneBill;
  }
}
}
