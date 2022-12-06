// Erstellt am 26.11.2022
// Gabriel Neumayr 2Ib 
// Aus Subnetzmaske und IP wird die netzwerkadresse erechenet
namespace Ipadressen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aus Subnetzmaske IP errechnen ");

            short[] ipadresse1 = new short[] {10,0,12,23};
            short[] subnetmask1 = new short[] { 255, 255, 255, 240 };

            short[] netzwerkadresse1 = new short[4] ;

            netzwerkadresse1[0] = (short)(ipadresse1[0] & subnetmask1[0]);
            netzwerkadresse1[1] = (short)(ipadresse1[1] & subnetmask1[1]);
            netzwerkadresse1[2] = (short)(ipadresse1[2] & subnetmask1[2]);
            netzwerkadresse1[3] = (short)(ipadresse1[3] & subnetmask1[3]);

            short[] ipadresse2 = new short[] { 127, 0, 0, 4 };
            short[] subnetmask2 = new short[] { 255, 255, 255, 252 };

            short[] netzwerkadresse2 = new short[4];

            netzwerkadresse2[0] = (short)(ipadresse2[0] & subnetmask2[0]);
            netzwerkadresse2[1] = (short)(ipadresse2[1] & subnetmask2[1]);
            netzwerkadresse2[2] = (short)(ipadresse2[2] & subnetmask2[2]);
            netzwerkadresse2[3] = (short)(ipadresse2[3] & subnetmask2[3]);
            //loop für die anderen stellen des arrys 

            Console.WriteLine(string.Join(".", netzwerkadresse1));
            Console.WriteLine(string.Join(".", netzwerkadresse2));





        }
    }
}