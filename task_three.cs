// using System ;
// namespace First;

public class CheckStrings{


public void checkString(string nameOne,string nameTwo){

if (nameOne==nameTwo)
{
 Console.WriteLine(" two strings are equal");  
}else{
     Console.WriteLine(" two strings no equal");  
}

}

public void weekDay(int weekDayNumber){
    weekDayNumber=Convert.ToInt16(Console.ReadLine());
    if(weekDayNumber==1){
 Console.WriteLine(" satrday");  
    }else if(weekDayNumber==2){
         Console.WriteLine(" sunday");  
    }else if(weekDayNumber==3){
         Console.WriteLine(" monday");  
    }else if(weekDayNumber==4){
         Console.WriteLine(" tusday");  
    }else if(weekDayNumber==5){
         Console.WriteLine(" wensday");  
    }else if(weekDayNumber==6){
         Console.WriteLine(" thursday");  
    }else if(weekDayNumber==7){
         Console.WriteLine(" friday");  
    }else{
         Console.WriteLine(" please input write day !!");  
    }
    
  
}
  
}