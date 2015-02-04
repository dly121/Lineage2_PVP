using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    class Arc : ArmeAbstraite
    {
        public Arc()
        {
            base.Nom = EnumArme.Arc.ToString();
            base.PAtk = 3000;
            base.MAtk = 500;
        }
    }
}
