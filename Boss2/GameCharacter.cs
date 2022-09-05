using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss2
{
    internal abstract class GameCharacter
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Strength { get;  set; }
        public int Stamina { get; set; }
        public int MaxStamina { get; set; }

        public GameCharacter(string name, int stamina, int health)
        {
            Name = name;
            Stamina = stamina;
            MaxStamina = Stamina;
            Health = health;
        }
        
       public void Fight(GameCharacter enemy)
        {
            if (Stamina == 0)
            {
                Recharge();
                return;
            }
            var damage = Strength;

            enemy.Health -= damage;
            Stamina -= 10;


            var result = $"{Name} hit {enemy.Name} with {damage} damage, {enemy.Name} has ";


            if (enemy.Health <= 0)
            {
                enemy.Health = 0;
                result += $"{enemy.Health} hp left. {Name} won!";
            }
            else result += $"{enemy.Health} hp left. {Name} stamina is now {Stamina}.";

            Console.WriteLine(result);

        }

       public abstract int Charge();
       
        public void Recharge()
        {
            Stamina = MaxStamina;
            Console.WriteLine($"{Name} used the stamina potion!");
        }
    }
}
