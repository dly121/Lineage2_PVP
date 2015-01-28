using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    internal class AeoreHealer : PersonnageMysticAbstrait
    {
        public AeoreHealer(String unNom)
            : base(unNom)
        {
            base.personnage.Nom = unNom;
            base.personnage.HP = 4000;
            base.personnage.MAtk = 2000;
            base.personnage.MDef = 2000;
            base.personnage.PAtk = 1000;
            base.personnage.PDef = 1000;
            base.personnage.MaxHP = (base.personnage.HP + base.personnage.MDef + base.personnage.PDef);

            base.SoinQuantite = 3000;
            base.AttaqueMagiquePuissance = 500;
            base.BuffHPQuantite = 1.15;
            base.DebuffHPQuantite = 0.85;
        }


        //public override void EquiperArmure(EnumArmure uneArmure)
        //{
        //    if (base.personnage != null)
        //    {
        //        switch (uneArmure)
        //        {
        //            case EnumArmure.ArmureLegere:
        //                base.personnage.Armure = new ArmureLegere();
        //                base.personnage.AugmenterStatsArmure();
        //                break;
        //            case EnumArmure.ArmureLourde:
        //                base.personnage.Armure = new ArmureLourde();
        //                base.personnage.AugmenterStatsArmure();
        //                break;
        //            case EnumArmure.Robe:
        //                base.personnage.Armure = new Robe();
        //                base.personnage.AugmenterStatsArmure();
        //                break;
        //            default:
        //                base.personnage.Armure = new ArmureLegere();
        //                base.personnage.AugmenterStatsArmure();
        //                break;
        //        }
        //    }
        //}

        //public override void EquiperBijou(EnumBijou unBijou)
        //{
        //    if (base.personnage != null)
        //    {
        //        switch (unBijou)
        //        {
        //            case EnumBijou.Collier:
        //                base.personnage.Bijou = new Collier();
        //                base.personnage.AugmenterStatsBijou();
        //                break;
        //            case EnumBijou.BoucleOreille:
        //                base.personnage.Bijou = new BoucleOreille();
        //                base.personnage.AugmenterStatsBijou();
        //                break;
        //            case EnumBijou.Bague:
        //                base.personnage.Bijou = new Bague();
        //                base.personnage.AugmenterStatsBijou();
        //                break;
        //            default:
        //                base.personnage.Bijou = new Bague();
        //                base.personnage.AugmenterStatsBijou();
        //                break;
        //        }
        //    }
        //}

        //public override void EquiperArme(EnumArme uneArme)
        //{
        //    if (base.personnage != null)
        //    {
        //        switch (uneArme)
        //        {
        //            case EnumArme.Arc:
        //                base.personnage.Arme = new Arc();
        //                base.personnage.AugmenterStatsArme();
        //                break;
        //            case EnumArme.Dague:
        //                base.personnage.Arme = new Dague();
        //                base.personnage.AugmenterStatsArme();
        //                break;
        //            case EnumArme.DualHache:
        //                base.personnage.Arme = new Dual();
        //                base.personnage.AugmenterStatsArme();
        //                break;
        //            case EnumArme.Epee:
        //                base.personnage.Arme = new Epee();
        //                base.personnage.AugmenterStatsArme();
        //                break;
        //            case EnumArme.Sceptre:
        //                base.personnage.Arme = new Sceptre();
        //                base.personnage.AugmenterStatsArme();
        //                break;
        //            default:
        //                base.personnage.Arme = new Dague();
        //                base.personnage.AugmenterStatsArme();
        //                break;
        //        }
        //    }
        //}

        //public override void AugmenterStatsArmure()
        //{
        //    base.personnage.PDef += base.personnage.Armure.PDef;
        //}

        //public override void AugmenterStatsBijou()
        //{
        //    base.personnage.MDef += base.personnage.Bijou.MDef;
        //}

        //public override void AugmenterStatsArme()
        //{
        //    base.personnage.PAtk += base.personnage.Arme.PAtk;
        //    base.personnage.MAtk += base.personnage.Arme.MAtk;
        //}


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
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Buff HP impossible!", unPersonnage.Nom);
                else unPersonnage.MaxHP *= BuffHPQuantite;
            }
            else Console.WriteLine("{0} est mort: Buff HP impossible!", base.personnage.Nom);
        }

        public override void DebuffHP(PersonnageAbstrait unPersonnage)
        {
            if (base.personnage.HP > 0)
            {
                if (unPersonnage.HP == 0)
                    Console.WriteLine("{0} est mort: Debuff HP impossible!", unPersonnage.Nom);
                else unPersonnage.MaxHP *= DebuffHPQuantite;
            }
            else Console.WriteLine("{0} est mort: Debuff HP impossible!", base.personnage.Nom);
        }


        public override void AjusterSoinQuantite()
        {
            base.SoinQuantite += base.personnage.MAtk + base.personnage.Arme.MAtk;
        }

        public override void AjusterAttaqueMagiquePuissance()
        {
            base.AttaqueMagiquePuissance += base.personnage.MAtk;
        }
    }
}
