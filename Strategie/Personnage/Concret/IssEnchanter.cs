using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    internal class IssEnchanter : PersonnageMysticAbstrait
    {
        public IssEnchanter(String unNom)
            : base(unNom)
        {
            Nom = unNom;
            HP = 3000;
            MAtk = 2000;
            MDef = 2000;
            PAtk = 1000;
            PDef = 1000;
            MaxHP = (HP + MDef + PDef);

            base.SoinQuantite = 1500;
            base.AttaqueMagiquePuissance = 1000;
            base.BuffHPQuantite = 1.30;
            base.DebuffHPQuantite = 0.70;

            TousLesPersonnages.Add(this);
        }

        public override void Soigner(PersonnageAbstrait unPersonnage)
        {
            if (HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                else if (unPersonnage.HP >= 0 && unPersonnage.HP <= unPersonnage.MaxHP - SoinQuantite)
                    unPersonnage.HP += SoinQuantite;
                else unPersonnage.HP = unPersonnage.MaxHP;
            }
            else Console.WriteLine("{0} est mort: Soin impossible", Nom);
        }

        public override void AttaqueMagique(PersonnageAbstrait unPersonnage)
        {
            if (HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Attaque magique impossible!", unPersonnage.Nom);
                else if (unPersonnage.HP >= AttaqueMagiquePuissance)
                    unPersonnage.HP -= AttaqueMagiquePuissance;
                else unPersonnage.HP = 0;
            }
            else Console.WriteLine("{0} est mort: Attaque magique impossible!", Nom);
        }

        public override void BuffHP(PersonnageAbstrait unPersonnage)
        {
            if (HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Buff HP impossible!", unPersonnage.Nom);
                else unPersonnage.MaxHP *= BuffHPQuantite;
            }
            else Console.WriteLine("{0} est mort: Buff HP impossible!", Nom);
        }

        public override void DebuffHP(PersonnageAbstrait unPersonnage)
        {
            if (HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Debuff HP impossible!", unPersonnage.Nom);
                else unPersonnage.MaxHP *= DebuffHPQuantite;
            }
            else Console.WriteLine("{0} est mort: Debuff HP impossible!", Nom);
        }


        public override void AjusterSoinQuantite()
        {
            base.SoinQuantite += MAtk + Arme.MAtk;
        }

        public override void AjusterAttaqueMagiquePuissance()
        {
            base.AttaqueMagiquePuissance += MAtk;
        }

        public override void Attaque_CoupDague(PersonnageAbstrait unPersonnage)
        {
            Console.WriteLine("{0} ne dispose pas les compétences du coup de dague", Nom);
        }

        public override void Attaque_CoupEpee(PersonnageAbstrait unPersonnage)
        {
            Console.WriteLine("{0} ne dispose pas les compétences du coup d'épée", Nom);
        }

        public override void Attaque_CoupDual(PersonnageAbstrait unPersonnage)
        {
            Console.WriteLine("{0} ne dispose pas les compétences du coup de dual", Nom);
        }

        public override void Attaque_TirerFleche(PersonnageAbstrait unPersonnage)
        {
            Console.WriteLine("{0} ne dispose pas les compétences avec un arc", Nom);
        }

        public override void AjusterPuissanceDague()
        {
            Console.WriteLine("{0} ne dispose pas les compétences pour ajuster la puissance d'une dague", Nom);
        }

        public override void AjusterPuissanceArc()
        {
            Console.WriteLine("{0} ne dispose pas les compétences pour ajuster la puissance d'un arc", Nom);
        }

        public override void AjusterPuissanceDual()
        {
            Console.WriteLine("{0} ne dispose pas les compétences pour ajuster la puissance de dual", Nom);
        }

        public override void AjusterPuissanceEpee()
        {
            Console.WriteLine("{0} ne dispose pas les compétences pour ajuster la puissance d'une épée", Nom);
        }

        public override void InvoquerSummon(string unNomDeBete)
        {
            Console.WriteLine("{0} ne dispose pas des compétences de summoner pour invoquer une bête", Nom);
        }
    }
}
