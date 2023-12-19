public class Atm{
   private double balance=3000;
    

    public void bankOperation(double takeMoney = 0, double depositMoney = 0){
         Console.WriteLine($"Your current balance is: {balance}");

Console.WriteLine("Hello what do you want to do to  ? ");
Console.WriteLine(" to take money please enter 1 ,to depositmoney enter 2  ");

int inputNumber=Convert.ToInt16 (Console.ReadLine());

if (inputNumber==1)
{

    Console.WriteLine("how much money do you want to take:  ");
    double moneyToTake=Convert.ToDouble(Console.ReadLine());
     Console.WriteLine($" the amout of money you take is :{moneyToTake} ");
     Console.WriteLine($"your balance now is  : {balance-moneyToTake} ");
     if (moneyToTake< 0 &moneyToTake> balance){
        Console.WriteLine($" your balnce is only {balance} ");

     }
   

}else if(inputNumber==2){
     Console.WriteLine("how much money do you want to deposit :  ");
    double moneyToDeposit=Convert.ToDouble(Console.ReadLine());
     Console.WriteLine($" the amout of money you take is :{moneyToDeposit} ");
     Console.WriteLine($"your balance now is  : {balance+moneyToDeposit} ");

}else{
    Console.WriteLine(" invalid number please try again   ");
}

   
    }
}