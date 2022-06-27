using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Game
{
    public enum CreatureType
    {
        None,
        Player = 1,
        Monster = 2
    }

    class Creature
    {
        CreatureType type;  // private
        protected int hp = 0;
        protected int attack = 0;
        protected int AD_defence = 0;
        protected int AP_defence = 0;
        protected Creature(CreatureType type)
        {
            this.type = type;
        }

        public void BaseState(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public bool IsDead() { return hp <= 0; }

        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }
        public int GetHP() { return hp; }
        public int GetAttack() { return attack; }
        public int GetAD_defence() { return AD_defence; }
        public int GetAP_defence() { return AP_defence; }
    }
}

