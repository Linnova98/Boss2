using System;

namespace Boss2
{
    class Boss : GameCharacter
    {
        public Boss(string name, int stamina, int health) : base(name, stamina, health)
        {
            Strength = 0;
        }
        
        public override int Charge()
        {
            var random = new Random();
            Strength = random.Next(0, 30 + 1);
            return Strength;
        }
    }
}