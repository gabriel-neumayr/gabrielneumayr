using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Landtier
{

    internal class Nashorn : Landtier
    {
        public Nashorn(string name, int maxGeschwindigkeit, string type) : base(name, maxGeschwindigkeit, type)
        {
            this.maxGeschwindigkeit = maxGeschwindigkeit;
        }


        public override void Steckbrief(float gewicht, string birthdate)
        {
            base.Steckbrief(gewicht, birthdate);
            Console.WriteLine("Unterschied zum Landtier: Hohe bisskraft, Großes Maul");
        }
        public void NashornSpecialFunc()
        {
            
                Console.Write("");
            
        }
    }
}
