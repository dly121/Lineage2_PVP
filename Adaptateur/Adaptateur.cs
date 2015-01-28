using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    internal class Adaptateur : Cible
    {
        private readonly Adapte unAdapte = new Adapte();

        public void Operation()
        {
            unAdapte.OperationSpécifique();
        }
    }
}
