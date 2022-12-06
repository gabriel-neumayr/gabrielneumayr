namespace vererbung7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Viereck viereck1 = new Viereck("viereck1");
            Kreis kreis1 = new Kreis("kreis1");
            kreis1.radius = 2;

            CPunkt p1 = new CPunkt(1, 3);
            CPunkt p2 = new CPunkt(4, 3);
            CPunkt p3 = new CPunkt(5, 8);
            CPunkt p4 = new CPunkt(1, 8);




            CGrundForm.SetPunkt(p1, p2, p3, p4, viereck1.Name);
            

            CPunkt p1kreis = new CPunkt(1, 3);

         
        }
    }
}