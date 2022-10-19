using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVersurUkrainian
{
    public class StorageHelper
    {
        private const string FireArmFile = "fireArms.txt";
        private const string ColdSteelFile = "coldSteels.txt";
        public static void GetStorage(out List<ColdSteel> coldSteels, out List<FireArm> fireArms)
        {
            string fireArmStr;
            string coldSteelStr;
            while (true)
            {
                try
                {
                    fireArmStr = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, FireArmFile));
                    coldSteelStr = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, ColdSteelFile));
                    break;
                }
                catch
                {
                    var builder = new ArmBuilder();
                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, FireArmFile), JsonConvert.SerializeObject(builder.FireArmList));
                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, ColdSteelFile), JsonConvert.SerializeObject(builder.ColdSteelList));
                }
            }

            coldSteels = JsonConvert.DeserializeObject<List<ColdSteel>>(coldSteelStr);
            fireArms = JsonConvert.DeserializeObject<List<FireArm>>(fireArmStr);
        }
    }
}
