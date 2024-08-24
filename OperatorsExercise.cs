using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sess3
{
    internal class OperatorsExercise
    {
        static void Main1(string[] args)
        {
            //bai2();
            //bai3();
            bai5();
        }
        static void bai1()
        {
            Console.Write("Input a: ");
            int numa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{numa} + {numb} = {numa + numb}");
            Console.WriteLine($"{numa} - {numb} = {numa - numb}");
            Console.WriteLine($"{numa} * {numb} = {numa * numb}");
            Console.WriteLine($"{numa} / {numb} = {numa / numb}");
            Console.WriteLine($"{numa} mod {numb} = {numa % numb}");
        }
        static void bai2()
        {
            int x;
            for (int y =-5;y  <=5; y++)
            {
                Console.WriteLine($"x = {y *y +2*y+1} ");
            }
        }
        static void bai3()
        {

            Console.Write("Input distance: ");
            float dis = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input time: ");
            int timeans = Convert.ToInt32(Console.ReadLine());
            int changedtime;
            Timechange();
            Velo();

            //Change time to hours if answer not in hours yet
            void Timechange()
            {
                Console.Write("Is it in hours, mminutes or seconds ? ");
                string timetype = Console.ReadLine();
                if ( timetype == "hours")
                {
                    changedtime = timeans;
                }
                else if ( timetype == "minutes")
                {
                    changedtime = timeans/60;
                }
                else
                {
                    changedtime = timeans/3600;
                }
            }
            // Velocity output
            void Velo()
            {
                Console.WriteLine($"The velocity in kph is {dis/changedtime} km/h");
                Console.WriteLine($"The velocity in mph is {(dis/changedtime)* 0.621371192} m/h");
            }


        }
        static void bai4()
        {
            Console.Write("Input Radius: ");
            double R = Convert.ToDouble(Console.ReadLine());
            float pi = 3.14f;
            double area = Math.Pow(R, 2) * pi * 4;
            double vol = Math.Pow(R, 3) * pi * 4/3;
            Console.WriteLine(area);
            Console.WriteLine(vol);
        }
        static void bai5()
        {
            Console.WriteLine("Input Char: ");
            
            char CharInt = Console.ReadKey().KeyChar;

            if ("aeiou".Contains(CharInt))
            {
                Console.WriteLine("It's a vowel");
            }
            else if (Char.IsDigit(CharInt))
            {
                Console.WriteLine("It's a digit");
            }
            else
            {
                Console.WriteLine("It's a symbol");
            }
           
        }

    }
}
