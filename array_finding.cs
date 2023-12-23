public class ArrayFinding
{
   public void arrayFind()
   {
         Console.WriteLine("enter number of items in array :");
         int numberOfItems=int.Parse(Console.ReadLine());

  
        int []arrayItems=new int[numberOfItems];

        for (int i = 0; i < numberOfItems; i++)
        {
                 Console.WriteLine($"enter items  array :{i+1}");
         arrayItems[i]=int.Parse(Console.ReadLine());   
        }
           


//   Avg
   int sum=0,smallest=int.MaxValue,greatest=0;
        foreach (int  item in arrayItems)
        {
            sum+=item;
            if (item<smallest)
            {
                smallest=item;
            }
              if (item>greatest)
            {
                greatest=item;
            }
          
        }
          Console.WriteLine($"small is {smallest}");
          Console.WriteLine($"great is {greatest}");
        int avg=sum/numberOfItems;

        Console.WriteLine($"avg is :{avg}");



    }
}