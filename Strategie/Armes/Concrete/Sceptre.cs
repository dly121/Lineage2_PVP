using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    class Sceptre : ArmeAbstraite
    {
        public Sceptre()
        {
            base.Nom = EnumArme.Sceptre.ToString();
            base.PAtk = 500;
            base.MAtk = 3000;
        }
    }
}
