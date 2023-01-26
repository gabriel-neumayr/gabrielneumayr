using System;
using System.IO;
using System.Collections;
namespace _10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie den Dateinamen ein:");
            string fileName = Console.ReadLine();
            
            string path = fileName;
           
            Console.WriteLine("Geben sie einen 2. datei namen ein:");
            string fileName2 = Console.ReadLine();

            int input;
           

            FileStream lesen;
            lesen = new FileStream(path, FileMode.OpenOrCreate);
            FileStream copy;
            copy = new FileStream(fileName2, FileMode.OpenOrCreate);
            do
            {
                input= lesen.ReadByte();
                if(input != -1) copy.WriteByte((byte) input);
            }
            while (input != -1);
         
             

             
            //copy.Write(zeile);
            copy.Close();
            lesen.Close();
        }
    }
}