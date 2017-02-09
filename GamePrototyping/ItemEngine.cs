using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    public class ItemEngine
    { 
        public const double GOLDEN_RATIO = 1.61803398875;
        public const double _currentLevel = 0;
        public StatSheet CalculateStats()
        {
            return new StatSheet();
        }

        public double BaseLevelAdjustment
        {
            get { return Math.Pow(GOLDEN_RATIO, _currentLevel); }
        }
    }
}
