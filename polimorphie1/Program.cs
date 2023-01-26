namespace polimorphie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PKW audi = new PKW("audi", 4, 70);
           

            LKW volvolkw = new LKW("Volvolkw", 3);

            Motorrad susuki = new Motorrad("Susuki", 2, 38);
            

            vehicle[] vehicles = new vehicle[3];
            vehicles[0] = audi;
            vehicles[1] = volvolkw;
            vehicles[2] = susuki;

            foreach(vehicle x in vehicles)
            {
                x.PrintName();
                x.Drive();
                
            }
            audi.Kofferaumbeladen();
            susuki.wely();
        }
    }
}