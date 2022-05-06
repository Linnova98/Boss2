using System;
// base klassen er gamecharacter
// så kan hero og boss classen arve fra gamecharacter...
// alt som hero og boss har i likhet kan være i baseklassen
// men forskjellig logikk kan være i den bestemte klassen
namespace Boss2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hero = new Hero("Hero", 40, 100);
            var boss = new Boss("Boss", 10, 400);

            while (hero.Health > 0 && boss.Health > 0)
            {
                hero.Fight(boss);
                boss.Charge();
                boss.Fight(hero);
                
            }
        }
    }
}
