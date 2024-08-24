using System;
using System.Collections.Immutable;

internal class Program
{

    static void Main()
    {
        //bai4();
        //bai5();
        //bai6();
        // bai8();
        bai9();
        //bai11();
    }
    static void bai1()
    {
        Console.Write("Input your string: ");
        string a = Console.ReadLine();
        Console.WriteLine("The string you entered is: " + a);
    }
    static void bai2()
    {
        Console.Write("Input your string: ");
        string b = Console.ReadLine();
        Console.WriteLine($"Length of your string is: {b.Length}");
    }
    static void bai3()
    {
        Console.Write("Input your string: ");
        string c = Console.ReadLine();
        for (int i = 0; i < c.Length; i++)
        {
            Console.Write(c[i] + " ");
        }
    }
    static void bai4()
    {
        Console.Write("Input your string: ");
        string d = Console.ReadLine();
        for (int i = d.Length - 1; i >= 0; i--)
        {
            Console.Write(d[i] + " ");
        }
        
    }
    static void  bai5()
    {
        Console.Write("Input your string: ");
        string e = Console.ReadLine();
        int ans = 1;
        for(int i =0; i<e.Length; i++)
        {
            if (e[i] ==' ')
            {
                ans += 1;
            }
        }
        Console.WriteLine("Total number of words in the string is: "+ans );
    }
    static void bai6()
    {
        Console.Write("Input your string: ");
        string a6 = Console.ReadLine();
        Console.Write("Input your string: ");
        string b6 = Console.ReadLine();
        int lena6 = a6.Length;
        int lenb6 = b6.Length;
        if (lena6 == lenb6)
        {
            Console.WriteLine(" The length of both strings are equal");
        }
        else if (lena6 > lenb6)
        {
            Console.WriteLine("String a is longer than string b");
        }
        else
        {
            Console.WriteLine("String b is longer than string a");
        }
    }
    static void bai7()
    {
        Console.Write("Input your string: ");
        string a7 = Console.ReadLine();
        int alpnum = 0;
        int dignum = 0;
        int specialnum = 0;
        foreach (char ch in a7)
        {
            if (Char.IsLetter(ch))
            {
                alpnum++;
            }
            else if (Char.IsDigit(ch))
            {
                dignum++;
            }
            else
            {
                specialnum++;
            }
        }
    }
    static void bai8()
    {
        Console.Write("Input your string: ");
        string a8 = Console.ReadLine();
        string b8 = a8;
        int ans = 1;
        for (int i = 0; i < a8.Length; i++)
        {
            if (a8[i] != ' ')
            {
                ans += 1;
            }
        }
        Console.WriteLine("The First String is: " + a8);
        Console.WriteLine("The Second String is: "+b8);
        Console.WriteLine($"Number of characters copied is: {ans} characters");
    }
    static void bai9()
    {
        Console.Write("Input your string: ");
        string a9 = Console.ReadLine();
        int vownum = 0;
        int consnum = 0;
        foreach (char ch in a9)
        {
            if ("ueoai".Contains(ch))
            { vownum++; }
            else
            { consnum++; }
        }
        Console.WriteLine("The total number of vowels in string is " + vownum);
        Console.WriteLine("The total number of consonants in string is "+consnum);
    }
    static void bai10()
    {
        Console.Write("Input your string: ");
        string a10 = Console.ReadLine();
        char mostused = a10[0];
        for (int i = 0;i<=a10.Length;i++)
        {

        }
                
    }
    static void bai11()
    {
        Console.Write("Input your string: ");
        string a11 = Console.ReadLine();
        char[] charArray = a11.ToCharArray();
        Array.Sort(charArray);
        string sortedarray = new string(charArray);
        Console.WriteLine("After sorting the string appears like: ");
        Console.WriteLine(sortedarray);

    }
}