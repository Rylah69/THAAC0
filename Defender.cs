using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THAACO
{
    class Defender
    {
        private int AC;
        private int HP;

        public Defender()
        {
            AC = 0;
            HP = 0;
        }

        public int AC1 { get => AC; set => AC = value; }
        public int HP1 { get => HP; set => HP = value; }
    }
}
