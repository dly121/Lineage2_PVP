using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    class Dague : ArmeAbstraite
    {
        public Dague()
        {
            base.Nom = EnumArme.Dague.ToString();
            base.PAtk = 1500;
            base.MAtk = 500;
        }
    }
}
