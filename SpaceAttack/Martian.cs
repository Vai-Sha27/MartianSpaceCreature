using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAttack
{
    public class Martian
    {
        public int HealthPoints { get; set; }
        private int _attack;
        public int AttackChk
        {
            get
            {
                return _attack;
            }
            set
            {
                if(value >= 10)
                    _attack = value;
            }
        }

        public override string ToString()
        {        
            return "HealthPoints = " + HealthPoints + ", AttackChk = " + AttackChk;
        }
    }
}
