using Class05.Interfaces;
using Class05.Models;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {

            IArmor armor = new Leather("Elven Leather Armor", 12);
            IArmor heavyPlateArmor = new HeavyPlateArmor("Dwarven Plate Armor", 25);
            IWeapon sword = new Sword("Long sword", 5);
            IWeapon battleaxe = new BattleAxe("Executioner's BattleAxe", 18);


            ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            ICombatant badGuy = new Fighter("Scary Monster", armor, sword);
            ICombatant dwarvenFighter = new Fighter("Gimli", heavyPlateArmor,battleaxe);

            fighter.Attack(badGuy);
            dwarvenFighter.Attack(badGuy);

        }

    }

}
