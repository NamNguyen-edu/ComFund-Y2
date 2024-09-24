using System.ComponentModel.DataAnnotations;

internal class AdvancedString
{
    #region Strings

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
        Console.WriteLine($"Length of your string is:{Length(b)}");
        
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
    static void bai5()
    {
        Console.Write("Input your string: ");
        string e = Console.ReadLine();
        int ans = 1;
        for (int i = 0; i < e.Length; i++)
        {
            if (e[i] == ' ')
            {
                ans += 1;
            }
            if (e[i+1]==' ')
            {
               ans -= 1;
            }
        }
        Console.WriteLine("Total number of words in the string is: " + ans);
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
        Console.WriteLine("The Second String is: " + b8);
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
        Console.WriteLine("The total number of consonants in string is " + consnum);
    }
    static void bai10()
    {
        Console.Write("Input your string: ");
        string a10 = Console.ReadLine();
        char mostused = ' ';
        int maxcount = 0;
        for (int i = 0; i <= a10.Length; i++)
        {
            for (int j = 0; j <= a10.Length; j++)
            {
                int count = 0;
                if (a10[i] == a10[j])
                {
                    count++;
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    mostused = a10[i];
                }
            }
        }
        Console.WriteLine($"The most used character is {mostused} with {maxcount} times used");
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
    static void bai12()
    {
        Console.Write("Input number of string: ");
        int numofrow = int.Parse(Console.ReadLine());
        string[] unsortedstring = new string[numofrow];
        uint count = 0;
        Console.WriteLine($"Input {numofrow} strings below: ");
        for (int i = 0; i < numofrow; i++)
        { unsortedstring[i] = Console.ReadLine(); } 
                      
    }

    static void bai14()
    {
        Console.Write("Input string: ");
        string a14 = Console.ReadLine();
        Console.Write("Input substring to search: ");
        string sub14 = Console.ReadLine();
        if (a14.Contains(sub14))
        {
            Console.WriteLine("This substring exist in the string");
        }    
    }
    #region Ternary
    //Ternary Statements
    //Compare between 2 inputt
    static void Ternary()
    {
        Console.Write("A; ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B:; ");
        int b = int.Parse(Console.ReadLine());
        int max = a;
        Console.WriteLine(a);
    }
    #endregion
    #endregion
    static void Main ()
    {
        Console.Write("Input your string: ");
        string b = Console.ReadLine();
        Console.WriteLine($"Length of your string is:{Length(b)}");
        Console.WriteLine($"There is {countwords(b)} words in your string");
    }
    static int Length(string s)
    {
        int len = 0;

        foreach (char b2 in s) { len++; }
        return len;
    }
    static int countwords(string s)
    {
        s  = s.Trim();
        int ans = 1;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                ans += 1;
            }
            if (s[i]==' ' && s[i+1]==' ')
            {
                ans -= 1;
            }
        }
        return ans;
    }
    static void Compare_length(string s1, string s2)
    {
        int lens1 = Length(s1);
        int lens2 = Length(s2);
        if (lens1 > lens2)
        {
            Console.WriteLine($"String [{s1}] is longer than [{s2}]");
        }
        else
        {
            Console.WriteLine($"String [{s1}] is shorter than [{s2}]");
        }
    }
    static void Search (string s,string c,int freq)
    {
        char [] schar = s.ToCharArray();

    }
}

