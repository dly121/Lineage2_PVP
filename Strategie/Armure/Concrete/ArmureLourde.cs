using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    class ArmureLourde : ArmureAbstraite
    {
        public ArmureLourde()
        {
            base.Nom = EnumArmure.ArmureLourde.ToString();
            base.PDef = 6000;
        }
    }
}
