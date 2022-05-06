namespace Boss2
{
         class Hero : GameCharacter
    {
        public Hero(string name, int stamina, int health) : base(name, stamina, health)
        {
            Strength = 20;
        }


        public override int Charge()
        {
            Strength = Strength;
            return Strength;
        }
    }
}