using System;
namespace ProjectOOP   //.Equipment
{
    class Armor
    {
        private int armorPoints;

        private const int GOOD_GUYARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;
    

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction  faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:

                    armorPoints = GOOD_GUYARMOR;

                    break;
                case Faction.BadGuy:


                    armorPoints = BAD_GUY_ARMOR;

                    break;

                default:
                    break;
            }
        }
    }
}
