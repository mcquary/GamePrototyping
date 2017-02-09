using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamePrototyping
{
    class Program
    {
        static void Main(string[] args)
        {
            var level = 5;
            //PrintWeaponTypeCheck(level);
            //PrintRarityCheck(level);
            Weapon testWeapon = Weapon.GenerateWeapon(WeaponTypeEnum.Pistol, level);
            Console.WriteLine(testWeapon.ToString());
        }
        static void PrintWeaponTypeCheck(int level)
        {
            int assaultRifleCount = 0;
            int grenadeCount = 0;
            int longRifleCount = 0;
            int oneHandedCount = 0;
            int pistolCount = 0;
            int smgCount = 0;
            int twoHandedCount = 0;

            for (int i = 0; i < 100; i++)
            {
                var weapon = Weapon.GenerateWeapon(level);
                switch (weapon.WeaponType)
                {
                    case WeaponTypeEnum.AssaultRifle:
                        assaultRifleCount++;
                        break;
                    case WeaponTypeEnum.Grenade:
                        grenadeCount++;
                        break;
                    case WeaponTypeEnum.LongRifle:
                        longRifleCount++;
                        break;
                    case WeaponTypeEnum.OneHanded:
                        oneHandedCount++;
                        break;
                    case WeaponTypeEnum.Pistol:
                        pistolCount++;
                        break;
                    case WeaponTypeEnum.SMG:
                        smgCount++;
                        break;
                    case WeaponTypeEnum.TwoHanded:
                        twoHandedCount++;
                        break;
                }
            }

            Console.WriteLine("AR: " + assaultRifleCount.ToString());
            Console.WriteLine("Grenade: " + grenadeCount.ToString());
            Console.WriteLine("Long Rifle: " + longRifleCount.ToString());
            Console.WriteLine("OneHanded: " + oneHandedCount.ToString());
            Console.WriteLine("Pistol: " + pistolCount.ToString());
            Console.WriteLine("SMG: " + smgCount.ToString());
            Console.WriteLine("TwoHanded: " + twoHandedCount.ToString());
        }
        static void PrintRarityCheck(int level)
        {
            int commonCount = 0;
            int obscureCount = 0;
            int heroicCount = 0;
            int legendaryCount = 0;
            int mythicCount = 0;
            int famousCount = 0;
            int demiGodCount = 0;

            for (int i = 0; i < 10000; i++)
            {
                var weapon = Weapon.GenerateWeapon(level);
                switch (weapon.Rarity)
                {

                    case RarityEnum.Common:
                        commonCount++;
                        break;
                    case RarityEnum.Demigod:
                        demiGodCount++;
                        break;
                    case RarityEnum.Heroic:
                        heroicCount++;
                        break;
                    case RarityEnum.Mythic:
                        mythicCount++;
                        break;
                    case RarityEnum.Legendary:
                        legendaryCount++;
                        break;
                    case RarityEnum.Obscure:
                        obscureCount++;
                        break;
                    case RarityEnum.Famous:
                        famousCount++;
                        break;
                }
            }

            Console.WriteLine("Common: " + commonCount.ToString());
            Console.WriteLine("Obscure: " + obscureCount.ToString());
            Console.WriteLine("Famous: " + famousCount.ToString());
            Console.WriteLine("Heroic: " + heroicCount.ToString());
            Console.WriteLine("Legendary: " + legendaryCount.ToString());
            Console.WriteLine("Mythic: " + mythicCount.ToString());
            Console.WriteLine("Demigod: " + demiGodCount.ToString());
        }

        static void ItemDamageCheck(WeaponTypeEnum weaponType, int level)
        {
            
            double? minDam = null;
            double? maxDam = null;
            Weapon minDamObj = null;
            Weapon maxDamObj = null;

            for (int i = 0; i < 100; i++)
            {
                var weapon = Weapon.GenerateWeapon(weaponType, level);
                if (!minDam.HasValue)
                {
                    minDam = weapon.EffectiveDamage;
                    minDamObj = weapon;
                }
                if (!maxDam.HasValue)
                {
                    maxDam = weapon.EffectiveDamage;
                    maxDamObj = weapon;
                }
                if (weapon.EffectiveDamage < minDam.Value)
                {
                    minDam = weapon.EffectiveDamage;
                    minDamObj = weapon;
                }
                if (weapon.EffectiveDamage > maxDam.Value)
                {
                    maxDam = weapon.EffectiveDamage;
                    maxDamObj = weapon;
                }

            }

            Console.WriteLine("Min:");
            Console.WriteLine(minDamObj.ToString());
            Console.WriteLine("Max:");
            Console.WriteLine(maxDamObj.ToString());
        }


    }
}
