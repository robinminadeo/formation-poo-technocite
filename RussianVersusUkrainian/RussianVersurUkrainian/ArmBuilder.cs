using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianVersurUkrainian
{
    public class ArmBuilder
    {
        public List<FireArm> FireArmList { get; set; }
        public List<ColdSteel> ColdSteelList { get; set; }
        public ArmBuilder()
        {
            FireArmList = new List<FireArm>()
            {
                new Carabine() {Caliber = Caliber._7_62_OTAN, Name= "Remington 700PCR", MagasinCapacity = 10, Power=100, Weight=8},
                new Carabine() {Caliber = Caliber._7_62_39, Name= "Kalashnikov AK-47", MagasinCapacity = 30, Power=45, Weight=4},
                new Carabine() {Caliber = Caliber._5_56_OTAN, Name= "Smith & Wesson AR-15", MagasinCapacity= 30, Power=50, Weight=4},
                new Revolver() {Caliber = Caliber._9_mm, Name= "CZ Shadow 2", MagasinCapacity = 20, Power=25, Weight=0.8f},
                new Pistolet() {Caliber = Caliber._9_mm, Name= "Glock 17", MagasinCapacity= 17, Power=20, Weight=0.6f},
                new Pistolet() {Caliber = Caliber._9_mm, Name= "Beretta F92X", MagasinCapacity= 15, Power=22, Weight=0.8f},
                new Pistolet() {Caliber = Caliber._9_mm, Name= "CANIK", MagasinCapacity = 10, Power=18, Weight=0.7f},
                new Pistolet() {Caliber = Caliber._9_mm, Name= "Sig Sauer P220", MagasinCapacity = 10, Power=25, Weight=0.6f},
                new Missile(){Caliber = Caliber.NUCLEAR, Name= "Poseidon", Power = 1000000, Weight = 800}
            };

            ColdSteelList = new List<ColdSteel>()
            {
                new Machette() {Name= "Machette de ferme", Power=10, Size=1.1f, Matter = Matter.acier, Weight= 1},
                new Machette() {Name= "Machette de guerre", Power=40, Size=1.5f, Matter = Matter.or, Weight= 2.5f},
                new Machette() {Name= "Machette de cuisine", Power=20, Size=1.2f, Matter = Matter.argent, Weight= 1.5f},
                new Machette() {Name= "Machette tranchante", Power=50, Size=1.2f, Matter = Matter.carbone, Weight= 0.8f},
                new Marteau() {Name= "Marteau de forgeron", Power=30, Size=1.6f, Matter = Matter.acier, Weight= 10},
                new Marteau() {Name= "Marteau d'intervention", Power=50, Size=1, Matter = Matter.fer, Weight= 5},
                new Aiguille() {Name= "Aiguille a tricoter", Power=10, Size=0.5f, Matter = Matter.argent, Weight= 1},
                new Sabre() {Name= "Sabre japonais", Power=80, Size=1.2f, Matter = Matter.acier, Weight= 3},
                new Sabre() {Name= "Sabre tsar", Power=40, Size=1.5f, Matter = Matter.or, Weight= 3},
            };
        }
    }
}
