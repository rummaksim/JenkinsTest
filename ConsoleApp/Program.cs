﻿
using MathLibrary;

class Program
{
    public static void Main(string[] args)
    {
        string s = "master change";
        double value = 114;
        var lib = new MathCalcs();
        var result = lib.GetResult(value);
        Console.WriteLine(result);
        Console.ReadKey();

    }
}
