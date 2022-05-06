namespace Boss2
{
    interface ICharacters
    {
        string Name { get; }
        int Health { get; }
        int Strength { get; }
        int Stamina { get; } 
        int MaxStamina { get; }
        void Recharge();
    }
}