
public class SringToArray{
  
string name="haytham";
public void sringToArray(){
    char [] charArray=name.ToCharArray();
    foreach (char c in charArray)
    {
        Console.WriteLine(c);
    }
}

public void sringToList(){
    List <char> charArray=name.ToList();
    foreach (char c in charArray)
    {
        Console.WriteLine(c);
    }
}


public void subStringInList(){
 
        List<string> charList = name.Select(c => c.ToString()).ToList();

        Console.WriteLine("[" + string.Join(",", charList.Select(c => $"\"{c}\"")) + "]");
    }


    // copy specific number of char to char of array 
    public void copySpecificNumberOfCharToArray(){
     
     char[]charArray=name.Substring(0,2).ToCharArray();

      foreach (char item in charArray)
      {
     
        Console.WriteLine(item);
      }
    }
    

}