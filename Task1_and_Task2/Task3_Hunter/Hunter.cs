using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Hunter
{
    public class Hunter
    {
        Random rand = new Random();
        int _health;
        int _gold;
        int _arrows;
        int _prey;
        int _oldHealth;

        public string Name { get; init; } = "";

        public int Health
        {
            get => _health;
            set => _health = Math.Max(value, 0);
        }

        public int Gold
        {
            get => _gold;
            set => _gold = Math.Max(value, 0);
        }

        public int Arrows
        {
            get => _arrows;
            set => _arrows = Math.Max(value, 0);
        }

        public int Prey
        {
            get => _prey;
            set => _prey = Math.Max(value, 0);
        }

        public int Difference_health { get => (_oldHealth - _health); }

        public Hunter() { }

        public Hunter(string name, int health, int gold, int arrows, int prey)
        {
            Name = name;
            Health = health;
            _oldHealth = health;
            Gold = gold;
            Arrows = arrows;
            Prey = prey;
        }

        public void Hunt()
        {
            if (_arrows > 0 && _health > 5)
            {
                _arrows--;
                _health -= rand.Next(0, 6);

                if (rand.Next(0, 2) == 1)
                {
                    _prey++;
                    Console.WriteLine(Name + " Здобув здобич");
                }
            }
            else
            {
                if (_arrows < 0)
                    Console.WriteLine(Name + " Потрібні стріли для полювання");
                else
                    Console.WriteLine(Name + " Недостатньо здоровя для полювання");
            }

        }

        public void Sell_prey()
        {
            if (_prey > 0)
            {
                _prey--;
                _gold = +3;

                Console.WriteLine(Name + " Мисливця продав одну одиницю здобичі");
            }
            else
                Console.WriteLine(Name + " У мисливця немає здобичі");
        }

        public void Regain_health()
        {
            int difference = _oldHealth - _health;
            if (_gold >= (difference * 2))
            {
                _health = _oldHealth;
                _gold -= difference * 2;
                Console.WriteLine(Name + " Здоровя відновленно");
            }
            else
                Console.WriteLine(Name + " Недостатньо золота");
        }

        public void Buy_arrow()
        {
            if (_gold > 0)
            {
                _gold--;
                _arrows++;

                Console.WriteLine(Name + " Придбав одну стрілу");
            }
            else
                Console.WriteLine(Name + " Бракує золота");
        }

        public void GetInfoHunter(Hunter hunter)
        {
            Console.WriteLine($"Мисливець: " +
                $"\n{hunter.Name}" +
                $"\nЗдоровя: {hunter.Health}" +
                $"\nЗолото: {hunter.Gold}" +
                $"\nСтріли: {hunter.Arrows}" +
                $"\nЗдобич: {hunter.Prey}");
        }
    }
}
