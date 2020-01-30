using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THAACO
{
    class Player
    {
        private string name;
        private int _level;
        private int _STR;
        private int _DEX;
        private int _hit_class;
        private int _damage;
        private int _hit_Dice;

        public Player()
        {
            name = "Zealot";
            _level = 0;
            _STR = 0;
            _DEX = 0;
            _hit_class = 0;
            _damage = 0;
            _hit_Dice = _level;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => _level; set => _level = value; }
        public int STR { get => _STR; set => _STR = value; }
        public int DEX { get => _DEX; set => _DEX = value; }
        public int Level_bonus { get => _hit_class; set => _hit_class = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public int Hit_Dice { get => _hit_Dice; set => _hit_Dice = value; }
    }
}
