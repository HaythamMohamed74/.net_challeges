public class  TaskSeven{

string name="moie";


public void CountVowels(){
    int totalNum=0;
    List<char>vowelsChar=new List<char>() { 'a','e','i','o','u'};
    foreach (char item in name)
    {
       if (vowelsChar.Contains(item))
        {
            totalNum++; 
        }  
    }
      Console.WriteLine(totalNum);
   
        
   

}
public string CustomPadRight(string input, int totalLength, char paddingChar)
{
    int spacesToAdd = totalLength - input.Length;
    if (spacesToAdd <= 0)
    {
        return input; // No padding needed or negative padding length
    }
    else
    {
        return input + new string(paddingChar, spacesToAdd);
    }}


}