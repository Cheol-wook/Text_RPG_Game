using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Game
{
    public enum GameMode
    {
        None,
        Start,
        First_Field,
        Second_Field,
        Third_Field,
        Fourth_Field,
        Five_Field,
        Shop
    }

    public class Game
    {
        private Player player = null;
        private GameMode mode = GameMode.Start;

        public void Now_state()
        {
            int now_hp = player.GetHP();
            int now_attack = player.GetAttack();
            int now_ADdef = player.GetAD_defence();
            int now_APdef = player.GetAP_defence();
            Console.WriteLine("현재 능력치\n");
            Console.WriteLine("HP : {0}\n공격력 : {1}\n물리 방어 : {2}\n마법방어 : {3}",
                              now_hp, now_attack, now_ADdef, now_APdef);
        }

        public void modechanger()
        {
            switch (mode)
            {
                case GameMode.Start:
                    Start_Game();
                    break;
                case GameMode.First_Field:
                    break;
                case GameMode.Second_Field:
                    break;
                case GameMode.Third_Field:
                    break;
                case GameMode.Fourth_Field:
                    break;
                case GameMode.Five_Field:
                    break;
                case GameMode.Shop:
                    break;
                default:
                    break;
            }
        }
        public void Start_Game()
        {
            Console.WriteLine("어두운 동굴로 들어갑니다.");
            Console.WriteLine("당신의 앞에 3가지 무기가 떨어져 있습니다.\n");
            Console.WriteLine("어떤 것을 확인하시겠습니까?\n");
            Console.WriteLine("1. 작은 단검\n2. 오래된 활\n3. 낡은 지팡이\n");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("단검을 집었습니다.");
                    Console.WriteLine("당신은 천천히 동굴 속으로 걸음을 내딛었습니다.");
                    player = new sword();
                    mode = GameMode.First_Field;
                    Now_state();
                    break;
                case "2":
                    Console.WriteLine("활을 집었습니다.");
                    Console.WriteLine("당신은 천천히 동굴 속으로 걸음을 내딛었습니다.");
                    player = new bow();
                    mode = GameMode.First_Field;
                    break;
                case "3":
                    Console.WriteLine("지팡이를 집었습니다.");
                    Console.WriteLine("당신은 천천히 동굴 속으로 걸음을 내딛었습니다.");
                    player = new staff();
                    mode = GameMode.First_Field;
                    break;
                default:
                    break;
            }
        }
    }
}
