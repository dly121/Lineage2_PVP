using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2_PVP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonnageAbstrait> ListeDePersonnages = new List<PersonnageAbstrait>();

            FabriqueAbstraite fabriqueHealer = new FabriqueAeoreHealer();
            FabriqueAbstraite fabriqueIss = new FabriqueIssEnchanter();
            FabriqueAbstraite fabriqueKnight = new FabriqueSigelKnight();
            FabriqueAbstraite fabriqueRogue = new FabriqueOthellRogue();
            FabriqueAbstraite fabriqueWizard = new FabriqueFeohWizard();
            FabriqueAbstraite fabriqueArcher = new FabriqueYulArcher();
            FabriqueAbstraite fabriqueWynn = new FabriqueWynnSummoner();

            //Le test du code commence ici

            PersonnageAbstrait healer1;
            PersonnageAbstrait iss1;
            PersonnageAbstrait sigel1;
            PersonnageAbstrait wynn1;
            PersonnageAbstrait healer2;

            healer1 = fabriqueHealer.CreerPersonnage("Healer 1");
            iss1 = fabriqueIss.CreerPersonnage("Iss 1");
            sigel1 = fabriqueKnight.CreerPersonnage("Knight 1");
            wynn1 = fabriqueWynn.CreerPersonnage("Wynn 1");
            healer2 = fabriqueHealer.CreerPersonnage("Healer 2");

            try
            {
                healer1.AfficherProfil();
                Console.WriteLine("---------------------------------");
                healer1.EquiperArmure(EnumArmure.Robe);
                healer1.EquiperBijou(EnumBijou.Collier);
                healer1.EquiperArme(EnumArme.Sceptre);
                healer1.AugmenterMaxHP();
                Console.WriteLine("---------------------------------");
                healer1.AfficherProfil();
                Console.WriteLine("---------------------------------");
                sigel1.AfficherProfil();
                Console.WriteLine("---------------------------------");
                sigel1.EquiperArmure(EnumArmure.ArmureLourde);
                sigel1.EquiperBijou(EnumBijou.Collier);
                sigel1.EquiperArme(EnumArme.Epee);
                sigel1.AugmenterMaxHP();
                Console.WriteLine("---------------------------------");
                sigel1.AfficherProfil();
                healer1.AjusterSoinQuantite();
                healer1.AjusterAttaqueMagiquePuissance();
                Console.WriteLine("---------------attaque magique------------------");
                healer1.AttaqueMagique(sigel1);
                sigel1.AfficherProfil();
                Console.WriteLine("---------------------------------");
                sigel1.AjusterPuissanceEpee();
                Console.WriteLine("---------------heal sigel 1------------------");
                healer1.Soigner(sigel1);
                sigel1.AfficherProfil();
                Console.WriteLine("---------------heal sigel 2------------------");
                healer1.Soigner(sigel1);
                sigel1.AfficherProfil();
                Console.WriteLine("---------------attaque epee 1-----------------");
                sigel1.Attaque_CoupEpee(healer1);
                healer1.AfficherProfil();
                Console.WriteLine("---------------attaque epee 2-----------------");
                sigel1.Attaque_CoupEpee(healer1);
                healer1.AfficherProfil();
                Console.WriteLine("---------------heal sigel 3------------------");
                healer1.Soigner(sigel1);
                sigel1.AfficherProfil();
                Console.WriteLine("---------------heal healer------------------");
                healer1.Soigner(healer1);
                healer1.AfficherProfil();
                Console.WriteLine("---------------création wynn------------------");
                wynn1.EquiperArmure(EnumArmure.Robe);
                wynn1.EquiperBijou(EnumBijou.Collier);
                wynn1.EquiperArme(EnumArme.Sceptre);
                wynn1.AugmenterMaxHP();
                wynn1.InvoquerSummon("Kitikawa");
                wynn1.AfficherProfil();
                Console.WriteLine("---------------création iss------------------");
                iss1.EquiperArmure(EnumArmure.Robe);
                iss1.EquiperBijou(EnumBijou.Collier);
                iss1.EquiperArme(EnumArme.Sceptre);
                iss1.AugmenterMaxHP();
                iss1.InvoquerSummon("Kitikawa");
                iss1.AfficherProfil();
                Console.WriteLine("---------------buff iss------------------");
                iss1.BuffHP(iss1);
                iss1.AfficherProfil();
                Console.WriteLine("---------------buff sigel------------------");
                iss1.BuffHP(sigel1);
                sigel1.AfficherProfil();
                Console.WriteLine("----------------création healer2-----------------");
                healer2.EquiperArmure(EnumArmure.Robe);
                healer2.EquiperBijou(EnumBijou.Collier);
                healer2.EquiperArme(EnumArme.Sceptre);
                healer2.AugmenterMaxHP();
                Console.WriteLine("---------------------------------");
                healer2.AfficherProfil();
                Console.WriteLine("---------------buff sigel by aeore------------------");
                healer2.BuffHP(sigel1);
                sigel1.AfficherProfil();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur survenue: {0}", ex);
            }
            
            Console.ReadLine();
        }
    }
}
