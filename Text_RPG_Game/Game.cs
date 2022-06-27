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
                    player = new Player();
                    mode = GameMode.First_Field;
                    break;
                default:
                    break;
            }
        }
    }
}
