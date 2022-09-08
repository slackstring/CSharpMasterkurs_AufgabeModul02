
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
           
       
            writeText("Zahl 1:");
            double Zahl1 = Convert.ToDouble(Console.ReadLine());
            writeText("Zahl 2:");
            double Zahl2 = Convert.ToDouble(Console.ReadLine());
          
            Console.WriteLine("{0} + {1} = {2}", Zahl1, Zahl2, Zahl1 + Zahl2);
            Console.WriteLine("{0} - {1} = {2}", Zahl1, Zahl2, Zahl1 - Zahl2);
            Console.WriteLine("{0} * {1} = {2}", Zahl1, Zahl2, Zahl1*Zahl2);
            Console.WriteLine("{0} / {1} = {2}", Zahl1, Zahl2, Zahl1/Zahl2);
            Console.WriteLine("{0} % {1} = {2}", Zahl1, Zahl2, Zahl1%Zahl2);
             
            string vorname = GetTextStringInput("Vornamen");
            string nachname = GetTextStringInput("Nachnamen");
            Console.WriteLine("Hallo " + vorname + " " + nachname);
            
          
            Console.WriteLine("Radius eingeben:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Flaeche: {0}", Kreisfläche(radius));
            */

            //BMI Rechner (Uebung Schleifen / switch case)
            /*


                Console.WriteLine("Geben Sie Ihr Gewicht ein: (kg)");
                double mass = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Geben Sie Ihre Größe ein: (m)");
                double height = Convert.ToDouble(Console.ReadLine());
                double bmi = mass / (height * height);
                Console.WriteLine("Ihr BMI beträgt: {0}", bmi);
                string bmiClass;
  
              
            
            switch (bmi)
                {
                    case double nr when ((nr > 0) && (nr < 18.5)):
                        bmiClass = "Untergewicht";
                        break;
                    case double nr when ((nr >= 18.5) && (nr < 24.9)):
                        bmiClass = "Normalgewicht";
                        break;
                    case double nr when ((nr >= 24.9) && (nr <= 29.9)):
                        bmiClass = "Übergewicht";
                        break;
                    case double nr when ((nr >= 30) && (nr <= 34.9)):
                        bmiClass = "Adipositas Grad 1";
                        break;
                    case double nr when ((nr >= 35) && (nr <= 39.9)):
                        bmiClass = "Adipositas Grad 2";
                        break;
                    case > 40:
                        bmiClass = "Adipositas Grad 3";
                        break;
                    default:
                        bmiClass = "FEHLERHAFTE EINGABE";
                        break;
                }
            Console.WriteLine(bmiClass);
           */
            /*
            Console.WriteLine("Geben Sie ein Jahr an welches geprüft werden soll:");
            int year = Convert.ToInt32(Console.ReadLine());
            string schaltjahr;
            if (leapYear(year) == true)
            {
                schaltjahr = "Schaltjahr";
            }else
            {
                schaltjahr = "Kein Schaltjahr";
            }
            Console.WriteLine(schaltjahr);

            static bool leapYear(int n)
            {
                return ((n % 4 == 0 && n % 100 != 0) || n % 400 == 0);
            }
            */


            // Arrays

            //string[] ar = new string[4] {"test1","test2","test3","test4"};
            //ar[0] = "test1";
            //ar[1] = "test2";
            //ar[2] = "test3"; 
            //ar[3] = "test4";
            string[,] names = new string[,]
            {
                {
                    "sabine",
                    "sandra",
                    "Klaus",
                    "Max"
                },
                {
                    "müller",
                    "maier",
                    "schmied",
                    "mustermann"
                }
            };
            Console.WriteLine(names[0, 0]);
            Console.WriteLine(names[1, 0]);


            Console.ReadKey();
        }   
        static double Kreisfläche(double radius)
        {
            double pi = Math.PI;
            return radius * radius * pi;
        }
        static string GetTextStringInput(string message)
        {
            Console.WriteLine("Gib deinen " + message + " ein"!);
            
            return Console.ReadLine();
        }
        static void writeText(string text)
        {
            Console.WriteLine(text);
        }
    }
}

