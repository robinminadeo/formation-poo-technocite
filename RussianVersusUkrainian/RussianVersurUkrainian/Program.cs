using Newtonsoft.Json;

using RussianVersurUkrainian;

using System;

namespace RussianVersusUkrainian
{
    public class Program
    {
        private static int nb_soldat;
        static void Main(string[] args)
        {
            do
            {
                StorageHelper.GetStorage(out List<ColdSteel> coldSteels, out List<FireArm> fireArms);
                HowManySoldiers();
                GetRandomWeapon(coldSteels, fireArms, out List<IArm> ukrainianWeapons, out List<IArm> russianWeapons);
                LetsFight(ukrainianWeapons, russianWeapons);
            } while (WouldContinue());

        }

        private static bool WouldContinue()
        {
            bool wouldContinue;
            while (true)
            {
                Console.WriteLine("Voulez-vous rejouer (O/N)?");
                var res = Console.ReadLine();
                try
                {
                    if (res.ToUpper() == "O") wouldContinue = true;
                    else if (res.ToUpper() == "N") wouldContinue = false;
                    else
                    {
                        throw new InvalidDataException();
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Veuillez indiquer si vous souhaitez rejouer ou non.");
                }
            }
            Console.Clear();
            return wouldContinue;
        }

        private static void LetsFight(List<IArm> ukrainianWeapons, List<IArm> russianWeapons)
        {
            var ukrainianHasNuclear = HasNuclearWeapon(ukrainianWeapons);
            var russianHasNuclear = HasNuclearWeapon(russianWeapons);

            if (ukrainianHasNuclear && russianHasNuclear)
            {
                Console.WriteLine("Guerre Nucléaire : La Russie et l'Ukraine sont a égalité");
            }
            else if (ukrainianHasNuclear)
            {
                Console.WriteLine("Guerre Nucléaire : L'Ukraine a gagné");
            }
            else if (russianHasNuclear)
            {
                Console.WriteLine("Guerre Nucléaire : La Russie a gagné");
            }
            else
            {
                var ukrainianScore = 0;
                var russianScore = 0;
                var equality = 0;
                Console.WriteLine("=======Champ de bataille=======\n");
                for (int i = 0; i < nb_soldat; i++)
                {
                   var ukrainianSoldierDamage = GetDamage(ukrainianWeapons[i]);
                   var russianSoldierDamage = GetDamage(russianWeapons[i]);
                    _= ukrainianSoldierDamage == russianSoldierDamage ? equality++ : ukrainianSoldierDamage > russianSoldierDamage ? ukrainianScore++ : russianScore++;
                    Console.WriteLine($"Soldat ukrainien {i+1} : {ukrainianWeapons[i].Name},dégats: {ukrainianSoldierDamage}");
                    Console.WriteLine($"Soldat russe {i + 1} : {russianWeapons[i].Name},dégats: {russianSoldierDamage}");
                    Console.WriteLine(ukrainianSoldierDamage == russianSoldierDamage ? "====> Egalité !" : "====> Victoire du soldat " + (ukrainianSoldierDamage > russianSoldierDamage ? "ukrainien" : "russe"));
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
                Console.WriteLine($"Russie : {russianScore}/{nb_soldat}   VS   Ukraine : {ukrainianScore}/{nb_soldat}");
                if(equality != 0)
                {
                    Console.WriteLine($"{equality} égalitée pendant le combat...");
                }
                Console.WriteLine(ukrainianScore == russianScore ? "====> Les deux camps sont a égalité!" : "Victoire de " + (ukrainianScore > russianScore ? "l'Ukraine" : "la Russie") );
            }
        }

        private static float GetDamage(IArm arm)
        {
            if (arm.GetType() == typeof(FireArm)){ 
                var tmp = (FireArm)arm;
                return tmp.fire();
            }
            else {
                var tmp = (ColdSteel)arm;
                return tmp.cut();
            }
        }

        private static bool HasNuclearWeapon(List<IArm> weapons)
        {
            var hasNuclear = false;
            weapons.ForEach(x =>
            {
                if(x.GetType() == typeof(FireArm) ){
                    var tmp = (FireArm)x;
                    if(tmp.Caliber == Caliber.NUCLEAR)
                    {
                        hasNuclear = true;
                    }
                }
            });
            return hasNuclear;
        }

        private static void HowManySoldiers()
        {
            while (true)
            {
                Console.WriteLine("Combien de soldats constituent votre armée ?");
                var nb = Console.ReadLine();
                try
                {
                    nb_soldat = int.Parse(nb);
                    if(nb_soldat <=0) throw new InvalidDataException();
                    break;
                } catch
                {
                    Console.WriteLine("Veuillez indiquer un chiffre correct.");
                }
            }
        }

        private static void GetRandomWeapon(List<ColdSteel> coldSteels, List<FireArm> fireArms, out List<IArm> ukrainianWeapons, out List<IArm> russianWeapons)
        {
            ukrainianWeapons = new List<IArm>();
            russianWeapons = new List<IArm>();
            Random rd = new Random();
            for (int i = 0; i < nb_soldat; i++)
            {
                if(rd.Next(0,2) == 0)
                {
                    ukrainianWeapons.Add(coldSteels[rd.Next(coldSteels.Count)]);
                    russianWeapons.Add(coldSteels[rd.Next(coldSteels.Count)]);
                } else
                {
                    ukrainianWeapons.Add(fireArms[rd.Next(fireArms.Count)]);
                    russianWeapons.Add(fireArms[rd.Next(fireArms.Count)]);
                }
            }
        }
        
    }

}