using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    public abstract class CharacterBase : WorldObject
    {
        private long _health;
        private long _xp;

        public CharacterBase()
            {}

        public CharacterBase(long health, long xp)
        {
            _health = health;
            _xp = xp;
        }
        public long Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public long XP
        {
            get { return _xp; }
            set { _xp = value; }
        }


    }
}
