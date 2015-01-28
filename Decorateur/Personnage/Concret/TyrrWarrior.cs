using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    internal class TyrrWarrior : PersonnageFighterAbstrait
    {
        public TyrrWarrior(String unNom)
            : base(unNom)
        {
            base.personnage.Nom = unNom;
            base.personnage.HP = 6000;
            base.personnage.MAtk = 1000;
            base.personnage.MDef = 1000;
            base.personnage.PAtk = 2000;
            base.personnage.PDef = 3000;
            base.personnage.MaxHP = (base.personnage.HP + base.personnage.MDef + base.personnage.PDef);

            base.CoupArcPuissance = 500;
            base.CoupDaguePuissance = 500;
            base.CoupDualPuissance = 3000;
            base.CoupEpeePuissance = 2500;
        }

        public override void Attaque_CoupDague(PersonnageAbstrait unPersonnage)
        {
            if (base.personnage.HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                else if (base.personnage.Arme.Nom.Equals(EnumArme.Dague.ToString()))
                    unPersonnage.HP -= 3000;
                else Console.WriteLine("Pas de dague équipée: Coup de dague impossible");
            }
            else Console.WriteLine("{0} est mort, coup de dague impossible", base.personnage.Nom);
        }

        public override void Attaque_CoupEpee(PersonnageAbstrait unPersonnage)
        {
            if (base.personnage.HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                if (base.personnage.Arme.Nom.Equals(EnumArme.Dague.ToString()))
                    unPersonnage.HP -= 3000;
                else Console.WriteLine("Pas d'épée équipée: Coup d'épée impossible");
            }
            else Console.WriteLine("{0} est mort, coup d'épée impossible", base.personnage.Nom);
        }

        public override void Attaque_CoupDual(PersonnageAbstrait unPersonnage)
        {
            if (base.personnage.HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                if (base.personnage.Arme.Nom.Equals(EnumArme.DualHache.ToString()))
                    unPersonnage.HP -= 3000;
                else Console.WriteLine("Pas de dual équipée: Coup de dual impossible");
            }
            else Console.WriteLine("{0} est mort, coup de dual impossible", base.personnage.Nom);
        }

        public override void Attaque_TirerFleche(PersonnageAbstrait unPersonnage)
        {
            if (base.personnage.HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                if (base.personnage.Arme.Nom.Equals(EnumArme.Arc.ToString()))
                    unPersonnage.HP -= 3000;
                else Console.WriteLine("Pas de d'arc: Tire de flèche impossible");
            }
            else Console.WriteLine("Pas de d'arc: Tire de flèche impossible");
        }

        public override void AjusterPuissanceDague()
        {
            if (base.personnage.Arme.Nom.Equals(EnumArme.Dague.ToString()))
                base.CoupDaguePuissance += base.personnage.PAtk + base.personnage.Arme.PAtk;
            else base.CoupDaguePuissance += base.personnage.PAtk;
        }

        public override void AjusterPuissanceArc()
        {
            if (base.personnage.Arme.Nom.Equals(EnumArme.Arc.ToString()))
                base.CoupArcPuissance += base.personnage.PAtk + base.personnage.Arme.PAtk;
            else base.CoupArcPuissance += base.personnage.PAtk;
        }

        public override void AjusterPuissanceDual()
        {
            if (base.personnage.Arme.Nom.Equals(EnumArme.DualHache.ToString()))
                base.CoupDualPuissance += base.personnage.PAtk + base.personnage.Arme.PAtk;
            else base.CoupDualPuissance += base.personnage.PAtk;
        }

        public override void AjusterPuissanceEpee()
        {
            if (base.personnage.Arme.Nom.Equals(EnumArme.Epee.ToString()))
                base.CoupEpeePuissance += base.personnage.PAtk + base.personnage.Arme.PAtk;
            else base.CoupEpeePuissance += base.personnage.PAtk;
        }
    }
}
