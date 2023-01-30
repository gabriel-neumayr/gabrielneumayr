using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Wassertiere
{
    /// <summary>
    /// Diese Klasse bildet jenes Tier als Delfins
    /// </summary>
    /// /// </remarks>
    /// diese Klasse hat nur auf die Objekte "Delfin" Einfluss
    /// </remarks>
    internal class Delfin: Wassertier
    {
        public Delfin(string name, int maxTauchzeit, string type) : base(name, maxTauchzeit, type)
        {
            this.name = name;
            this.maxTauchzeit = maxTauchzeit;

        }
        public override void Steckbrief(float gewicht, string birthdate)
        {
            base.Steckbrief(gewicht, birthdate);
            Console.WriteLine("Unterschied zur Klasse Wassertier : Schnell und Inteligent");

        }
        public void DelfinSpecialFunc()
        {
            Console.Write("");
        }
    }
}
