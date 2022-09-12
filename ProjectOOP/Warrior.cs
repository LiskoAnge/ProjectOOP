using System;
//using ProjectOOP.Equipment

namespace ProjectOOP   
{
    class Warrior
    {
        private const int GOOD_GUY_START_HEALTH = 100;
        private const int BAD_GUY_START_HEALTH = 100;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;  //when the warrior is created, is alive.

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);       //creating instances of weapon and armor for both warriors
                    armor = new Armor(faction);
                    health = GOOD_GUY_START_HEALTH;

                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_START_HEALTH;

                    break;

                default:
                    break;
            }
        }
        public void Attack(Warrior enemy)  //called enemy becausethis method is used by both the good guy and the bad guy! 
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;     //the 'enemy' in enemy.armor.ArmorPoints refers to the Warrior passed as argument in the method, whilst the weapon.Damage does not have anything in front because it refers to the Warrior on this current file.

            enemy.health = enemy.health - damage;   //another shorter way would be enemy.health -= damage; which is the exact same thing.

            AttackResult(enemy, damage);
            
        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($" {enemy.name} has been defeated!);", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is victorious!!", ConsoleColor.Green);
            }
            else
            {
                Tools.ColorfulWriteLine($"{name} attacked {enemy.name}. {damage} damage was inflicted, remaining health of {enemy.name} is {enemy.health}", ConsoleColor.Cyan);
            }
        }
    }
}
