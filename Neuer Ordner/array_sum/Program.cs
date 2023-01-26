namespace array_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen aus Array");
            int erg = 0; //ergebnis mit 0 befüllt
            int[] myArr;//array initialisiert
            myArr = new int[] {1,2,3,4,5,6,7,8,9,10};//Dekrlariert 

            for (int i = 0; i < myArr.Length; i++) //array durchgehen 
            {
                Console.WriteLine(myArr[i]);//alle werte drucken
                erg = myArr[i] + erg; //erechnen vom eregebnis 
                if (myArr[i] < 10)//nur fürs Optische, programm soll zwischen den Zahlen ein + printen nur bei der letzten in dem fall 10 nicht
                {
                    Console.WriteLine("+");
                }
                else
                {                                             // Druck des Ergebnis und Rechenweges 
                    Console.WriteLine("=");
                    
                    Console.WriteLine(erg);

                }
            }

        }
    }
}