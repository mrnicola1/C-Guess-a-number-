using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            int tal1;
            int filetal;
            int j = 0;
            int gæt=0;
            string password2="";
            
            Random rnd2=new Random();
            filetal = rnd2.Next(1, 999999999);
            
            string password = "Datait2022!"; 
            bool value = false;
            Console.WriteLine(value? "true" : "false");

           

            Console.Write("Skriv dit navn --> ");
            string navn = Console.ReadLine();

            
            while (password != password2)                
            {
                Console.WriteLine("*****************");
                Console.Write("Indtast password --> ");
                password2 = Console.ReadLine();
                if (password2 != password)                
                {
                    j++;
                    if (j > 4)
                    {
                        Console.WriteLine("Du har ikke flere password forsøg");  
                        Console.ReadLine();
                        return;                     
                    }
                }
            }
            Random rnd = new Random();                 
            tal1 = rnd.Next(1, 50);
            Console.WriteLine("Velkommen til gæt et tal");
            Console.WriteLine("*****************");
            Console.WriteLine("tallet der skal gættes er mellem 1 og 50");
            while (true)
            {
                
                Console.WriteLine("*****************");
                Console.Write("Indtast gæt --> ");

                _ = int.TryParse(Console.ReadLine(), out gæt);
                

                if (tal1 < gæt)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("dit gæt var for højt");
                    Console.WriteLine("prøv igen");
                    String writetext2 = ""+gæt+"\t";
                    File.AppendAllText("GætHøj.txt", writetext2);                    
                }
                if (tal1 > gæt)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("dit gæt var for lavt");
                    Console.WriteLine("prøv igen");
                    String writetext = ""+gæt+"\t";
                    File.AppendAllText("GætLav.txt", writetext);                    
                }

                if (tal1 != gæt)
                {
                    
                } 
                else
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("Tillykke");
                    Console.WriteLine("Du gættede tallet");
                    Console.WriteLine("********************************"); 
                    Console.WriteLine("********************************");
                    Console.WriteLine("Status:");
                    Console.WriteLine("Tal som skulle gættes --> " + tal1);
                    Console.WriteLine("Gæt som var for lave :"); String readtext = File.ReadAllText("GætLav.txt"); Console.WriteLine(readtext);                    
                    Console.WriteLine("Gæt som var for høje :"); String readtext2 = File.ReadAllText("GætHøj.txt"); Console.WriteLine(readtext2);                    
                    Console.WriteLine("********************************");
                    Console.WriteLine("********************************");
                    File.Copy("GætHøj.txt",navn+filetal+"GætHøj2.txt");
                    File.Copy("GætLav.txt", navn+filetal+"GætLav2.txt");
                    File.Delete("Gætlav.txt");
                    File.Delete("GætHøj.txt");
                    Console.ReadLine();
                    
                return;
                }
            }
                   
        }
    }
}








































