﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte age;
            decimal asset;
            bool marriageStatus;
            string name;
            char firstChar;
            float MuesliPrice;

            writeText("Geben Sie Ihren Vornamen ein:");
            string preName = Console.ReadLine();
            writeText("Geben Sie Ihren Nachnahmen ein:");
            name = Console.ReadLine();
            writeText("Geben Sie Ihr Alter ein:");
            age = Convert.ToByte(Console.ReadLine());
            writeText("Sie heißen " + preName + " " + name + " und sind " + age + " Jahre alt.");
            */
       
            writeText("Zahl 1:");
            double Zahl1 = Convert.ToDouble(Console.ReadLine());
            writeText("Zahl 2:");
            double Zahl2 = Convert.ToDouble(Console.ReadLine());
          
            Console.WriteLine("{0} + {1} = {2}", Zahl1, Zahl2, Zahl1 + Zahl2);
            Console.WriteLine("{0} - {1} = {2}", Zahl1, Zahl2, Zahl1 - Zahl2);
            Console.WriteLine("{0} * {1} = {2}", Zahl1, Zahl2, Zahl1*Zahl2);
            Console.WriteLine("{0} / {1} = {2}", Zahl1, Zahl2, Zahl1/Zahl2);
            Console.WriteLine("{0} % {1} = {2}", Zahl1, Zahl2, Zahl1%Zahl2);

            Console.ReadKey();



        }   

        static void writeText(string text)
        {
            Console.WriteLine(text);
        }
    }
}

