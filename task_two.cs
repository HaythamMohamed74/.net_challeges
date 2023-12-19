
public class MyClass
{
    [Obsolete("This method is obsolete. Use NewMethod() instead.")]
    public void DeprecatedMethod()
    {
        Console.WriteLine("This method is marked as obsolete.");
    }

    public void NewMethod()
    {
        Console.WriteLine("This is the new method.");
    }


    public void person(ref string name,ref int age){
            Console.WriteLine($"  name is: {name} age is :{age}");
    }

}

