namespace Bank
{
    internal class Program
    {
        card card1 = new card("Gabriel Neumayr", "Hofgartenweg 5 5163 Mattsee", 18, "AT1234", 1234, 5000);

         static Menu()
        {

            Console.WriteLine("Kontostand anzeigen lassen -------1");


            string i = Console.ReadLine();

            switch (i)
            {
                case "1":
                    Console.WriteLine("Kontostand wird Angezeigt");
                    card1.Kontostand_ablesen(card1.kontostand);
                    break;
            }
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Willkommen was wollen sie machen? ");
            Menu();
        }

       



    }


}