public class Palidrome
{

  public void palidrome()
  {
string word=Console.ReadLine();
bool isPalind=true;
  
for (int i = 0; i < word.Length/2; i++)
{
    if (word[i]!=word[word.Length-i-1])
    {
        isPalind=false;   
        break;
    }
 
}
  Console.WriteLine($"{isPalind}");

  }

}