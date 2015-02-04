using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    internal abstract class PersonnageMysticAbstrait : PersonnageAbstrait
    {
        internal protected List<PersonnageAbstrait> TousLesPersonnages = new List<PersonnageAbstrait>();

        protected Double SoinQuantite;
        protected Double AttaqueMagiquePuissance;
        protected Double BuffHPQuantite;
        protected Double DebuffHPQuantite;

        protected String Summon;

        public PersonnageMysticAbstrait(String unNom)
            : base(unNom)
        {
        }

        public void AjouterPersonnage(PersonnageAbstrait PersonnageImbrique)
        {
            TousLesPersonnages.Add(PersonnageImbrique);
        }

        public void RetirerPersonnage(PersonnageAbstrait PersonnageImbrique)
        {
            TousLesPersonnages.Remove(PersonnageImbrique);
        }

        public override void EquiperArmure(EnumArmure uneArmure)
        {
            if (this != null)
            {
                switch (uneArmure)
                {
                    case EnumArmure.ArmureLegere:
                        Armure = new ArmureLegere();
                        AugmenterStatsArmure();
                        break;
                    case EnumArmure.ArmureLourde:
                        Armure = new ArmureLourde();
                        AugmenterStatsArmure();
                        break;
                    case EnumArmure.Robe:
                        Armure = new Robe();
                        Console.WriteLine("Robe équipée");
                        AugmenterStatsArmure();
                        break;
                    default:
                        Armure = new ArmureLegere();
                        AugmenterStatsArmure();
                        break;
                }
            }
        }

        public override void EquiperBijou(EnumBijou unBijou)
        {
            if (this != null)
            {
                switch (unBijou)
                {
                    case EnumBijou.Collier:
                        Bijou = new Collier();
                        Console.WriteLine("Collier équipé");
                        AugmenterStatsBijou();
                        break;
                    case EnumBijou.BoucleOreille:
                        Bijou = new BoucleOreille();
                        AugmenterStatsBijou();
                        break;
                    case EnumBijou.Bague:
                        Bijou = new Bague();
                        AugmenterStatsBijou();
                        break;
                    default:
                        Bijou = new Bague();
                        AugmenterStatsBijou();
                        break;
                }
            }
        }

        public override void EquiperArme(EnumArme uneArme)
        {
            if (this != null)
            {
                switch (uneArme)
                {
                    case EnumArme.Arc:
                        Arme = new Arc();
                        AugmenterStatsArme();
                        break;
                    case EnumArme.Dague:
                        Arme = new Dague();
                        AugmenterStatsArme();
                        break;
                    case EnumArme.DualHache:
                        Arme = new Dual();
                        AugmenterStatsArme();
                        break;
                    case EnumArme.Epee:
                        Arme = new Epee();
                        AugmenterStatsArme();
                        break;
                    case EnumArme.Sceptre:
                        Arme = new Sceptre();
                        Console.WriteLine("Sceptre équipé");
                        AugmenterStatsArme();
                        break;
                    default:
                        Arme = new Dague();
                        AugmenterStatsArme();
                        break;
                }
            }
        }

        public override void AugmenterStatsArmure()
        {
            if (this != null)
                PDef += Armure.PDef;
        }

        public override void AugmenterStatsBijou()
        {
            if (this != null)
                MDef += Bijou.MDef;
        }

        public override void AugmenterStatsArme()
        {
            if (this != null)
            {
                PAtk += Arme.PAtk;
                MAtk += Arme.MAtk;
            }
        }

        public override void AugmenterMaxHP()
        {
            if (this != null)
            {
                //Augmentation de la vie du personnage équipé en fonction de l'armure et du bijou équipé
                //Le niveau de vie maximum augmente et dépend de la défense physique et magique du personnage
                if (Armure != null && Bijou != null)
                {
                    MaxHP = (HP + MDef + PDef);
                    HP = MaxHP;
                    Console.WriteLine("Max HP augmenté");
                }
            }
        }

        public override void AugmenterTousLesStats()
        {
            if (this != null)
            {
                AugmenterStatsBijou();
                AugmenterStatsArmure();
                AugmenterStatsArme();
                AugmenterMaxHP();
            }
        }

        public override void Attaquer(PersonnageAbstrait unPersonnage)
        {
            if (this != null)
            {
                if (HP > 0)
                {
                    if (unPersonnage != null)
                    {
                        unPersonnage.HP -= Arme.PAtk;
                        Console.WriteLine("Attaque {0}: {1} de dégats", unPersonnage.Nom, Arme.PAtk);
                        Console.WriteLine("Vie de {0}: {1}", unPersonnage.Nom, unPersonnage.HP);
                    }
                }
                else Console.WriteLine("{0} est mort: Attaque impossible", Nom);
            }
        }

        public override void AfficherProfil()
        {
            if(Arme == null || Armure == null || Bijou == null)
                Console.WriteLine("Nom: {0}\nClasse: {1}\nLimite HP: {2}\nHP: {3}\nPAtk: {4}\nMAtk: {5}\nPDef: {6}\nMDef: {7}", Nom, this.GetType().ToString(), MaxHP, HP, PAtk, MAtk, PDef, MDef);
            else Console.WriteLine("Nom:{0}\nClasse: {1}\nLimite HP: {2}\nHP: {3}\nPAtk: {4}\nMAtk: {5}\nPDef: {6}\nMDef: {7}\nArme: {8}\nArmure: {9}\nBijou: {10}", Nom, this.GetType().ToString(), MaxHP, HP, PAtk, MAtk, PDef, MDef, Arme.Nom, Armure.Nom, Bijou.Nom);

            try
            {
                foreach (PersonnageAbstrait personnage in TousLesPersonnages)
                {
                    if (this == personnage && Summon != null)
                    {
                        Console.WriteLine("Nom de l'invocation: {0}", Summon);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Classe du personnage introuvable: {0}", ex);
            }
        }

        //public abstract void Soigner(PersonnageAbstrait unPersonnage);
        //public abstract void AttaqueMagique(PersonnageAbstrait unPersonnage);
        //public abstract void BuffHP(PersonnageAbstrait unPersonnage);
        //public abstract void DebuffHP(PersonnageAbstrait unPersonnage);

        //public abstract void AjusterSoinQuantite();
        //public abstract void AjusterAttaqueMagiquePuissance();

    }
}
