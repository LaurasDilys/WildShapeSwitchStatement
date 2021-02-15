using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildShapeSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region <commented out>
            //if (CR == -1)
            //{
            //    Console.WriteLine("Incorrect creature name.");
            //}
            //else
            //{
            //    Console.Write(name);
            //    if (size != "null")
            //    {
            //        Console.Write($" ({size})");
            //    }
            //    Console.WriteLine("\n");

            //    if (AC > -5) { Console.WriteLine($"AC: {AC}"); };
            //    if (HP > -5) { Console.WriteLine($"HP: {HP}"); };
            //    if (speed > -5) { Console.Write($"Speed: {speed} ft."); };
            //    if (swim > -5) { Console.Write($", swim {swim} ft."); };
            //    if (fly > -5) { Console.Write($", fly {fly} ft."); };
            //    if (burrow > -5) { Console.Write($", burrow {burrow} ft."); };
            //    if (climb > -5) { Console.Write($", climb {climb} ft."); };
            //    if (name == "Air Elemental") { Console.Write($" (hover)"); };
            //    if (CR != -5) { Console.WriteLine("\n"); };

            //    Console.Write($"[{STR}] STR: ");
            //    int STRX = AM(STR);
            //    if (STRX > 0) { Console.Write("+"); };
            //    Console.WriteLine(STRX);
            //    Console.Write("Saving throw: ");
            //    int STRstX = STR0st ? (STRX + PROF) : STRX;
            //    if (STRstX > 0 || STRst > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(STRstX, STRst));
            //    Console.Write("Athletics: ");
            //    int athleticsX = athletics0 ? (STRX + PROF) : STRX;
            //    if (athleticsX > 0 || athletics > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(athleticsX, athletics));
            //    Console.WriteLine();

            //    Console.Write($"[{DEX}] DEX: ");
            //    int DEXX = AM(DEX);
            //    if (DEXX > 0) { Console.Write("+"); };
            //    Console.WriteLine(DEXX);
            //    Console.Write("Saving throw: ");
            //    int DEXstX = DEX0st ? (DEXX + PROF) : DEXX;
            //    if (DEXstX > 0 || DEXst > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(DEXstX, DEXst));
            //    Console.Write("Acrobatics: ");
            //    int acrobaticsX = acrobatics0 ? (DEXX + PROF) : DEXX;
            //    if (acrobaticsX > 0 || acrobatics > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(acrobaticsX, acrobatics));
            //    Console.Write("Sleight of hand: ");
            //    int sleightOfHandX = sleightOfHand0 ? (DEXX + PROF) : DEXX;
            //    if (sleightOfHandX > 0 || sleightOfHand > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(sleightOfHandX, sleightOfHand));
            //    Console.Write("Stealth: ");
            //    int stealthX = stealth0 ? (DEXX + PROF) : DEXX;
            //    if (stealthX > 0 || stealth > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(stealthX, stealth));
            //    Console.WriteLine();

            //    Console.Write($"[{CON}] CON: ");
            //    int CONX = AM(CON);
            //    if (CONX > 0) { Console.Write("+"); };
            //    Console.WriteLine(CONX);
            //    Console.Write("Saving throw: ");
            //    int CONstX = CON0st ? (CONX + PROF) : CONX;
            //    if (CONstX > 0 || CONst > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(CONstX, CONst));
            //    Console.WriteLine("\n");


            //    Console.Write($"[{INT0}] INT: ");
            //    int INTX = AM(INT0);
            //    if (INTX > 0) { Console.Write("+"); };
            //    Console.WriteLine(INTX);
            //    Console.Write("Saving throw: ");
            //    int INTstX = INT0st ? (INTX + PROF) : INTX;
            //    if (INTstX > 0 || INTst > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(INTstX, INTst));
            //    Console.Write("Arcana: ");
            //    int arcanaX = arcana0 ? (INTX + PROF) : INTX;
            //    if (arcanaX > 0 || arcana > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(arcanaX, arcana));
            //    Console.Write("History: ");
            //    int historyX = history0 ? (INTX + PROF) : INTX;
            //    if (historyX > 0 || history > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(historyX, history));
            //    Console.Write("Investigation: ");
            //    int investigationX = investigation0 ? (INTX + PROF) : INTX;
            //    if (investigationX > 0 || investigation > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(investigationX, investigation));
            //    Console.Write("Nature: ");
            //    int natureX = nature0 ? (INTX + PROF) : INTX;
            //    if (natureX > 0 || nature > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(natureX, nature));
            //    Console.Write("Religion: ");
            //    int religionX = religion0 ? (INTX + PROF) : INTX;
            //    if (religionX > 0 || religion > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(religionX, religion));
            //    Console.WriteLine();

            //    Console.Write($"[{WIS0}] WIS: ");
            //    int WISX = AM(WIS0);
            //    if (WISX > 0) { Console.Write("+"); };
            //    Console.WriteLine(WISX);
            //    Console.Write("Saving throw: ");
            //    int WISstX = WIS0st ? (WISX + PROF) : WISX;
            //    if (WISstX > 0 || WISst > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(WISstX, WISst));
            //    Console.Write("Animal Handling: ");
            //    int animalHandlingX = animalHandling0 ? (WISX + PROF) : WISX;
            //    if (animalHandlingX > 0 || animalHandling > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(animalHandlingX, animalHandling));
            //    Console.Write("Insight: ");
            //    int insightX = insight0 ? (WISX + PROF) : WISX;
            //    if (insightX > 0 || insight > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(insightX, insight));
            //    Console.Write("Medicine: ");
            //    int medicineX = medicine0 ? (WISX + PROF) : WISX;
            //    if (medicineX > 0 || medicine > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(medicineX, medicine));
            //    Console.Write("Perception: ");
            //    int perceptionX = perception0 ? (WISX + PROF) : WISX;
            //    if (perceptionX > 0 || perception > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(perceptionX, perception));
            //    Console.Write("Survival: ");
            //    int survivalX = survival0 ? (WISX + PROF) : WISX;
            //    if (survivalX > 0 || survival > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(survivalX, survival));
            //    Console.WriteLine();

            //    Console.Write($"[{CHA0}] CHA: ");
            //    int CHAX = AM(CHA0);
            //    if (CHAX > 0) { Console.Write("+"); };
            //    Console.WriteLine(CHAX);
            //    Console.Write("Saving throw: ");
            //    int CHAstX = CHA0st ? (CHAX + PROF) : CHAX;
            //    if (CHAstX > 0 || CHAst > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(CHAstX, CHAst));
            //    Console.Write("Deception: ");
            //    int deceptionX = deception0 ? (CHAX + PROF) : CHAX;
            //    if (deceptionX > 0 || deception > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(deceptionX, deceptionX));
            //    Console.Write("Intimidation: ");
            //    int intimidationX = intimidation0 ? (CHAX + PROF) : CHAX;
            //    if (intimidationX > 0 || intimidation > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(intimidationX, intimidation));
            //    Console.Write("Performance: ");
            //    int performanceX = performance0 ? (CHAX + PROF) : CHAX;
            //    if (performanceX > 0 || performance > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(performanceX, performance));
            //    Console.Write("Persuasion: ");
            //    int persuasionX = persuasion0 ? (CHAX + PROF) : CHAX;
            //    if (persuasionX > 0 || persuasion > 0) { Console.Write("+"); };
            //    Console.WriteLine(Math.Max(persuasionX, persuasion));
            //    Console.WriteLine("\n");

            //    //If I'm proficient in perception I can either choose my standard Passive Perception or the creature's
            //    Console.Write("Passive Perception: ");
            //    if (perception0 == true)
            //    {
            //        passivePerception0 = 10 + WISX + PROF;
            //        Console.WriteLine(Math.Max(passivePerception0, passivePerception));
            //    }
            //    else
            //    {
            //        passivePerception0 = 10 + WISX;
            //        Console.WriteLine(passivePerception0);
            //    }
            //    Console.WriteLine("\n");

            //    //First checking if any of this information is available for the chosen creature
            //    if (traits != "null")
            //    {
            //        Console.WriteLine(traits);
            //        Console.WriteLine();
            //    }
            //    if (senses != "null")
            //    {
            //        Console.WriteLine($"Senses: {senses}");
            //        Console.WriteLine("\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine();
            //    }
            //    if (languages != "null")
            //    {
            //        Console.WriteLine($"Languages: {languages}");
            //        Console.WriteLine("\n");
            //    }
            //    if (environments != "null")
            //    {
            //        Console.WriteLine($"Environments: {environments}");
            //        Console.WriteLine("\n");
            //    }
            //}
            #endregion

            StringBuilder sb = new StringBuilder();
            sb.Append("Change birds' ALLIGNMENT\n\n");
            int ID = 0;
            List<string> allTraits = new List<string>();
            List<string> allEnvirons = new List<string>();
            List<string> tags = new List<string>();
            foreach (var monster in MonsterList.Monsters)
            {                                         //.Where(x => x == "Tyrannosaurus Rex")
                ID++;
                string input = SC(monster);
                #region <initial values>
                // Some beasts have Skill Proficiencies and Senses, so new values might be assigned to some of these variables.
                string name = "";
                string size = "null";
                string tag = "null";
                int AC = -5;
                int HP = -5;
                int speed = -5;
                int swim = -5;
                int fly = -5;
                int burrow = -5;
                int climb = -5;

                float STR = -5;
                int STRst = -5;
                int athletics = -5;
                float DEX = -5;
                int DEXst = -5;
                int acrobatics = -5;
                int sleightOfHand = -5;
                int stealth = -5;
                float CON = -5;
                int CONst = -5;

                float INT = -5;
                int INTst = -5;
                int arcana = -5;
                int history = -5;
                int investigation = -5;
                int nature = -5;
                int religion = -5;
                float WIS = -5;
                int WISst = -5;
                int animalHandling = -5;
                int insight = -5;
                int medicine = -5;
                int perception = -5;
                int survival = -5;
                float CHA = -5;
                int CHAst = -5;
                int deception = -5;
                int intimidation = -5;
                int performance = -5;
                int persuasion = -5;

                string senses = "null";
                int passivePerception = -5;
                string languages = "null";
                double CR = -5;

                string traits = "null";
                string environments = "null";
                #endregion

                #region <infinite switch statement>
                switch (input)
                {
                    case "fire":
                    case "fireelemental":

                        name = "Fire Elemental";
                        size = "Large";
                        tag = "Elemental";

                        AC = 13;
                        HP = 102;
                        speed = 50;

                        STR = 10;
                        DEX = 17;
                        CON = 16;
                        INT = 6;
                        WIS = 10;
                        CHA = 7;

                        senses = "Darkvision 60 ft.";
                        passivePerception = 10;
                        languages = "Ignan";
                        CR = 5;

                        traits = $"Fire Form -- Illumination -- Water Susceptibility --{"\n"}{"\n"}DMG Resistances: Bludgeoning, Piercing, and Slashing from Nonmagical Attacks{"\n"}{"\n"}DMG Immunities: Fire, Poison{"\n"}{"\n"}Condition Immunities: Exhaustion, Grappled, Paralyzed, Petrified, Poisoned, Prone, Restrained, Unconscious";

                        environments = "Desert";

                        break;

                    case "water":
                    case "waterelemental":

                        name = "Water Elemental";
                        size = "Large";
                        tag = "Elemental";

                        AC = 14;
                        HP = 114;
                        speed = 30;
                        swim = 90;

                        STR = 18;
                        DEX = 14;
                        CON = 18;
                        INT = 5;
                        WIS = 10;
                        CHA = 8;

                        senses = "Darkvision 60 ft.";
                        passivePerception = 10;
                        languages = "Aquan";
                        CR = 5;

                        traits = $"Water Form -- Freeze --{"\n"}{"\n"}DMG Resistances: Acid, Bludgeoning, Piercing, and Slashing from Nonmagical Attacks{"\n"}{"\n"}DMG Immunities: Poison{"\n"}{"\n"}Condition Immunities: Exhaustion, Grappled, Paralyzed, Petrified, Poisoned, Prone, Restrained, Unconscious";

                        environments = "Coastal, Swamp, Underwater";

                        break;

                    case "earth":
                    case "earthelemental":

                        name = "Earth Elemental";
                        size = "Large";
                        tag = "Elemental";

                        AC = 17;
                        HP = 126;
                        speed = 30;
                        burrow = 30;

                        STR = 20;
                        DEX = 8;
                        CON = 20;
                        INT = 5;
                        WIS = 10;
                        CHA = 5;

                        senses = "Darkvision 60 ft., Tremorsense 60 ft.";
                        passivePerception = 10;
                        languages = "Terran";
                        CR = 5;

                        traits = $"Earth Glide -- Siege Monster --{"\n"}{"\n"}DMG Vulnerabilities: Thunder.{"\n"}{"\n"}DMG Resistances: Bludgeoning, Piercing, and Slashing from Nonmagical Attacks{"\n"}{"\n"}DMG Immunities: Poison{"\n"}{"\n"}Condition Immunities: Exhaustion, Paralyzed, Petrified, Poisoned, Unconscious";

                        environments = "Underdark";

                        break;

                    case "air":
                    case "airelemental":

                        name = "Air Elemental";
                        size = "Large";
                        tag = "Elemental";

                        AC = 15;
                        HP = 90;
                        speed = 0;
                        fly = 90;

                        STR = 14;
                        DEX = 20;
                        CON = 14;
                        INT = 6;
                        WIS = 10;
                        CHA = 6;

                        senses = "Darkvision 60 ft.";
                        passivePerception = 10;
                        languages = "Auran";
                        CR = 5;

                        traits = $"Air Form --{"\n"}{"\n"}DMG Resistances: Lightning, Thunder; Bludgeoning, Piercing, and Slashing from Nonmagical Attacks{"\n"}{"\n"}DMG Immunities: Poison{"\n"}{"\n"}Condition Immunities: Exhaustion, Grappled, Paralyzed, Petrified, Poisoned, Prone, Restrained, Unconscious";

                        environments = "Desert, Mountain";

                        break;

                    case "tyrannosaurus":
                    case "tyrannosaurusrex":
                    case "rex":

                        name = "Tyrannosaurus Rex";
                        size = "Huge";
                        tag = "Dinosaur";

                        AC = 13;
                        HP = 136;
                        speed = 50;

                        STR = 25;
                        DEX = 10;
                        CON = 19;
                        INT = 2;
                        WIS = 12;
                        CHA = 9;

                        perception = 4;
                        passivePerception = 14;
                        CR = 8;

                        environments = "Grassland";

                        break;

                    case "giantape":

                        name = "Giant Ape";
                        size = "Huge";

                        AC = 12;
                        HP = 157;
                        speed = 40;
                        climb = 40;

                        STR = 23;
                        DEX = 14;
                        CON = 18;
                        INT = 7;
                        WIS = 12;
                        CHA = 7;

                        athletics = 9;
                        perception = 4;
                        passivePerception = 14;
                        CR = 7;

                        environments = "Forest";

                        break;

                    case "mammoth":
                    case "mamoth":

                        name = "Mammoth";
                        size = "Huge";

                        AC = 13;
                        HP = 126;
                        speed = 40;

                        STR = 24;
                        DEX = 9;
                        CON = 21;
                        INT = 3;
                        WIS = 11;
                        CHA = 6;

                        passivePerception = 10;
                        CR = 6;

                        traits = "Trampling Charge --";

                        environments = "Arctic";

                        break;

                    case "giantcrocodile":
                    case "giantcroc":

                        name = "Giant Crocodile";
                        size = "Huge";

                        AC = 14;
                        HP = 85;
                        speed = 30;
                        swim = 50;

                        STR = 21;
                        DEX = 9;
                        CON = 17;
                        INT = 2;
                        WIS = 10;
                        CHA = 7;

                        stealth = 5;
                        passivePerception = 10;
                        CR = 5;

                        traits = "Hold Breath. The crocodile can hold its breath for 30 minutes.";

                        environments = "Swamp";

                        break;

                    case "giantshark":

                        name = "Giant Shark";
                        size = "Huge";

                        AC = 13;
                        HP = 126;
                        speed = 0;
                        swim = 50;

                        STR = 23;
                        DEX = 11;
                        CON = 21;
                        INT = 1;
                        WIS = 10;
                        CHA = 5;

                        perception = 3;
                        senses = "Blindsight 60 ft.";
                        passivePerception = 13;
                        CR = 5;

                        traits = "Blood Frenzy -- Water Breathing --";

                        environments = "Underwater";

                        break;

                    case "triceratops":

                        name = "Triceratops";
                        size = "Huge";
                        tag = "Dinosaur";

                        AC = 13;
                        HP = 95;
                        speed = 50;

                        STR = 22;
                        DEX = 9;
                        CON = 17;
                        INT = 2;
                        WIS = 11;
                        CHA = 5;

                        passivePerception = 10;
                        CR = 5;

                        traits = "Trampling Charge --";

                        environments = "Grassland";

                        break;

                    case "elephant":

                        name = "Elephant";
                        size = "Huge";

                        AC = 12;
                        HP = 76;
                        speed = 40;

                        STR = 22;
                        DEX = 9;
                        CON = 17;
                        INT = 3;
                        WIS = 11;
                        CHA = 6;

                        passivePerception = 10;
                        CR = 4;

                        traits = "Trampling Charge --";

                        environments = "Grassland";

                        break;

                    case "ankylosaurus":
                    case "ankylo":
                    case "anky":

                        name = "Ankylosaurus";
                        size = "Huge";
                        tag = "Dinosaur";

                        AC = 15;
                        HP = 68;
                        speed = 30;

                        STR = 19;
                        DEX = 11;
                        CON = 15;
                        INT = 2;
                        WIS = 12;
                        CHA = 5;

                        passivePerception = 11;
                        CR = 3;

                        environments = "Grassland";

                        break;

                    case "giantscorpion":

                        name = "Giant Scorpion";
                        size = "Large";

                        AC = 15;
                        HP = 52;
                        speed = 40;

                        STR = 15;
                        DEX = 13;
                        CON = 15;
                        INT = 1;
                        WIS = 9;
                        CHA = 3;

                        senses = "Blindsight 60 ft.";
                        passivePerception = 9;
                        CR = 3;

                        environments = "Desert";

                        break;

                    case "killerwhale":
                    case "whale":

                        name = "Killer Whale";
                        size = "Huge";

                        AC = 12;
                        HP = 90;
                        speed = 0;
                        swim = 60;

                        STR = 19;
                        DEX = 10;
                        CON = 13;
                        INT = 3;
                        WIS = 12;
                        CHA = 7;

                        perception = 3;
                        senses = "Blindsight 120 ft.";
                        passivePerception = 13;
                        CR = 3;

                        traits = "Echolocation -- Hold Breath -- Keen Hearing --";

                        environments = "Underwater";

                        break;

                    case "allosaurus":
                    case "allo":

                        name = "Allosaurus";
                        size = "Large";
                        tag = "Dinosaur";

                        AC = 13;
                        HP = 51;
                        speed = 60;

                        STR = 19;
                        DEX = 13;
                        CON = 17;
                        INT = 2;
                        WIS = 12;
                        CHA = 5;

                        perception = 5;
                        passivePerception = 15;
                        CR = 2;

                        traits = "Pounce --";

                        environments = "Grassland";

                        break;

                    case "giantboar":

                        name = "Giant Boar";
                        size = "Large";

                        AC = 12;
                        HP = 42;
                        speed = 40;

                        STR = 17;
                        DEX = 10;
                        CON = 16;
                        INT = 2;
                        WIS = 7;
                        CHA = 5;

                        passivePerception = 8;
                        CR = 2;

                        traits = "Charge -- Relentless --";

                        environments = "Forest, Grassland, Hill";

                        break;

                    case "giantconstrictorsnake":
                    case "giantconstrictor":
                    case "gcs":

                        name = "Giant Constrictor Snake";
                        size = "Huge";

                        AC = 12;
                        HP = 60;
                        speed = 30;
                        swim = 30;

                        STR = 19;
                        DEX = 14;
                        CON = 12;
                        INT = 1;
                        WIS = 10;
                        CHA = 3;

                        perception = 2;
                        senses = "Blindsight 10 ft.";
                        passivePerception = 12;
                        CR = 2;

                        environments = "Desert, Forest, Swamp, Underdark, Underwater";

                        break;

                    case "giantelk":

                        name = "Giant Elk";
                        size = "Huge";

                        AC = 14;
                        HP = 42;
                        speed = 60;

                        STR = 19;
                        DEX = 16;
                        CON = 14;
                        INT = 7;
                        WIS = 14;
                        CHA = 10;

                        perception = 4;
                        passivePerception = 14;
                        languages = "understands Common, Elvish, and Sylvan but can't speak them";
                        CR = 2;

                        traits = "Charge --";

                        environments = "Forest, Grassland, Hill, Mountain";

                        break;

                    case "huntershark":
                    case "hunter":

                        name = "Hunter Shark";
                        size = "Large";

                        AC = 12;
                        HP = 45;
                        speed = 0;
                        swim = 40;

                        STR = 18;
                        DEX = 13;
                        CON = 15;
                        INT = 1;
                        WIS = 10;
                        CHA = 4;

                        perception = 2;
                        senses = "Blindsight 30 ft.";
                        passivePerception = 12;
                        CR = 2;

                        traits = "Blood Frenzy -- Water Breathing --";

                        environments = "Underwater";

                        break;

                    case "plesiosaurus":
                    case "plesio":

                        name = "Plesiosaurus";
                        size = "Large";
                        tag = "Dinosaur";

                        AC = 13;
                        HP = 68;
                        speed = 20;
                        swim = 40;

                        STR = 18;
                        DEX = 15;
                        CON = 16;
                        INT = 2;
                        WIS = 12;
                        CHA = 5;

                        perception = 3;
                        stealth = 4;
                        passivePerception = 13;
                        CR = 2;

                        traits = "Hold Breath. The plesiosaurus can hold its breath for 1 hour.";

                        environments = "Coastal, Underwater";

                        break;

                    case "polarbear":

                        name = "Polar Bear";
                        size = "Large";

                        AC = 12;
                        HP = 42;
                        speed = 40;
                        swim = 30;

                        STR = 20;
                        DEX = 10;
                        CON = 16;
                        INT = 2;
                        WIS = 13;
                        CHA = 7;

                        perception = 3;
                        passivePerception = 13;
                        CR = 2;

                        traits = "Keen Smell. The bear has advantage on Wisdom (Perception) checks that rely on smell.";

                        environments = "Arctic, Underdark";

                        break;

                    case "rhinoceros":
                    case "rhino":

                        name = "Rhinoceros";
                        size = "Large";

                        AC = 11;
                        HP = 45;
                        speed = 40;

                        STR = 21;
                        DEX = 8;
                        CON = 15;
                        INT = 2;
                        WIS = 12;
                        CHA = 6;

                        passivePerception = 11;
                        CR = 2;

                        traits = "Charge --";

                        environments = "Grassland";

                        break;

                    case "saber-toothedtiger":
                    case "saber-tooth":
                    case "sabertooth":
                    case "saber":

                        name = "Saber-Toothed Tiger";
                        size = "Large";

                        AC = 12;
                        HP = 52;
                        speed = 40;

                        STR = 18;
                        DEX = 14;
                        CON = 15;
                        INT = 3;
                        WIS = 12;
                        CHA = 8;

                        perception = 3;
                        stealth = 6;
                        passivePerception = 13;
                        CR = 2;

                        traits = "Keen Smell -- Pounce --";

                        environments = "Arctic, Mountain";

                        break;

                    case "brownbear":

                        name = "Brown Bear";
                        size = "Large";

                        AC = 11;
                        HP = 34;
                        speed = 40;
                        climb = 30;

                        STR = 19;
                        DEX = 10;
                        CON = 16;
                        INT = 2;
                        WIS = 13;
                        CHA = 7;

                        perception = 3;
                        passivePerception = 13;
                        CR = 1;

                        traits = "Keen Smell. The bear has advantage on Wisdom (Perception) checks that rely on smell.";

                        environments = "Arctic, Forest, Hill";

                        break;

                    case "direwolf":
                    case "dire":

                        name = "Dire Wolf";
                        size = "Large";

                        AC = 14;
                        HP = 37;
                        speed = 50;

                        STR = 17;
                        DEX = 15;
                        CON = 15;
                        INT = 3;
                        WIS = 12;
                        CHA = 7;

                        perception = 3;
                        stealth = 4;
                        passivePerception = 13;
                        CR = 1;

                        traits = "Keen Hearing and Smell -- Pack Tactics --";

                        environments = "Forest, Hill";

                        break;

                    case "gianteagle":

                        name = "Giant Eagle";
                        size = "Large";

                        AC = 13;
                        HP = 26;
                        speed = 10;
                        fly = 80;

                        STR = 16;
                        DEX = 17;
                        CON = 13;
                        INT = 8;
                        WIS = 14;
                        CHA = 10;

                        perception = 4;
                        passivePerception = 14;
                        languages = "understands Common and Auran but can't speak them";
                        CR = 1;

                        traits = "Keen Sight. The eagle has advantage on Wisdom (Perception) checks that rely on sight.";

                        environments = "Coastal, Grassland, Hill, Mountain";

                        break;

                    case "gianthyena":

                        name = "Giant Hyena";
                        size = "Large";

                        AC = 12;
                        HP = 45;
                        speed = 50;

                        STR = 16;
                        DEX = 14;
                        CON = 14;
                        INT = 2;
                        WIS = 12;
                        CHA = 7;

                        perception = 3;
                        passivePerception = 13;
                        CR = 1;

                        traits = "Rampage --";

                        environments = "Desert, Forest, Grassland, Hill";

                        break;

                    case "giantoctopus":

                        name = "Giant Octopus";
                        size = "Large";

                        AC = 11;
                        HP = 52;
                        speed = 10;
                        swim = 60;

                        STR = 17;
                        DEX = 13;
                        CON = 13;
                        INT = 4;
                        WIS = 10;
                        CHA = 4;

                        perception = 4;
                        stealth = 5;
                        senses = "Darkvision 60 ft.";
                        passivePerception = 14;
                        CR = 1;

                        traits = "Hold Breath -- Underwater Camouflage -- Water Breathing --";

                        environments = "Underwater";

                        break;

                    case "giantspider":

                        name = "Giant Spider";
                        size = "Large";

                        AC = 14;
                        HP = 26;
                        speed = 30;
                        climb = 30;

                        STR = 14;
                        DEX = 16;
                        CON = 12;
                        INT = 2;
                        WIS = 11;
                        CHA = 4;

                        stealth = 7;
                        senses = "Blindsight 10 ft., Darkvision 60 ft.";
                        passivePerception = 10;
                        CR = 1;

                        traits = "Spider Climb -- Web Sense -- Web Walker --";

                        environments = "Desert, Forest, Swamp, Underdark, Urban";

                        break;

                    case "gianttoad":

                        name = "Giant Toad";
                        size = "Large";

                        AC = 11;
                        HP = 39;
                        speed = 20;
                        swim = 40;

                        STR = 15;
                        DEX = 13;
                        CON = 13;
                        INT = 2;
                        WIS = 10;
                        CHA = 3;

                        senses = "Darkvision 30 ft.";
                        passivePerception = 10;
                        CR = 1;

                        traits = "Amphibious -- Standing Leap --";

                        environments = "Coastal, Desert, Forest, Swamp, Underdark";

                        break;

                    case "giantvulture":

                        name = "Giant Vulture";
                        size = "Large";

                        AC = 10;
                        HP = 22;
                        speed = 10;
                        fly = 60;

                        STR = 15;
                        DEX = 10;
                        CON = 15;
                        INT = 6;
                        WIS = 12;
                        CHA = 7;

                        perception = 3;
                        passivePerception = 13;
                        languages = "understands Common but can't speak it";
                        CR = 1;

                        traits = "Keen Sight and Smell -- Pack Tactics --";

                        environments = "Desert, Grassland";

                        break;

                    case "lion":

                        name = "Lion";
                        size = "Large";

                        AC = 12;
                        HP = 26;
                        speed = 50;

                        STR = 17;
                        DEX = 15;
                        CON = 13;
                        INT = 3;
                        WIS = 12;
                        CHA = 8;

                        perception = 3;
                        stealth = 6;
                        passivePerception = 13;
                        CR = 1;

                        traits = "Keen Smell -- Pack Tactics -- Pounce -- Running Leap --";

                        environments = "Desert, Grassland, Hill, Mountain";

                        break;

                    case "oldcroacker":
                    case "oldcroaker":
                    case "croacker":
                    case "croaker":

                        name = "Old Croaker";
                        size = "Large";

                        AC = 11;
                        HP = 39;
                        speed = 20;
                        swim = 40;

                        STR = 15;
                        DEX = 13;
                        CON = 13;
                        INT = 2;
                        WIS = 10;
                        CHA = 3;

                        senses = "Darkvision 30 ft.";
                        passivePerception = 10;
                        CR = 1;

                        traits = $"Amphibious -- Standing Leap --{"\n"}{"\n"}DMG Immunities: Cold";

                        environments = "Coastal, Desert, Forest, Swamp, Underdark";

                        break;

                    case "tiger":

                        name = "Tiger";
                        size = "Large";

                        AC = 12;
                        HP = 37;
                        speed = 40;

                        STR = 17;
                        DEX = 15;
                        CON = 14;
                        INT = 3;
                        WIS = 12;
                        CHA = 8;

                        perception = 3;
                        stealth = 6;
                        senses = "Darkvision 60 ft.";
                        passivePerception = 13;
                        CR = 1;

                        traits = "Keen Smell -- Pounce --";

                        environments = "Forest, Grassland";

                        break;

                    case "ape":

                        name = "Ape";
                        size = "Medium";

                        AC = 12;
                        HP = 19;
                        speed = 30;
                        climb = 30;

                        STR = 16;
                        DEX = 14;
                        CON = 14;
                        INT = 6;
                        WIS = 12;
                        CHA = 7;

                        athletics = 5;
                        perception = 3;
                        passivePerception = 13;
                        CR = 0.5;

                        environments = "Forest";

                        break;

                    case "blackbear":

                        name = "Black Bear";
                        size = "Medium";

                        AC = 11;
                        HP = 19;
                        speed = 40;
                        climb = 30;

                        STR = 15;
                        DEX = 10;
                        CON = 14;
                        INT = 2;
                        WIS = 12;
                        CHA = 7;

                        perception = 3;
                        passivePerception = 13;
                        CR = 0.5;

                        traits = "Keen Smell. The bear has advantage on Wisdom (Perception) checks that rely on smell.";

                        environments = "Forest";

                        break;

                    case "crocodile":
                    case "croc":

                        name = "Crocodile";
                        size = "Large";

                        AC = 12;
                        HP = 19;
                        speed = 20;
                        swim = 30;

                        STR = 15;
                        DEX = 10;
                        CON = 13;
                        INT = 2;
                        WIS = 10;
                        CHA = 5;

                        stealth = 2;
                        passivePerception = 10;
                        CR = 0.5;

                        traits = "Hold Breath. The crocodile can hold its breath for 15 minutes.";

                        environments = "Swamp, Urban";

                        break;

                    case "giantgoat":

                        name = "Giant Goat";
                        size = "Large";

                        AC = 11;
                        HP = 19;
                        speed = 40;

                        STR = 17;
                        DEX = 11;
                        CON = 12;
                        INT = 3;
                        WIS = 12;
                        CHA = 6;

                        passivePerception = 11;
                        CR = 0.5;

                        traits = "Charge -- Sure-Footed --";

                        environments = "Grassland, Hill, Mountain";

                        break;

                    case "giantseahorse":

                        name = "Giant Sea Horse";
                        size = "Large";

                        AC = 13;
                        HP = 16;
                        speed = 0;
                        swim = 40;

                        STR = 12;
                        DEX = 15;
                        CON = 11;
                        INT = 2;
                        WIS = 12;
                        CHA = 5;

                        passivePerception = 11;
                        CR = 0.5;

                        traits = "Charge -- Water Breathing --";

                        environments = "Underwater";

                        break;

                    case "giantwasp":

                        name = "Giant Wasp";
                        size = "Medium";

                        AC = 12;
                        HP = 13;
                        speed = 10;
                        fly = 50;

                        STR = 10;
                        DEX = 14;
                        CON = 10;
                        INT = 1;
                        WIS = 10;
                        CHA = 3;

                        passivePerception = 10;
                        CR = 0.5;

                        environments = "Forest, Grassland, Urban";

                        break;

                    case "reefshark":

                        name = "Reef Shark";
                        size = "Medium";

                        AC = 12;
                        HP = 22;
                        speed = 0;
                        swim = 40;

                        STR = 14;
                        DEX = 13;
                        CON = 13;
                        INT = 1;
                        WIS = 10;
                        CHA = 4;

                        perception = 2;
                        senses = "Blindsight 30 ft.";
                        passivePerception = 12;
                        CR = 0.5;

                        traits = "Pack Tactics -- Water Breathing --";

                        environments = "Underwater";

                        break;

                    case "warhorse":

                        name = "Warhorse";
                        size = "Large";

                        AC = 11;
                        HP = 19;
                        speed = 60;

                        STR = 18;
                        DEX = 12;
                        CON = 13;
                        INT = 2;
                        WIS = 12;
                        CHA = 7;

                        passivePerception = 11;
                        CR = 0.5;

                        traits = "Trampling Charge --";

                        environments = "Urban";

                        break;

                    case "axebeak":

                        name = "Axe Beak";
                        size = "Large";

                        AC = 11;
                        HP = 19;
                        speed = 50;

                        STR = 14;
                        DEX = 12;
                        CON = 12;
                        INT = 2;
                        WIS = 10;
                        CHA = 5;

                        passivePerception = 10;
                        CR = 0.25;

                        environments = "Grassland, Hill";

                        break;

                    case "boar":

                        name = "Boar";
                        size = "Medium";

                        AC = 11;
                        HP = 11;
                        speed = 40;

                        STR = 13;
                        DEX = 11;
                        CON = 12;
                        INT = 2;
                        WIS = 9;
                        CHA = 5;

                        passivePerception = 9;
                        CR = 0.25;

                        traits = "Charge -- Relentless --";

                        environments = "Forest, Grassland, Hill";

                        break;

                    case "constrictorsnake":
                    case "constrictor":

                        name = "Constrictor Snake";
                        size = "Large";

                        AC = 12;
                        HP = 13;
                        speed = 30;
                        swim = 30;

                        STR = 15;
                        DEX = 14;
                        CON = 12;
                        INT = 1;
                        WIS = 10;
                        CHA = 3;

                        senses = "Blindsight 10 ft.";
                        passivePerception = 10;
                        CR = 0.25;

                        environments = "Desert, Forest, Swamp, Underwater";

                        break;

                    case "drafthorse":

                        name = "Draft Horse";
                        size = "Large";

                        AC = 10;
                        HP = 19;
                        speed = 40;

                        STR = 18;
                        DEX = 10;
                        CON = 12;
                        INT = 2;
                        WIS = 11;
                        CHA = 7;

                        passivePerception = 10;
                        CR = 0.25;

                        environments = "Urban";

                        break;

                    case "elk":

                        name = "Elk";
                        size = "Large";

                        AC = 10;
                        HP = 13;
                        speed = 50;

                        STR = 16;
                        DEX = 10;
                        CON = 12;
                        INT = 2;
                        WIS = 10;
                        CHA = 6;

                        passivePerception = 10;
                        CR = 0.25;

                        traits = "Charge --";

                        environments = "Forest, Grassland, Hill";

                        break;

                    case "giantbadger":

                        name = "Giant Badger";
                        size = "Medium";

                        AC = 10;
                        HP = 13;
                        speed = 30;
                        burrow = 10;

                        STR = 13;
                        DEX = 10;
                        CON = 15;
                        INT = 2;
                        WIS = 12;
                        CHA = 5;

                        senses = "Darkvision 30 ft.";
                        passivePerception = 11;
                        CR = 0.25;

                        traits = "Keen Smell. The badger has advantage on Wisdom (Perception) checks that rely on smell.";

                        environments = "Forest";

                        break;

                    case "giantbat":

                        name = "Giant Bat";
                        size = "Large";

                        AC = 13;
                        HP = 22;
                        speed = 10;
                        fly = 60;

                        STR = 15;
                        DEX = 16;
                        CON = 11;
                        INT = 2;
                        WIS = 12;
                        CHA = 6;

                        senses = "Blindsight 60 ft.";
                        passivePerception = 11;
                        CR = 0.25;

                        traits = "Echolocation -- Keen Hearing --";

                        environments = "Forest, Underdark";

                        break;

                    case "giantcentipede":
                    case "centipede":

                        name = "Giant Centipede";
                        size = "Small";

                        AC = 13;
                        HP = 4;
                        speed = 30;
                        climb = 30;

                        STR = 5;
                        DEX = 14;
                        CON = 12;
                        INT = 1;
                        WIS = 7;
                        CHA = 3;

                        senses = "Blindsight 30 ft.";
                        passivePerception = 8;
                        CR = 0.25;

                        environments = "Underdark, Urban";

                        break;

                    case "giantfrog":

                        name = "Giant Frog";
                        size = "Medium";

                        AC = 11;
                        HP = 18;
                        speed = 30;
                        swim = 30;

                        STR = 12;
                        DEX = 13;
                        CON = 11;
                        INT = 2;
                        WIS = 10;
                        CHA = 3;

                        perception = 2;
                        stealth = 3;
                        senses = "Darkvision 30 ft.";
                        passivePerception = 12;
                        CR = 0.25;

                        traits = "Amphibious -- Standing Leap --";

                        environments = "Forest, Swamp";

                        break;

                    case "giantlizard":

                        name = "Giant Lizard";
                        size = "Large";

                        AC = 12;
                        HP = 19;
                        speed = 30;
                        climb = 30;

                        STR = 15;
                        DEX = 12;
                        CON = 13;
                        INT = 2;
                        WIS = 10;
                        CHA = 5;

                        senses = "Darkvision 30 ft.";
                        passivePerception = 10;
                        CR = 0.25;

                        environments = "Coastal, Desert, Forest, Swamp, Underdark";

                        break;

                    case "giantowl":

                        name = "Giant Owl";
                        size = "Large";

                        AC = 12;
                        HP = 19;
                        speed = 5;
                        fly = 60;

                        STR = 13;
                        DEX = 15;
                        CON = 12;
                        INT = 8;
                        WIS = 13;
                        CHA = 10;

                        perception = 5;
                        stealth = 4;
                        senses = "Darkvision 120 ft.";
                        passivePerception = 15;
                        languages = "understands Common, Elvish, and Sylvan but can’t speak them";
                        CR = 0.25;

                        traits = "Flyby -- Keen Hearing and Sight --";

                        environments = "Arctic, Forest, Hill";

                        break;

                    case "giantpoisonoussnake":
                    case "gps":

                        name = "Giant Poisonous Snake";
                        size = "Medium";

                        AC = 14;
                        HP = 11;
                        speed = 30;
                        swim = 30;

                        STR = 10;
                        DEX = 18;
                        CON = 13;
                        INT = 2;
                        WIS = 10;
                        CHA = 3;

                        perception = 2;
                        senses = "Blindsight 10 ft.";
                        passivePerception = 12;
                        CR = 0.25;

                        environments = "Desert, Forest, Grassland, Swamp, Underdark, Urban";

                        break;

                    case "giantwolfspider":
                    case "wolfspider":
                    case "gws":

                        name = "Giant Wolf Spider";
                        size = "Medium";

                        AC = 13;
                        HP = 11;
                        speed = 40;
                        climb = 40;

                        STR = 12;
                        DEX = 16;
                        CON = 13;
                        INT = 3;
                        WIS = 12;
                        CHA = 4;

                        perception = 3;
                        stealth = 7;
                        senses = "Blindsight 10 ft., Darkvision 60 ft.";
                        passivePerception = 13;
                        CR = 0.25;

                        traits = "Spider Climb -- Web Sense -- Web Walker --";

                        environments = "Coastal, Desert, Forest, Grassland, Hill";

                        break;

                    case "panther":

                        name = "Panther";
                        size = "Medium";

                        AC = 12;
                        HP = 13;
                        speed = 50;
                        climb = 40;

                        STR = 14;
                        DEX = 15;
                        CON = 10;
                        INT = 3;
                        WIS = 14;
                        CHA = 7;

                        perception = 4;
                        stealth = 6;
                        passivePerception = 14;
                        CR = 0.25;

                        traits = "Keen Smell -- Pounce --";

                        environments = "Forest, Grassland, Hill";

                        break;

                    case "pteranodon":
                    case "ptera":

                        name = "Pteranodon";
                        size = "Medium";
                        tag = "Dinosaur";

                        AC = 13;
                        HP = 13;
                        speed = 10;
                        fly = 60;

                        STR = 12;
                        DEX = 15;
                        CON = 10;
                        INT = 2;
                        WIS = 9;
                        CHA = 5;

                        perception = 1;
                        passivePerception = 11;
                        CR = 0.25;

                        traits = "Flyby. The pteranodon doesn’t provoke an opportunity attack when it flies out of an enemy’s reach.";

                        environments = "Coastal, Grassland, Mountain";

                        break;

                    case "ridinghorse":

                        name = "Riding Horse";
                        size = "Large";

                        AC = 10;
                        HP = 13;
                        speed = 60;

                        STR = 16;
                        DEX = 10;
                        CON = 12;
                        INT = 2;
                        WIS = 11;
                        CHA = 7;

                        passivePerception = 10;
                        CR = 0.25;

                        environments = "Grassland, Urban";

                        break;

                    case "wolf":

                        name = "Wolf";
                        size = "Medium";

                        AC = 13;
                        HP = 11;
                        speed = 40;

                        STR = 12;
                        DEX = 15;
                        CON = 12;
                        INT = 3;
                        WIS = 12;
                        CHA = 6;

                        perception = 3;
                        stealth = 4;
                        passivePerception = 13;
                        CR = 0.25;

                        traits = "Keen Hearing and Smell -- Pack Tactics --";

                        environments = "Forest, Grassland, Hill";

                        break;

                    case "bloodhawk":

                        name = "Blood Hawk";
                        size = "Small";

                        AC = 12;
                        HP = 7;
                        speed = 10;
                        fly = 60;

                        STR = 6;
                        DEX = 14;
                        CON = 10;
                        INT = 3;
                        WIS = 14;
                        CHA = 5;

                        perception = 4;
                        passivePerception = 14;
                        CR = 0.125;

                        traits = "Keen Sight -- Pack Tactics --";

                        environments = "Arctic, Coastal, Forest, Grassland, Hill, Mountain";

                        break;

                    case "camel":

                        name = "Camel";
                        size = "Large";

                        AC = 9;
                        HP = 15;
                        speed = 50;

                        STR = 16;
                        DEX = 8;
                        CON = 14;
                        INT = 2;
                        WIS = 8;
                        CHA = 5;

                        passivePerception = 9;
                        CR = 0.125;

                        environments = "Desert";

                        break;

                    case "flyingsnake":

                        name = "Flying Snake";
                        size = "Tiny";

                        AC = 14;
                        HP = 5;
                        speed = 30;
                        fly = 60;
                        swim = 30;

                        STR = 4;
                        DEX = 18;
                        CON = 11;
                        INT = 2;
                        WIS = 12;
                        CHA = 5;

                        senses = "Blindsight 10 ft.";
                        passivePerception = 11;
                        CR = 0.125;

                        traits = "Flyby. The snake doesn't provoke opportunity attacks when it flies out of an enemy's reach.";

                        environments = "Desert, Forest, Grassland, Urban";

                        break;

                    case "giantcrab":

                        name = "Giant Crab";
                        size = "Medium";

                        AC = 15;
                        HP = 13;
                        speed = 30;
                        swim = 30;

                        STR = 13;
                        DEX = 15;
                        CON = 11;
                        INT = 1;
                        WIS = 9;
                        CHA = 3;

                        stealth = 4;
                        senses = "Blindsight 30 ft.";
                        passivePerception = 9;
                        CR = 0.125;

                        traits = "Amphibious. The crab can breathe air and water.";

                        environments = "Coastal";

                        break;

                    case "giantrat":

                        name = "Giant Rat";
                        size = "Small";

                        AC = 12;
                        HP = 7;
                        speed = 30;

                        STR = 7;
                        DEX = 15;
                        CON = 11;
                        INT = 2;
                        WIS = 10;
                        CHA = 4;

                        senses = "Darkvision 60 ft.";
                        passivePerception = 10;
                        CR = 0.125;

                        traits = "Keen Smell -- Pack Tactics --";

                        environments = "Forest, Swamp, Underdark, Urban";

                        break;

                    case "giantweasel":

                        name = "Giant Weasel";
                        size = "Medium";

                        AC = 13;
                        HP = 9;
                        speed = 40;

                        STR = 11;
                        DEX = 16;
                        CON = 10;
                        INT = 4;
                        WIS = 12;
                        CHA = 5;

                        perception = 3;
                        stealth = 5;
                        senses = "Darkvision 60 ft.";
                        passivePerception = 13;
                        CR = 0.125;

                        traits = "Keen Hearing and Smell. The weasel has advantage on Wisdom (Perception) checks that rely on hearing or smell.";

                        environments = "Forest, Grassland, Hill";

                        break;

                    case "mastiff":
                    case "mastif":

                        name = "Mastiff";
                        size = "Medium";

                        AC = 12;
                        HP = 5;
                        speed = 40;

                        STR = 13;
                        DEX = 14;
                        CON = 12;
                        INT = 3;
                        WIS = 12;
                        CHA = 7;

                        perception = 3;
                        passivePerception = 13;
                        CR = 0.125;

                        traits = "Keen Hearing and Smell. The mastiff has advantage on Wisdom (Perception) checks that rely on hearing or smell.";

                        environments = "Forest, Hill, Urban";

                        break;

                    case "mule":

                        name = "Mule";
                        size = "Medium";

                        AC = 10;
                        HP = 11;
                        speed = 40;

                        STR = 14;
                        DEX = 10;
                        CON = 13;
                        INT = 2;
                        WIS = 10;
                        CHA = 5;

                        passivePerception = 10;
                        CR = 0.125;

                        traits = "Beast of Burden -- Sure-Footed --";

                        environments = "Desert, Hill, Urban";

                        break;

                    case "poisonoussnake":

                        name = "Poisonous Snake";
                        size = "Tiny";

                        AC = 13;
                        HP = 2;
                        speed = 30;
                        swim = 30;

                        STR = 2;
                        DEX = 16;
                        CON = 11;
                        INT = 1;
                        WIS = 10;
                        CHA = 3;

                        senses = "Blindsight 10 ft.";
                        passivePerception = 10;
                        CR = 0.125;

                        environments = "Coastal, Desert, Forest, Grassland, Hill, Swamp";

                        break;

                    case "pony":

                        name = "Pony";
                        size = "Medium";

                        AC = 10;
                        HP = 11;
                        speed = 40;

                        STR = 15;
                        DEX = 10;
                        CON = 13;
                        INT = 2;
                        WIS = 11;
                        CHA = 7;

                        passivePerception = 10;
                        CR = 0.125;

                        environments = "Urban";

                        break;

                    case "stirge":
                    case "strigoi":

                        name = "Stirge";
                        size = "Tiny";

                        AC = 14;
                        HP = 2;
                        speed = 10;
                        fly = 40;

                        STR = 4;
                        DEX = 16;
                        CON = 11;
                        INT = 2;
                        WIS = 8;
                        CHA = 6;

                        senses = "Darkvision 60 ft.";
                        passivePerception = 9;
                        CR = 0.125;

                        environments = "Coastal, Desert, Forest, Grassland, Hill, Mountain, Swamp, Underdark, Urban";

                        break;

                    case "baboon":

                        name = "Baboon";
                        size = "Small";

                        AC = 12;
                        HP = 3;
                        speed = 30;
                        climb = 30;

                        STR = 8;
                        DEX = 14;
                        CON = 11;
                        INT = 4;
                        WIS = 12;
                        CHA = 6;

                        passivePerception = 11;
                        CR = 0;

                        traits = "Pack Tactics. The baboon has advantage on an attack roll against a creature if at least one of the baboon's allies is within 5 feet of the creature and the ally isn't incapacitated.";

                        environments = "Forest, Hill";

                        break;

                    case "badger":

                        name = "Badger";
                        size = "Tiny";

                        AC = 10;
                        HP = 3;
                        speed = 20;
                        burrow = 5;

                        STR = 4;
                        DEX = 11;
                        CON = 12;
                        INT = 2;
                        WIS = 12;
                        CHA = 5;

                        senses = "Darkvision 30 ft.";
                        passivePerception = 11;
                        CR = 0;

                        traits = "Keen Smell. The badger has advantage on Wisdom (Perception) checks that rely on smell.";

                        environments = "Forest";

                        break;

                    case "bat":

                        name = "Bat";
                        size = "Tiny";

                        AC = 12;
                        HP = 1;
                        speed = 5;
                        fly = 30;

                        STR = 2;
                        DEX = 15;
                        CON = 8;
                        INT = 2;
                        WIS = 12;
                        CHA = 4;

                        senses = "Blindsight 60 ft.";
                        passivePerception = 11;
                        CR = 0;

                        traits = "Echolocation -- Keen Hearing --";

                        break;

                    case "cat":

                        name = "Cat";
                        size = "Tiny";

                        AC = 12;
                        HP = 2;
                        speed = 40;
                        climb = 30;

                        STR = 3;
                        DEX = 15;
                        CON = 10;
                        INT = 3;
                        WIS = 12;
                        CHA = 7;

                        perception = 3;
                        stealth = 4;
                        passivePerception = 13;
                        CR = 0;

                        traits = "Keen Smell. The cat has advantage on Wisdom (Perception) checks that rely on smell.";

                        environments = "Desert, Forest, Grassland, Urban";

                        break;

                    case "crab":

                        name = "Crab";
                        size = "Tiny";

                        AC = 11;
                        HP = 2;
                        speed = 20;
                        swim = 20;

                        STR = 2;
                        DEX = 11;
                        CON = 10;
                        INT = 1;
                        WIS = 8;
                        CHA = 2;

                        stealth = 2;
                        senses = "Blindsight 30 ft.";
                        passivePerception = 9;
                        CR = 0;

                        traits = "Amphibious. The crab can breathe air and water.";

                        environments = "Coastal";

                        break;

                    case "deer":

                        name = "Deer";
                        size = "Medium";

                        AC = 13;
                        HP = 4;
                        speed = 50;

                        STR = 11;
                        DEX = 16;
                        CON = 11;
                        INT = 2;
                        WIS = 14;
                        CHA = 5;

                        passivePerception = 12;
                        CR = 0;

                        environments = "Forest, Grassland";

                        break;

                    case "eagle":

                        name = "Eagle";
                        size = "Small";

                        AC = 12;
                        HP = 3;
                        speed = 10;
                        fly = 60;

                        STR = 6;
                        DEX = 15;
                        CON = 10;
                        INT = 2;
                        WIS = 14;
                        CHA = 7;

                        perception = 4;
                        passivePerception = 14;
                        CR = 0;

                        traits = "Keen Sight. The eagle has advantage on Wisdom (Perception) checks that rely on sight.";

                        environments = "Coastal, Grassland, Hill, Mountain";

                        break;

                    case "frog":

                        name = "Frog";
                        size = "Tiny";

                        AC = 11;
                        HP = 1;
                        speed = 20;
                        swim = 20;

                        STR = 1;
                        DEX = 13;
                        CON = 8;
                        INT = 1;
                        WIS = 8;
                        CHA = 3;

                        perception = 1;
                        stealth = 3;
                        senses = "Darkvision 30 ft.";
                        passivePerception = 11;
                        CR = 0;

                        traits = "Amphibious -- Standing Leap --";

                        break;

                    case "giantfirebeetle":
                    case "giantbeetle":
                    case "firebeetle":
                    case "beetle":

                        name = "Giant Fire Beetle";
                        size = "Small";

                        AC = 13;
                        HP = 4;
                        speed = 30;

                        STR = 8;
                        DEX = 10;
                        CON = 12;
                        INT = 1;
                        WIS = 7;
                        CHA = 3;

                        senses = "Blindsight 30 ft.";
                        passivePerception = 8;
                        CR = 0;

                        traits = "Illumination. The beetle sheds bright light in a 10-foot radius and dim light for an additional 10 feet.";

                        environments = "Underdark";

                        break;

                    case "goat":

                        name = "Goat";
                        size = "Medium";

                        AC = 10;
                        HP = 4;
                        speed = 40;

                        STR = 12;
                        DEX = 10;
                        CON = 11;
                        INT = 2;
                        WIS = 10;
                        CHA = 5;

                        passivePerception = 10;
                        CR = 0;

                        traits = "Charge -- Sure-Footed --";

                        environments = "Grassland, Hill, Mountain, Urban";

                        break;

                    case "hawk":

                        name = "Hawk";
                        size = "Tiny";

                        AC = 13;
                        HP = 1;
                        speed = 10;
                        fly = 60;

                        STR = 5;
                        DEX = 16;
                        CON = 8;
                        INT = 2;
                        WIS = 14;
                        CHA = 6;

                        perception = 4;
                        passivePerception = 14;
                        CR = 0;

                        traits = "Keen Sight. The hawk has advantage on Wisdom (Perception) checks that rely on sight.";

                        break;

                    case "hyena":

                        name = "Hyena";
                        size = "Medium";

                        AC = 11;
                        HP = 5;
                        speed = 50;

                        STR = 11;
                        DEX = 13;
                        CON = 12;
                        INT = 2;
                        WIS = 12;
                        CHA = 5;

                        perception = 3;
                        passivePerception = 13;
                        CR = 0;

                        traits = "Pack Tactics. The hyena has advantage on an attack roll against a creature if at least one of the hyena's allies is within 5 feet of the creature and the ally isn't incapacitated.";

                        environments = "Desert, Forest, Grassland, Hill";

                        break;

                    case "jackal":

                        name = "Jackal";
                        size = "Small";

                        AC = 12;
                        HP = 3;
                        speed = 40;

                        STR = 8;
                        DEX = 15;
                        CON = 11;
                        INT = 3;
                        WIS = 12;
                        CHA = 6;

                        perception = 3;
                        passivePerception = 13;
                        CR = 0;

                        traits = "Keen Hearing and Smell -- Pack Tactics --";

                        environments = "Desert, Grassland";

                        break;

                    case "lizard":

                        name = "Lizard";
                        size = "Tiny";

                        AC = 10;
                        HP = 2;
                        speed = 20;
                        climb = 20;

                        STR = 2;
                        DEX = 11;
                        CON = 10;
                        INT = 1;
                        WIS = 8;
                        CHA = 3;

                        senses = "Darkvision 30 ft.";
                        passivePerception = 9;
                        CR = 0;

                        break;

                    case "octopus":

                        name = "Octopus";
                        size = "Small";

                        AC = 12;
                        HP = 3;
                        speed = 5;
                        swim = 30;

                        STR = 4;
                        DEX = 15;
                        CON = 11;
                        INT = 3;
                        WIS = 10;
                        CHA = 4;

                        perception = 2;
                        stealth = 4;
                        senses = "Darkvision 30 ft.";
                        passivePerception = 12;
                        CR = 0;

                        traits = "Hold Breath -- Underwater Camouflage -- Water Breathing --";

                        environments = "Underwater";

                        break;

                    case "owl":

                        name = "Owl";
                        size = "Tiny";

                        AC = 11;
                        HP = 1;
                        speed = 5;
                        fly = 60;

                        STR = 3;
                        DEX = 13;
                        CON = 8;
                        INT = 2;
                        WIS = 12;
                        CHA = 7;

                        perception = 3;
                        stealth = 3;
                        senses = "Darkvision 120 ft.";
                        passivePerception = 13;
                        CR = 0;

                        traits = "Flyby -- Keen Hearing and Sight --";

                        environments = "Arctic, Forest";

                        break;

                    case "quipper":
                    case "quiper":

                        name = "Quipper";
                        size = "Tiny";

                        AC = 13;
                        HP = 1;
                        speed = 0;
                        swim = 40;

                        STR = 2;
                        DEX = 16;
                        CON = 9;
                        INT = 1;
                        WIS = 7;
                        CHA = 2;

                        senses = "Darkvision 60 ft.";
                        passivePerception = 8;
                        CR = 0;

                        traits = "Blood Frenzy -- Water Breathing --";

                        environments = "Underwater";

                        break;

                    case "rat":

                        name = "Rat";
                        size = "Tiny";

                        AC = 10;
                        HP = 1;
                        speed = 20;

                        STR = 2;
                        DEX = 11;
                        CON = 9;
                        INT = 2;
                        WIS = 10;
                        CHA = 4;

                        senses = "Darkvision 30 ft.";
                        passivePerception = 10;
                        CR = 0;

                        traits = "Keen Smell. The rat has advantage on Wisdom (Perception) checks that rely on smell.";

                        environments = "Swamp, Urban";

                        break;

                    case "raven":

                        name = "Raven";
                        size = "Tiny";

                        AC = 12;
                        HP = 1;
                        speed = 10;
                        fly = 50;

                        STR = 2;
                        DEX = 14;
                        CON = 8;
                        INT = 2;
                        WIS = 12;
                        CHA = 6;

                        perception = 3;
                        passivePerception = 13;
                        CR = 0;

                        traits = $"Mimicry. The raven can mimic simple sounds it has heard, such as a person whispering, a baby crying, or an animal chittering.{"\n"}{"\n"}A creature that hears the sounds can tell they are imitations with a successful DC 10 Wisdom (Insight) check.";

                        environments = "Hill, Swamp, Urban";

                        break;

                    case "scorpion":

                        name = "Scorpion";
                        size = "Tiny";

                        AC = 11;
                        HP = 1;
                        speed = 10;

                        STR = 2;
                        DEX = 11;
                        CON = 8;
                        INT = 1;
                        WIS = 8;
                        CHA = 2;

                        senses = "Blindsight 10 ft.";
                        passivePerception = 9;
                        CR = 0;

                        environments = "Desert";

                        break;

                    case "seahorse":

                        name = "Sea Horse";
                        size = "Tiny";

                        AC = 11;
                        HP = 1;
                        speed = 0;
                        swim = 20;

                        STR = 1;
                        DEX = 12;
                        CON = 8;
                        INT = 1;
                        WIS = 10;
                        CHA = 2;

                        passivePerception = 10;
                        CR = 0;

                        traits = "Water Breathing. The sea horse can breathe only underwater.";

                        environments = "Underwater";

                        break;

                    case "spider":

                        name = "Spider";
                        size = "Tiny";

                        AC = 12;
                        HP = 1;
                        speed = 20;
                        climb = 20;

                        STR = 2;
                        DEX = 14;
                        CON = 8;
                        INT = 1;
                        WIS = 10;
                        CHA = 2;

                        stealth = 4;
                        senses = "Darkvision 30 ft.";
                        passivePerception = 10;
                        CR = 0;

                        traits = "Spider Climb -- Web Sense -- Web Walker --";

                        break;

                    case "vulture":

                        name = "Vulture";
                        size = "Medium";

                        AC = 10;
                        HP = 5;
                        speed = 10;
                        fly = 50;

                        STR = 7;
                        DEX = 10;
                        CON = 13;
                        INT = 2;
                        WIS = 12;
                        CHA = 4;

                        perception = 3;
                        passivePerception = 13;
                        CR = 0;

                        traits = "Keen Sight and Smell -- Pack Tactics --";

                        environments = "Desert, Grassland, Hill";

                        break;

                    case "weasel":

                        name = "Weasel";
                        size = "Tiny";

                        AC = 13;
                        HP = 1;
                        speed = 30;

                        STR = 3;
                        DEX = 16;
                        CON = 8;
                        INT = 2;
                        WIS = 12;
                        CHA = 3;

                        perception = 3;
                        stealth = 5;
                        passivePerception = 13;
                        CR = 0;

                        traits = "Keen Hearing and Smell. The weasel has advantage on Wisdom (Perception) checks that rely on hearing or smell.";

                        break;

                    default:
                        CR = -1;
                        break;
                }
                #endregion

                //sb.Append($"new MonsterDataModel {{ MonsterId = {ID}, Name = \"{monster}\", Size = \"{size}\", Type = \"Beast\", Alignment = \"Unaligned\", ArmorClass = {AC}, HitPoints = {HP}, WalkSpeed = {speed}, ");
                //if (burrow > -5) sb.Append($"BurrowSpeed = {burrow}, ");
                //if (climb > -5) sb.Append($"ClimbSpeed = {climb}, ");
                //if (fly > -5) sb.Append($"FlySpeed = {fly}, ");
                //if (swim > -5) sb.Append($"SwimSpeed = {swim}, ");
                //sb.Append($"Strength = {STR}, Dexterity = {DEX}, Constitution = {CON}, Intelligence = {INT}, Wisdom = {WIS}, Charisma = {CHA}, ");
                //sb.Append($"StrengthSavingThrow = {GetFrom(STR, STRst)}, Athletics = {GetFrom(STR, athletics)}, ");
                //sb.Append($"DexteritySavingThrow = {GetFrom(DEX, DEXst)}, Acrobatics = {GetFrom(DEX, acrobatics)}, SleightOfHand = {GetFrom(DEX, sleightOfHand)}, Stealth = {GetFrom(DEX, stealth)}, ");
                //sb.Append($"ConstitutionSavingThrow = {GetFrom(CON, CONst)}, ");
                //sb.Append($"IntelligenceSavingThrow = {GetFrom(INT, INTst)}, Arcana = {GetFrom(INT, arcana)}, History = {GetFrom(INT, history)}, Investigation = {GetFrom(INT, investigation)}, Nature = {GetFrom(INT, nature)}, Religion = {GetFrom(INT, religion)}, ");
                //sb.Append($"WisdomSavingThrow = {GetFrom(WIS, WISst)}, AnimalHandling = {GetFrom(WIS, animalHandling)}, Insight = {GetFrom(WIS, insight)}, Medicine = {GetFrom(WIS, medicine)}, Perception = {GetFrom(WIS, perception)}, Survival = {GetFrom(WIS, survival)}, ");
                //sb.Append($"CharismaSavingThrow = {GetFrom(CHA, CHAst)}, Deception = {GetFrom(CHA, deception)}, Intimidation = {GetFrom(CHA, intimidation)}, Performance = {GetFrom(CHA, performance)}, Persuasion = {GetFrom(CHA, persuasion)}, ");
                //sb.Append(GetFrom(senses, "Blindsight"));
                //sb.Append(GetFrom(senses, "Darkvision"));
                //sb.Append(GetFrom(senses, "Tremorsense"));
                //sb.Append(GetFrom(senses, "Truesight"));sb.Append($"ChallengeRating = {CR}, ");
                //sb.Append($"ProficiencyBonus = {GetProficiencyBonus(monster)}, ");
                //int i = Array.IndexOf(MonsterList.Monsters, monster) + 13;
                //if (i > 101) sb.Append($"CanSpeak = true }},");
                //else sb.Append($"CanSpeak = false }},");
                //Console.WriteLine(sb);
                //sb = new StringBuilder();

                // PARTIAL Traits
                // MonsterTraits
                if (traits != "null" && traits.Contains(" and "))
                {
                    Console.Write("\"");
                    if (traits.Contains("."))
                    {
                        int dot = traits.IndexOf(".");
                        string shortTrait = traits.Substring(0, dot);
                        Console.Write($"{ID},{shortTrait}");
                        //
                        //allTraits.Add(shortTrait);
                    }
                    else
                    {
                        Console.Write($"{ID},{traits.Substring(0, traits.Length - 3).Replace(" -- ", ",")}");
                        //
                        //foreach (string trait in traits.Substring(0, traits.Length - 3).Replace(" -- ", ",").Split(',')) allTraits.Add(trait);
                    }
                    Console.WriteLine("\",");
                }


                // MonsterEnvirons
                //string environs = environments.Replace(" ", "");
                //if (environs != "null") Console.WriteLine($"\"{ID},{environs}\",");

                // PARTIAL Environs
                //string[] currentEnvirons = environments.Replace(" ", "").Split(',');
                //foreach (string environ in currentEnvirons) allEnvirons.Add(environ);

                // MonsterLanguages
                //if (languages != "null") Console.WriteLine($"\"{ID},{languages}\",");

                // MonsterTags
                //if (tag != "null") Console.WriteLine($"\"{ID}, {tag}\",");
            }

            int x = 0;

            // PARTIAL Traits
            //foreach (string trait in allTraits.Distinct().OrderBy(y => y)) if (!trait.Contains(" and ")) Console.WriteLine($"new Trait {{ Id = {++x}, Name = \"{trait}\" }},");

            // PARTIAL Environs
            //foreach (var environ in allEnvirons.Where(e => e != "null").Distinct().OrderBy(y => y)) Console.WriteLine($"new Environ {{ Id = {++x}, Name = \"{environ}\" }},");

            // Languages
            //foreach (string lang in LangList.Languages) Console.WriteLine($"new Language {{ Id = {++x}, Name = \"{lang}\" }},");

            // Tags
            //foreach (string tag in tags.Distinct().OrderBy(y => y)) Console.WriteLine(tag);

            Console.Read();
        }

        static int GetProficiencyBonus(string monster)
        {
            int i = Array.IndexOf(MonsterList.Monsters, monster) + 13;
            if (i > 95) return 3;
            else return 2;
        }

        static string GetFrom(string senses, string sense)
        {
            if (senses.Contains(sense))
            {
                int i = senses.IndexOf(sense);
                return $"{sense} = {Convert.ToInt32(senses.Substring(i + sense.Length + 1, 3))}, ";
            }
            return "";
        }

        static int GetFrom(float abilityScore, int skill)
        {
            if (skill > -5) return skill;
            return AM(abilityScore);
        }

        static void PassivePerceptionCheck(string monster, float WIS, int perception, int passivePerception)
        {
            bool klaida = false;
            if (perception > -5)
            {
                if (passivePerception != perception + 10)
                {
                    klaida = true;
                }
            }
            else
            {
                if (passivePerception != AM(WIS) + 10)
                {
                    klaida = true;
                }
            }

            if (klaida)
            {
                Console.WriteLine($"KLAIDA: {monster}");
                Console.WriteLine("passivePerception");
                Console.WriteLine(passivePerception);
                Console.WriteLine();
                Console.WriteLine("WIS");
                Console.WriteLine(WIS);
                Console.WriteLine();
                Console.WriteLine("perception");
                Console.WriteLine(perception);
                Console.WriteLine();
            }
        }

        static int AM(float score) => Convert.ToInt32(Math.Floor((score - 10) / 2));

        static string SC(string name) => name.ToLower().Replace(" ", "");
    }
}
