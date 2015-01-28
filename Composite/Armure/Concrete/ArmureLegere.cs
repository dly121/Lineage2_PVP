using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    class ArmureLegere : ArmureAbstraite
    {
        public ArmureLegere()
        {
            base.Nom = EnumArmure.ArmureLegere.ToString();
            base.PDef = 4500;
        }
    }
}
