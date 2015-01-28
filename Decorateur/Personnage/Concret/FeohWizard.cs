using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    internal class FeohWizard : PersonnageMysticAbstrait
    {
        public FeohWizard(String unNom)
            : base(unNom)
        {
            base.personnage.Nom = unNom;
            base.personnage.HP = 4000;
            base.personnage.MAtk = 3000;
            base.personnage.MDef = 3000;
            base.personnage.PAtk = 1000;
            base.personnage.PDef = 1000;
            base.personnage.MaxHP = (base.personnage.HP + base.personnage.MDef + base.personnage.PDef);

            base.SoinQuantite = 500;
            base.AttaqueMagiquePuissance = 2000;
            base.BuffHPQuantite = 0;
            base.DebuffHPQuantite = 0;
        }

        public override void Soigner(PersonnageAbstrait unPersonnage)
        {
            if (base.personnage.HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Soin impossible!", unPersonnage.Nom);
                else if (unPersonnage.HP >= 0 && unPersonnage.HP <= unPersonnage.MaxHP - SoinQuantite)
                    unPersonnage.HP += SoinQuantite;
                else unPersonnage.HP = unPersonnage.MaxHP;
            }
            else Console.WriteLine("{0} est mort: Soin impossible", base.personnage.Nom);
        }

        public override void AttaqueMagique(PersonnageAbstrait unPersonnage)
        {
            if (base.personnage.HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Attaque magique impossible!", unPersonnage.Nom);
                else if (unPersonnage.HP >= AttaqueMagiquePuissance)
                    unPersonnage.HP -= AttaqueMagiquePuissance;
                else unPersonnage.HP = 0;
            }
            else Console.WriteLine("{0} est mort: Attaque magique impossible!", base.personnage.Nom);
        }

        public override void BuffHP(PersonnageAbstrait unPersonnage)
        {
            if (base.personnage.HP > 0)
            {
                Console.WriteLine("{0} n'est pas buffer: Buff HP impossible!", base.personnage.Nom);
            }
            else Console.WriteLine("{0} est mort et n'est pas buffer: Buff HP impossible!", base.personnage.Nom);
        }

        public override void DebuffHP(PersonnageAbstrait unPersonnage)
        {
            if (base.personnage.HP > 0)
            {
                Console.WriteLine("{0} n'est pas buffer: Debuff HP impossible!", base.personnage.Nom);
            }
            else Console.WriteLine("{0} est mort et n'est pas buffer: Debuf HP impossible!", base.personnage.Nom);
        }


        public override void AjusterSoinQuantite()
        {
            base.SoinQuantite += base.personnage.MAtk;
        }

        public override void AjusterAttaqueMagiquePuissance()
        {
            base.AttaqueMagiquePuissance += base.personnage.MAtk + base.personnage.Arme.MAtk;
        }
    }
}
