using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    abstract class PersonnageAbstrait
    {

        internal protected String Nom;
        internal protected ArmeAbstraite Arme;
        internal protected ArmureAbstraite Armure;
        internal protected BijouAbstrait Bijou;
        internal protected Double HP;
        internal protected Double MaxHP;
        internal protected Double PDef;
        internal protected Double MDef;
        internal protected Double PAtk;
        internal protected Double MAtk;

        protected PersonnageAbstrait(String unNom) { }

        public abstract void EquiperArmure(EnumArmure uneArmure);
        public abstract void EquiperBijou(EnumBijou unBijou);
        public abstract void EquiperArme(EnumArme uneArme);

        public abstract void AugmenterMaxHP();
        public abstract void AugmenterStatsArmure();
        public abstract void AugmenterStatsBijou();
        public abstract void AugmenterStatsArme();
        public abstract void AugmenterTousLesStats();

        public abstract void AfficherProfil();

        public abstract void Attaquer(PersonnageAbstrait unPersonnage);

        //Compétences Mystic
        public abstract void Soigner(PersonnageAbstrait unPersonnage);
        public abstract void AttaqueMagique(PersonnageAbstrait unPersonnage);
        public abstract void BuffHP(PersonnageAbstrait unPersonnage);
        public abstract void DebuffHP(PersonnageAbstrait unPersonnage);

        public abstract void AjusterSoinQuantite();
        public abstract void AjusterAttaqueMagiquePuissance();

        //Compétences Fighter
        public abstract void Attaque_CoupDague(PersonnageAbstrait unPersonnage);
        public abstract void Attaque_CoupEpee(PersonnageAbstrait unPersonnage);
        public abstract void Attaque_CoupDual(PersonnageAbstrait unPersonnage);
        public abstract void Attaque_TirerFleche(PersonnageAbstrait unPersonnage);

        public abstract void AjusterPuissanceDague();
        public abstract void AjusterPuissanceArc();
        public abstract void AjusterPuissanceDual();
        public abstract void AjusterPuissanceEpee();

        //Compétences Summoner
        public abstract void InvoquerSummon(String unNomDeBete);
    }
}
