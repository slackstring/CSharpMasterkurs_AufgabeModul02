
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
            Console.ReadKey();


        }   

        static void writeText(string text)
        {
            Console.WriteLine(text);
        }
    }
}

