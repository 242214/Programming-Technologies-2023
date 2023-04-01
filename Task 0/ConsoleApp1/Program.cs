// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using ClassLibrary1;
internal class Program
{
    private static void Main(string[] args)
    {
        Class1 a = new Class1();
        Console.WriteLine("3 + 6 = " +  a.Add(3, 6));
    }
}