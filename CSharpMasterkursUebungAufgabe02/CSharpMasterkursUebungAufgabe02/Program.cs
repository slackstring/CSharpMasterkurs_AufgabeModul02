
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
            /* string[,] names = new string[,]
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
             */

            // Schleifen

            /*Console.WriteLine("Gerade Zahlen ausgeben:");
            Console.WriteLine("Geben Sie den ersten Wert ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie den zweiten Wert ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            geradeZahlenAusgabe(zahl1, zahl2);

            static void geradeZahlenAusgabe(int start, int ende)
            {
                double wert;
                while (start <= ende)
                {
                    wert = start % 2;

                    if (wert == 0)
                    {
                        Console.WriteLine(start);
                    }

                    start++;
                }
            }
            */

            /* Console.WriteLine("Endlos Rechner");

             while (true)
             {
                 Console.WriteLine("Ersten Wert eingeben:");
                 int x = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Zweiten Wert eingeben:");
                 int y = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Summe = {0}", x + y);
                 Console.ReadKey();
                 Console.Clear();
             } */

            /*Console.WriteLine("Multiplikator");
            Console.WriteLine("Gebe eine Zahl ein, welche mit den Zahlen von 1 bis 10 multipliziert werden soll");
            int Zahl = Convert.ToInt32(Console.ReadLine());
            multiplikator(Zahl);


            static void multiplikator(int nr)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", nr, i, nr * i);
                    
                }
            }*/

            /*Console.WriteLine("Rechteck generieren");
            Console.WriteLine("Spalten Anzahl eingeben:");
            int spalten = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zeilen Anzahl eingeben:");
            int zeilen = Convert.ToInt32(Console.ReadLine());
            drawRectangle(zeilen, spalten);

            static void drawRectangle(int zeilen, int spalten)
            {
                for (int i=0; i <zeilen; i++)
                {
                    for(int j=0; j < spalten; j++ )
                    {
                        Console.Write("#");
                    }
                    Console.Write("\n");
                    
                }
            }
            */
            /*  Console.WriteLine("Ausgabe kleines Einmal Eins");
              for (int i = 1; i <= 10; i++)
              {
                  for (int j = 1; j <= 10; j++)
                  {
                      Console.Write("|{0} * {1} = {2}   ",j,i,i*j);
                  }
                  Console.Write("\n");

              }*/

            /* Console.WriteLine("Gebe einen String ein:");
             string input = Console.ReadLine();


             for (int i = 0; i < input.Length; i++)
             {
                if (i==0)
                 {
                     Console.WriteLine(input);
                 }
                 else
                 {
                     Console.WriteLine(input[i]);
                 }
             } */


            /* Console.WriteLine("Gebe ein Wort ein, welches geprüft werden soll (Palindrom)");
             string text = Console.ReadLine();
             bool palindromCheck = true;


             for (int i = 0; i < text.Length; i++)
             {
                 if (text[i] != text[text.Length - (i + 1)])
                 {
                     palindromCheck = false;
                     break;
                 }
             }

             if(palindromCheck)
             {
                 Console.WriteLine("{0} ist ein Palindrom!", text);
             }
             else
             {
                 Console.WriteLine("{0} ist kein Palindrom!", text);
             }*/

            Console.WriteLine("Gebe einen Satz ein, welcher von Leerzeichen, Satzzeichen und Zahlen befreit werden soll");
            string text = Console.ReadLine();
           /* for (int i=0;i<text.Length; i++)
            {
                
                if (char.IsLetter(text[i]))
                {
                    Console.Write(text[i]);
                }
            }*/
           foreach (char n in text)
            {
                if (char.IsLetter(n))
                {
                    Console.Write(n);
                }
            }




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

