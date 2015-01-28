using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    abstract class PersonnageMysticAbstrait : PersonnageAbstrait
    {
        //Décorateur Abstrait

        protected PersonnageAbstrait personnage;
        protected Double SoinQuantite;
        protected Double AttaqueMagiquePuissance;
        protected Double BuffHPQuantite;
        protected Double DebuffHPQuantite;

        public PersonnageMysticAbstrait(String unNom)
            : base(unNom)
        {
        }

        public void setPersonnage(PersonnageAbstrait PersonnageImbrique)
        {
            personnage = PersonnageImbrique;
        }

        public override void EquiperArmure(EnumArmure uneArmure)
        {
            //if (personnage != null)
            //    personnage.EquiperArmure(uneArmure);
            if (personnage != null)
            {
                switch (uneArmure)
                {
                    case EnumArmure.ArmureLegere:
                        personnage.Armure = new ArmureLegere();
                        personnage.AugmenterStatsArmure();
                        break;
                    case EnumArmure.ArmureLourde:
                        personnage.Armure = new ArmureLourde();
                        personnage.AugmenterStatsArmure();
                        break;
                    case EnumArmure.Robe:
                        personnage.Armure = new Robe();
                        personnage.AugmenterStatsArmure();
                        break;
                    default:
                        personnage.Armure = new ArmureLegere();
                        personnage.AugmenterStatsArmure();
                        break;
                }
            }
        }

        public override void EquiperBijou(EnumBijou unBijou)
        {
            //if (personnage != null)
            //    personnage.EquiperBijou(unBijou);
            if (personnage != null)
            {
                switch (unBijou)
                {
                    case EnumBijou.Collier:
                        personnage.Bijou = new Collier();
                        personnage.AugmenterStatsBijou();
                        break;
                    case EnumBijou.BoucleOreille:
                        personnage.Bijou = new BoucleOreille();
                        personnage.AugmenterStatsBijou();
                        break;
                    case EnumBijou.Bague:
                        personnage.Bijou = new Bague();
                        personnage.AugmenterStatsBijou();
                        break;
                    default:
                        personnage.Bijou = new Bague();
                        personnage.AugmenterStatsBijou();
                        break;
                }
            }
        }

        public override void EquiperArme(EnumArme uneArme)
        {
            //if (personnage != null)
            //    personnage.EquiperArme(uneArme);
            if (personnage != null)
            {
                switch (uneArme)
                {
                    case EnumArme.Arc:
                        personnage.Arme = new Arc();
                        personnage.AugmenterStatsArme();
                        break;
                    case EnumArme.Dague:
                        personnage.Arme = new Dague();
                        personnage.AugmenterStatsArme();
                        break;
                    case EnumArme.DualHache:
                        personnage.Arme = new Dual();
                        personnage.AugmenterStatsArme();
                        break;
                    case EnumArme.Epee:
                        personnage.Arme = new Epee();
                        personnage.AugmenterStatsArme();
                        break;
                    case EnumArme.Sceptre:
                        personnage.Arme = new Sceptre();
                        personnage.AugmenterStatsArme();
                        break;
                    default:
                        personnage.Arme = new Dague();
                        personnage.AugmenterStatsArme();
                        break;
                }
            }
        }

        public override void AugmenterStatsArmure()
        {
            if (personnage != null)
                //personnage.AugmenterStatsArmure();
                personnage.PDef += personnage.Armure.PDef;
        }

        public override void AugmenterStatsBijou()
        {
            if (personnage != null)
                //personnage.AugmenterStatsBijou();
                personnage.MDef += personnage.Bijou.MDef;
        }

        public override void AugmenterStatsArme()
        {
            if (personnage != null)
            {
                //personnage.AugmenterStatsArme();
                personnage.PAtk += personnage.Arme.PAtk;
                personnage.MAtk += personnage.Arme.MAtk;
            }
        }

        public override void AugmenterMaxHP()
        {
            if (personnage != null)
                personnage.MaxHP = (personnage.HP + personnage.MDef + personnage.PDef);
        }

        //public override void AugmenterTousLesStats()
        //{
        //    if (personnage != null)
        //    {
        //        personnage.AugmenterStatsArmure();
        //        personnage.AugmenterStatsBijou();
        //        personnage.AugmenterStatsArme();
        //        personnage.AugmenterMaxHP();
        //    }
        //}

        public override void Attaquer(PersonnageAbstrait unPersonnage)
        {
            if (personnage != null)
            {
                if (personnage.HP > 0)
                {
                    if (unPersonnage != null)
                    {
                        unPersonnage.HP -= personnage.Arme.PAtk;
                        Console.WriteLine("Attaque {0}: {1} de dégats", unPersonnage.Nom, personnage.Arme.PAtk);
                        Console.WriteLine("Vie de {0}: {1}", unPersonnage.Nom, unPersonnage.HP);
                    }
                }
                else Console.WriteLine("{0} est mort: Attaque impossible", personnage.Nom);
            }
        }

        public abstract void Soigner(PersonnageAbstrait unPersonnage);
        public abstract void AttaqueMagique(PersonnageAbstrait unPersonnage);
        public abstract void BuffHP(PersonnageAbstrait unPersonnage);
        public abstract void DebuffHP(PersonnageAbstrait unPersonnage);

        public abstract void AjusterSoinQuantite();
        public abstract void AjusterAttaqueMagiquePuissance();

    }
}
