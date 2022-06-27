using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Game
{
    public enum Playerweapon
    {
        none = 0,
        sword = 1,
        bow = 2,
        staff = 3
    }

    class Player : Creature
    {
        protected Playerweapon weapon = Playerweapon.none;
        protected Player(Playerweapon weapon) : base(CreatureType.Player)
        {
            this.weapon = weapon;
        }

        public Playerweapon Getweapon() { return weapon; }
    }

    class sword : Player
    {
        public sword() : base(Playerweapon.sword)
        {
            BaseState(15, 3);
        }
    }
    class bow : Player
    {
        public bow() : base(Playerweapon.bow)
        {
            BaseState(13, 5);
        }
    }
    class staff : Player
    {
        public staff() : base(Playerweapon.staff)
        {
            BaseState(10, 7);
        }
    }
}
