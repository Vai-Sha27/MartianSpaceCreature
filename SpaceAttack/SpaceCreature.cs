using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAttack
{
    public class SpaceCreature
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
                _attack = 10;
            }
        }
        public SpaceCreature(int healthPoints)
        {
            HealthPoints = healthPoints;
        }
    }
}
