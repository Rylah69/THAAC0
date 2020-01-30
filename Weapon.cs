using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THAACO
{
    class Weapon
    {
        private string name;
        private int dice;
        private int enchant;
        private int damage_Bonus;
        private int hit_Bonus;
        private int element;
        private int type = 0;
        private int material;
        private int proc_Rate;
        private int proc_Static;
        private int proc_Random;
        private Random rand = new Random();


        public Weapon()
        {
            this.name = "";
            this.dice = 0;
            this.enchant = 0;
            this.damage_Bonus = 0;
            this.hit_Bonus = 0;
            this.element = 0;
            this.type = 0;
            this.material = 0;
            this.proc_Rate = 0;
            this.proc_Static = 0;
            this.proc_Random = 0;
        }

        public string Name { get => name; set => name = value; }
        public int Dice { get => dice; set => dice = value; }
        public int Enchant { get => enchant; set => enchant = value; }
        public int Damage_Bonus { get => damage_Bonus; set => damage_Bonus = value; }
        public int Hit_Bonus { get => hit_Bonus; set => hit_Bonus = value; }
        public int Element { get => element; set => element = value; }
        public int Type { get => type; set => type = value; }
        public int Material { get => material; set => material = value; }
        public int Proc_Rate { get => proc_Rate; set => proc_Rate = value; }
        public int Proc_Static { get => proc_Static; set => proc_Static = value; }
        public int Proc_Random { get => proc_Random; set => proc_Random = value; }

        /*public int DiceRoll()
        {
            
        }*/
    }
}
