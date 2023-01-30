using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Landtier
{
    /// <summary>
    /// Diese Klasse ist die Basisklasse jedes Landtieres
    /// </summary>
    internal class Landtier : Tier, IGeschwindigkeit
    {

        protected int maxGeschwindigkeit;
        protected Landtier(string name, int maxGeschwindigkeit, string type) : base(name,type)
        {
            this.name= name;
            this.maxGeschwindigkeit = maxGeschwindigkeit;

        }


        public virtual void MaxGeschwindigkeit()
        {
            Console.WriteLine("Unterschied zur Basisklasse : Geschwindigkeit");
        }

        public override void Steckbrief(float gewicht, string birthdate)
        {
            base.Steckbrief(gewicht, birthdate);
            Console.WriteLine("Tier kann" + maxGeschwindigkeit + " kmh schnell sein.");
        }
    }
}
 