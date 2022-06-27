using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Game
{
    public enum PlayerWeapon
    {
        none = 0,
        sword = 1,
        bow = 2,
        staff = 3
    }

    public class Player
    {
        protected int hp = 0;
        protected int attack = 0;
        protected int AD_defence = 0;
        protected int AP_defence = 0;
        protected PlayerWeapon weapon = PlayerWeapon.none;

        protected Player(PlayerWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void BaseState(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public int GetHP() { return hp; }
        public int GetAttack() { return attack; }
        public int GetAD_defence() { return AD_defence; }
        public int GetAP_defence() { return AP_defence; }
        public PlayerWeapon GetWeapon() { return weapon; }
    }

    class sword : Player
    {
        public sword() : base(PlayerWeapon.sword)
        {
            BaseState(15, 3);
        }
    }
    class bow : Player
    {
        public bow() : base(PlayerWeapon.bow)
        {
            BaseState(13, 5);
        }
    }
    class staff : Player
    {
        public staff() : base(PlayerWeapon.staff)
        {
            BaseState(10, 7);
        }
    }
}
