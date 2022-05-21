Methods _key = new Methods(); // this is called constructor, this one is an empty constructor

//two methods same name that take 2 different types of parameters, is called overloading 

Console.WriteLine(fullName{"Trevor", Stuart});
public class Methods
{
//int x = ExplainMethod(3); -- variables must have the same datatype as the method's return type
    public void ExplainMethod(int x)
    {
        //Method Body 
        Console.WriteLine("PUBLIC IS THE ACCESS MODIFIER");
        Console.WriteLine("VOID IS THE RETURN TYPE");
        Console.WriteLine("ExplainMethod is the Name");
        Console.WriteLine("int x is the Parameter");
        Console.Write("NAME + PARAMS = SIGNATURE");
    }
public string fullName(string first, string last)
{
    return $"{first} {last}";
}

}

