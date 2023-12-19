public class AvgOfArray{
List<int> myList = new List<int>() { 1, 2, 3, 4,5};

 int sum=0;

public void avgOfArray(){
 foreach (int number in myList)
        {
            sum += number;
        }
int avgOfArray=sum/myList.Count;
 Console.WriteLine($"Your avg is: {avgOfArray}");
  Console.WriteLine($"Your count is: {myList.Count}");



}


}
