public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        ExampleClass obj1 = new ExampleClass(10);
        ExampleClass obj2 = new ExampleClass(20);

        // Correct comparison using .Equals()
        if (obj1.Equals(obj2))
        {
            Console.WriteLine("Objects are equal");
        }
        else
        {
            Console.WriteLine("Objects are not equal");
        }
    }
}