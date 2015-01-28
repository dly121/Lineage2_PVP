using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    abstract class PersonnageFighterAbstrait : PersonnageAbstrait
    {
        //Décorateur Abstrait

        protected PersonnageAbstrait personnage;

        protected Double CoupDaguePuissance;
        protected Double CoupArcPuissance;
        protected Double CoupEpeePuissance;
        protected Double CoupDualPuissance;

        public PersonnageFighterAbstrait(String unNom)
            : base(unNom)
        {
        }

        public void setPersonnage(PersonnageAbstrait PersonnageImbrique)
        {
            personnage = PersonnageImbrique;
        }

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

        public override void EquiperArmure(EnumArmure uneArmure)
        {
            if (personnage != null)
                personnage.EquiperArmure(uneArmure);
        }

        public override void EquiperBijou(EnumBijou unBijou)
        {
            if (personnage != null)
                personnage.EquiperBijou(unBijou);
        }

        public override void EquiperArme(EnumArme uneArme)
        {
            if (personnage != null)
                personnage.EquiperArme(uneArme);
        }

        public override void AugmenterStatsArmure()
        {
            if (personnage != null)
                personnage.AugmenterStatsArmure();
        }

        public override void AugmenterStatsBijou()
        {
            if (personnage != null)
                personnage.AugmenterStatsBijou();
        }

        public override void AugmenterStatsArme()
        {
            if (personnage != null)
                personnage.AugmenterStatsArme();
        }

        public override void AugmenterMaxHP()
        {
            if (personnage != null)
                personnage.MaxHP = (personnage.HP + personnage.MDef + personnage.PDef);
        }

        public abstract void Attaque_CoupDague(PersonnageAbstrait unPersonnage);
        public abstract void Attaque_CoupEpee(PersonnageAbstrait unPersonnage);
        public abstract void Attaque_CoupDual(PersonnageAbstrait unPersonnage);
        public abstract void Attaque_TirerFleche(PersonnageAbstrait unPersonnage);

        public abstract void AjusterPuissanceDague();
        public abstract void AjusterPuissanceArc();
        public abstract void AjusterPuissanceDual();
        public abstract void AjusterPuissanceEpee();
    }
}
