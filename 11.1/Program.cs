using System;
namespace _11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zahl1 = 0;
                int zahl2 = 0;
                Console.WriteLine("Zahl1");
                zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zahl2");
                zahl2 = Convert.ToInt32(Console.ReadLine());

                int erg = 0;
                erg = (zahl1 + zahl2);
                Console.WriteLine(erg);

                erg = (zahl1 - zahl2);
                Console.Write(erg);

                erg = (zahl1 * zahl2);
                Console.WriteLine(erg);

                erg = (zahl1 / zahl2);
                Console.WriteLine(erg);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}