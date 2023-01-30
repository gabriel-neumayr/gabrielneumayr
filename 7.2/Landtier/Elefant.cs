using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Landtier;
namespace Zoo.Landtier
{
    /// <summary>
    /// Diese Klasse bildet jenes Tier als Elefant
    /// </summary>
    internal class Elefant : Landtier
    {
       
        public Elefant(string name, int maxGeschwindigkeit, string type) : base(name, maxGeschwindigkeit,type)
        {
            this.maxGeschwindigkeit = maxGeschwindigkeit;
        }
        
        public override void Steckbrief(float gewicht, string birthdate)
        {
            base.Steckbrief(gewicht, birthdate);
            Console.WriteLine("Unterschied zum Landtier: Ohren Pflanzenfresser");
        }
        public void ElefantSpecialFunc()
        {
            Console.Write("");
        }
    }
}


