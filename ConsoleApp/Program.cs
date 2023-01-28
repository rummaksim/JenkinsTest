
using MathLibrary;

class Program
{
    public static void Main(string[] args)
    {
        int a = 2;
        double value = 50;
        var lib = new MathCalcs();
        var result = lib.GetResult(value);
        Console.WriteLine(result);
        Console.ReadKey();

    }
}