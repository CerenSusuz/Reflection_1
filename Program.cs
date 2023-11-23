public class Program
{
    public static void Main()
    {
        Type type = typeof(MyNamespace.MyClass);
        Console.WriteLine(type.AssemblyQualifiedName);
        Console.WriteLine(type.FullName);
    }
}

namespace MyNamespace
{
    public class MyClass
    {
    }
}
