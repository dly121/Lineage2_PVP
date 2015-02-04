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
            Nom = unNom;
            HP = 6000;
            MAtk = 1000;
            MDef = 1000;
            PAtk = 2000;
            PDef = 3000;
            MaxHP = (HP + MDef + PDef);

            base.CoupArcPuissance = 500;
            base.CoupDaguePuissance = 500;
            base.CoupDualPuissance = 3000;
            base.CoupEpeePuissance = 2500;

            TousLesPersonnages.Add(this);
        }

        public override void Attaque_CoupDague(PersonnageAbstrait unPersonnage)
        {
            if (HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                else if (Arme.Nom.Equals(EnumArme.Dague.ToString()))
                {
                    unPersonnage.HP -= CoupDaguePuissance;
                    if (unPersonnage.HP < 0)
                        unPersonnage.HP = 0;
                }
                else Console.WriteLine("Pas de dague équipée: Coup de dague impossible");
            }
            else Console.WriteLine("{0} est mort, coup de dague impossible", Nom);
        }

        public override void Attaque_CoupEpee(PersonnageAbstrait unPersonnage)
        {
            if (HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                else if (Arme.Nom.Equals(EnumArme.Epee.ToString()))
                {
                    unPersonnage.HP -= CoupEpeePuissance;
                    if (unPersonnage.HP < 0)
                        unPersonnage.HP = 0;
                }
                else Console.WriteLine("Pas d'épée équipée: Coup d'épée impossible");
            }
            else Console.WriteLine("{0} est mort, coup d'épée impossible", Nom);
        }

        public override void Attaque_CoupDual(PersonnageAbstrait unPersonnage)
        {
            if (HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                else if (Arme.Nom.Equals(EnumArme.DualHache.ToString()))
                {
                    unPersonnage.HP -= CoupDualPuissance;
                    if (unPersonnage.HP < 0)
                        unPersonnage.HP = 0;
                }
                else Console.WriteLine("Pas de dual équipée: Coup de dual impossible");
            }
            else Console.WriteLine("{0} est mort, coup de dual impossible", Nom);
        }

        public override void Attaque_TirerFleche(PersonnageAbstrait unPersonnage)
        {
            if (HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                else if (Arme.Nom.Equals(EnumArme.Arc.ToString()))
                {
                    unPersonnage.HP -= CoupArcPuissance;
                    if (unPersonnage.HP < 0)
                        unPersonnage.HP = 0;
                }
                else Console.WriteLine("Pas d'arc: Tire de flèche impossible");
            }
            else Console.WriteLine("Pas d'arc: Tire de flèche impossible");
        }

        public override void AjusterPuissanceDague()
        {
            if (Arme.Nom.Equals(EnumArme.Dague.ToString()))
                base.CoupDaguePuissance += PAtk + Arme.PAtk;
            else base.CoupDaguePuissance += PAtk;
        }

        public override void AjusterPuissanceArc()
        {
            if (Arme.Nom.Equals(EnumArme.Arc.ToString()))
                base.CoupArcPuissance += PAtk + Arme.PAtk;
            else base.CoupArcPuissance += PAtk;
        }

        public override void AjusterPuissanceDual()
        {
            if (Arme.Nom.Equals(EnumArme.DualHache.ToString()))
                base.CoupDualPuissance += PAtk + Arme.PAtk;
            else base.CoupDualPuissance += PAtk;
        }

        public override void AjusterPuissanceEpee()
        {
            if (Arme.Nom.Equals(EnumArme.Epee.ToString()))
                base.CoupEpeePuissance += PAtk + Arme.PAtk;
            else base.CoupEpeePuissance += PAtk;
        }

        public override void Soigner(PersonnageAbstrait unPersonnage)
        {
            Console.WriteLine("{0} ne dispose pas des compétences de soigneur", Nom);
        }

        public override void AttaqueMagique(PersonnageAbstrait unPersonnage)
        {
            Console.WriteLine("{0} ne dispose pas des compétences d'attaques magiques", Nom);
        }

        public override void BuffHP(PersonnageAbstrait unPersonnage)
        {
            Console.WriteLine("{0} ne dispose pas des compétences de buffer", Nom);
        }

        public override void DebuffHP(PersonnageAbstrait unPersonnage)
        {
            Console.WriteLine("{0} ne dispose pas des compétences de debuffer", Nom);
        }

        public override void AjusterSoinQuantite()
        {
            Console.WriteLine("{0} ne dispose pas des compétences de soigneur et ne peut ajuster la quantité de soin", Nom);
        }

        public override void AjusterAttaqueMagiquePuissance()
        {
            Console.WriteLine("{0} ne dispose pas des compétences d'attaques magiques et ne peut ajuster la puissance de ces attaques", Nom);
        }

        public override void InvoquerSummon(string unNomDeBete)
        {
            Console.WriteLine("{0} ne dispose pas des compétences de summoner pour invoquer une bête", Nom);
        }
    }
}
