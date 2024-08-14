using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        //Bai1();
        //Bai2();
        //Bai3();
        //Bai4();
        //Bai5();
        //Bai6();
        //Bai8();
        //Bai9();
        //Bai10();
    }
    
    static void Bai1()
    {
        Console.Write("Input a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Sum: {a + b}");
    }
    static void Bai2()
    {
        Console.Write("Input A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before change:");
        Console.WriteLine($"A is {A}");
        Console.WriteLine($"B is {B}");
        A = A + B;
        B = A - B;
        A = A - B;
        Console.WriteLine("After change:");
        Console.WriteLine($"A is {A}");
        Console.WriteLine($"B is {B}");
    }
    static void Bai3()
    {
        Console.Write("Input d ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input e ");
        double e = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Tich: {d * e} ");
    }
    static void Bai4()
    {
        Console.Write("Input measurement: ");
        double f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your measurement in meters is: {f * .3048} meters");
    }
    static void Bai5()
    {
        Console.Write("Input your data: ");
        int data = Convert.ToInt32(Console.ReadLine());
        Console.Write("F or C: ");
        string sys = Convert.ToString(Console.ReadLine());
        if (sys == "F")
        {
            Console.WriteLine($"Your data in C: {(data - 32) * 5 / 9}");
        }
        else
        {
            Console.WriteLine($"Your data in F: {data * 9 / 5 + 32}");
        }
    }
    static void Bai6()
    {
        Console.WriteLine($" The size of 'bool' type data is: {sizeof(bool)}");
        Console.WriteLine($" The size of 'char' type data is: {sizeof(char)}");
        Console.WriteLine($" The size of 'sbyte' type data is: {sizeof(sbyte)}");
        Console.WriteLine($" The size of 'byte' type data is: {sizeof(byte)}");
        Console.WriteLine($" The size of 'float' type data is: {sizeof(float)}");
        Console.WriteLine($" The size of 'double' type data is: {sizeof(double)}");
        Console.WriteLine($" The size of 'decimal' type data is: {sizeof(decimal)}");
        Console.WriteLine($" The size of 'short' type data is: {sizeof(short)}");
        Console.WriteLine($" The size of 'long' type data is: {sizeof(long)}");
        Console.WriteLine($" The size of 'ushort' type data is: {sizeof(ushort)}");
        Console.WriteLine($" The size of 'ulong' type data is: {sizeof(ulong)}");
    }
    static void Bai8()
    {
        Console.Write("Radius of the Circle: ");
        int rad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Area of your circle: {(rad^2)*3.14}");
    }
    static void Bai9()
    {
        Console.Write("The side length of your square: ");
        int sidelen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Area of your square: {sidelen ^ 2}");
    }
    static void Bai10()
    {
        Console.Write("Input the days: ");
        int days = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Those days count for {days / 365} year(s), {(days % 365) / 7} week(s) and {((days % 365) % 7)} day(s)");

    }

    
}


