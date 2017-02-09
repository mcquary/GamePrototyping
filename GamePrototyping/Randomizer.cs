using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    public class Randomizer
    {
        public double WeightedRoll(List<double> weights)
        {

            // not sure if this does anything actually

            int totalWeight = 0;
            foreach(var weight in weights)
            {
                if (weight != 0)
                    totalWeight += (int)(100 / weight);
            }

            Random item = new Random(this.GetHashCode() + DateTime.Now.Millisecond);
            var result = item.Next(totalWeight);
            return result;
            
        }

        public static WeaponTypeEnum GetWeaponType()
        {
            var random = Roll();
            if (random < .15)
                return WeaponTypeEnum.AssaultRifle; //15
            if (random < .25)
                return WeaponTypeEnum.Grenade; //10
            if (random < .4)
                return WeaponTypeEnum.LongRifle; //15
            if (random < .55)
                return WeaponTypeEnum.OneHanded; //15
            if (random < .7)
                return WeaponTypeEnum.Pistol; //15
            if (random < .85)
                return WeaponTypeEnum.SMG; //15
            //if (random < .7)
                return WeaponTypeEnum.TwoHanded; //15
        }

        public static bool CoinFlip()
        {
            return Roll() > .5;
        }

        //public static WeaponPartEnum GetRandomWeaponPart
        public static int GetEvenChanceItem(Type enumType)
        {
             var enumCount = Enum.GetNames(enumType).ToList().Count;
            var interval = (100 / enumCount);
            var intRandom = Roll() * 100;
            int intResult = 0;

            while (intRandom > interval)
            {
                intRandom -= interval;
                intResult++;
            }
            return intResult;
        }
        
        public static ItemTypeEnum GetItemType()
        {
            var random = Roll();
            if (random < .1)
                return ItemTypeEnum.None;
            else if (random < .3)
                return ItemTypeEnum.Weapon;
            else if (random < .45)
                return ItemTypeEnum.Boots;
            else if (random < .53)
                return ItemTypeEnum.Necklace;
            else if (random < .68)
                return ItemTypeEnum.Shield;
            else if (random < .8)
                return ItemTypeEnum.Armor;
            else if (random < .89)
                return ItemTypeEnum.Gloves;
            else if (random < .96)
                return ItemTypeEnum.Headwear;
            else 
                return ItemTypeEnum.Ring;
        }
        public static ManufacturerEnum GetManufacturer()
        { 
            //manufacturer has equal chance;
            //var enumCount = Enum.GetNames(typeof(ManufacturerEnum)).ToList().Count;
            //var interval = (100 / enumCount);
            //var intRandom = Roll() * 100;
            //int intResult = 0;

            //while (intRandom > interval)
            //{
            //    intRandom -= interval;
            //    intResult++;
            //}
            return (ManufacturerEnum)GetEvenChanceItem(typeof(ManufacturerEnum));
        }

        public static double Roll()
        {
            Random item = new Random(Guid.NewGuid().GetHashCode());
            Random item2 = new Random(Environment.TickCount);
            Random item3 = new Random(item.Next() + item2.Next());
            var result = item3.NextDouble();
            return result;
        }

        public static double Roll(int percentMax)
        {
            Random item = new Random(Guid.NewGuid().GetHashCode());
            Random item2 = new Random(Environment.TickCount);
            Random item3 = new Random(item.Next() + item2.Next());
            var result = item3.Next(percentMax);
            return (result / 100d);
        }

        internal static RarityEnum GetRandomRarity()
        {
            var random = Roll();
            if (random < .5)
                return RarityEnum.Common; //50%
            if (random < .85)
                return RarityEnum.Obscure; //35%
            if (random < .95)
                return RarityEnum.Famous; //10%
            if (random < .98)
                return RarityEnum.Heroic; //5%
            if (random < .99)
                return RarityEnum.Legendary; //3.5%
            if (random < .998)
                return RarityEnum.Mythic; //1%

            return RarityEnum.Demigod; //.5
        }
    }
}
