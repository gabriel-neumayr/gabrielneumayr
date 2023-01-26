using System;
using System.IO;
namespace _10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie den Dateinamen ein:");
            string fileName = Console.ReadLine();
            FileStream strom;
            string path = fileName;
            strom = new FileStream (fileName, FileMode.OpenOrCreate);


            string zeile;
            StreamReader lesen;

            
            lesen = new StreamReader(strom);
            
            while(lesen.Peek() != -1)
            {
                
                zeile = lesen.ReadLine();
                Console.WriteLine("Inhalt: ");
                Console.WriteLine(zeile);
            }



            strom.Close();
        }
    }
}