using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Game
    {
        private readonly Player _player;

        public Game()
        {
            _player = new Player(new Sword());
        }

        public void Start()
        {
            Console.WriteLine("Добро пожаловать в игру!");
            Console.WriteLine("Ваше текущее оружие: меч.");
            
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Атаковать");
                Console.WriteLine("2 - Сменить оружие");
                Console.WriteLine("3 - Выйти из игры");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine() ?? string.Empty;


                switch (choice)
                {
                    case "1":
                        _player.Attack();
                        break;

                    case "2":
                        ChangeWeapon();
                        break;

                    case "3":
                        Console.WriteLine("Спасибо за игру!");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        private void ChangeWeapon()
        {
            Console.WriteLine("\nВыберите новое оружие:");
            Console.WriteLine("1 - Меч");
            Console.WriteLine("2 - Лук");
            Console.WriteLine("3 - Топор");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine() ?? string.Empty;


            switch (choice)
            {
                case "1":
                    _player.SetWeapon(new Sword());
                    break;

                case "2":
                    _player.SetWeapon(new Bow());
                    break;

                case "3":
                    _player.SetWeapon(new Axe());
                    break;

                default:
                    Console.WriteLine("Неверный выбор. Оружие не изменено.");
                    break;
            }
        }
    }
}
