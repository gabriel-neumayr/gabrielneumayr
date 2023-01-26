using System;
using System.IO;
namespace _10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] aktuell = new string[10];
            string dir = "C:/Users/gabriel.neumayr/Documents/INF";


            aktuell = Directory.GetDirectories(dir);
            
            for(int i = 0; i < aktuell.Length; i++)
            {
                Console.WriteLine(aktuell[i]);
            }
            

        }
    }
}