using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Wassertiere
{

    internal abstract class Wassertier : Tier, ITauchzeit
    {

        protected int maxTauchzeit;
        protected Wassertier(string name, int maxTauchzeit, string type) : base(name, type)
        {
            this.name = name;
            this.maxTauchzeit = maxTauchzeit;
        }

        public virtual void MaxTauchzeit()
        {
            Console.WriteLine("Unterschied zur Basisklasse : Tauchzeit");
        }


        public override void Steckbrief(float gewicht, string birthdate)
        {
            base.Steckbrief(gewicht, birthdate);
            Console.WriteLine("Das Tier kann"+maxTauchzeit+" Minuten tauchen.");
            
        }

    }
}
