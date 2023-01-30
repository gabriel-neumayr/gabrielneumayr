using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Wassertiere
{
    /// <summary>
    /// Diese Klasse bildet jenes Tier als Wals
    /// </summary>
    /// </remarks>
    /// diese Klasse hat nur auf die Objekte "Wal" Einfluss
    /// </remarks>
    internal class Wal : Wassertier
    {
        bool lungen = true;
        public Wal(string name, int maxTauchzeit, string type):base (name, maxTauchzeit, type)
        {
            this.name = name;
            this.maxTauchzeit = maxTauchzeit;

        }

        public override void Steckbrief(float gewicht, string birthdate)
        {
            base.Steckbrief(gewicht, birthdate);

            if (lungen)
            {
               
                Console.WriteLine("Unterschied zur Klasse 'Wassertier': Als Wal besitze ich von Lungen");
            }
            
        }
        public void WalSpecialFunc()
        {
            Console.Write("");
        }


    }
}
