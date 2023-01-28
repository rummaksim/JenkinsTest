
using MathLibrary;

class Program
{
    public static void Main(string[] args)
    {
        string s = "master change";
        string s2 = "second change";
        string s3 = "second second change";
        double value = 114;
        var lib = new MathCalcs();
        var result = lib.GetResult(value);
        Console.WriteLine(result);
        Console.ReadKey();

    }
}
