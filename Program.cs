using System;

namespace Д.з__4__4_1_
{
    class Program
    {
        public class Character
        {
            public int Health { get; set; } = 100;

            public string Race { get; set; }
            public int Armor { get; set; }


            public Character(string race)
            {
                Race = race;
                Armor = 30;
            }

            public void Hit(int damage)
            {
                if (damage > Health)
                    damage = Health;

                Health -= damage;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите рассу: " +
                "Elf; " +
                "Ork;" +
                " Human");
            string race = Console.ReadLine();

            Character c = new Character(race);
            Console.Write($"{c.Race} Здоровье : {c.Health}\n");

            Console.Write($"Нанесите урон: ");
            int damage = int.Parse(Console.ReadLine());
            
            c.Hit(damage);
            Console.WriteLine($"{c.Race} : Осталось здоровья {c.Health}");




        }
    }
}
