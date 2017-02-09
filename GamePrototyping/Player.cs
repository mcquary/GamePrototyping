using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    public class Player : CharacterBase
    {
        private int _level;
        public const double GOLDEN_RATIO = 1.61803398875;       
        public Player()
        {
            _level = 30;
            Health = GetEffectiveHealth();
        }

        public Player(int level)
        {
            _level = level;
            Health = GetEffectiveHealth();
        }

        private int GetEffectiveHealth()
        { 
            return (int)(80d * Math.Pow(_level, GOLDEN_RATIO));
        }

        public override string ToString()
        {
            return Health.ToString();
        }

    }
}
