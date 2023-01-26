using System;
namespace sortier_algo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sortieren eines Arrays aufgabe von Gabriel Neumayr");
            System.Random random = new System.Random();//anlegen des Random Objektes
;

            int[] arr = new int[8] ;//Befüllen des Arrays mit den Random nubers 
            for(int i = 0; i <  7; i++)
            {
                arr[i] = random.Next(4, 100);
            }
            Console.WriteLine("\nUnsortiert");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");    //Printen des Unsortierten Arrays 
            }
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)//Schleife das durch alles stellen des Arrays geht
                {
                    if (arr[sort] > arr[sort + 1])//if abfrage die checkt ob die nächste stelle im Array groeßer ist 
                    {
                        temp = arr[sort + 1]; //temp ist die nächste also höhere stelle im Array 
                        arr[sort + 1] = arr[sort];//dem hinteren wert im array die hoehere zahl zuweisen 
                        arr[sort] = temp;//an der niedrigeren stelle den kleineren wert 
                    }
                }
            }

            Console.WriteLine("\nSortiertes Array");

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            //Console.ReadKey();


        }
  }
}
