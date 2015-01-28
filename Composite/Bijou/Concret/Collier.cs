using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    class Collier : BijouAbstrait
    {
        public Collier()
        {
            base.Nom = EnumBijou.Collier.ToString();
            base.MDef = 2000;
        }
    }
}
