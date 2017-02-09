using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    public class Weapon
    {
        private List<Part> _parts;
        private const byte BASE_ONEHANDED_DAMAGE = 1;
        private const byte BASE_TWOHANDED_DAMAGE = 2;
        private const byte BASE_PISTOL_DAMAGE = 5;
        private const byte BASE_SHOTGUN_DAMAGE = 7;
        private const byte BASE_ASSAULTRIFLE_DAMAGE = 7;
        private const byte BASE_LONGRIFLE_DAMAGE = 10;
        private const byte BASE_SMG_DAMAGE = BASE_PISTOL_DAMAGE;
        private const byte BASE_GRENADE_DMG = 20;
        private ManufacturerEnum _manufacturer;
        private RarityEnum _rarity;
        private WeaponTypeEnum _weaponType;
        private int _level;
        private List<WeaponModifiers> _modifiers;
        private bool _hasAccessory;
        public const double GOLDEN_RATIO = 1.61803398875;


        public RarityEnum Rarity
        {
            get { return _rarity; }
        }
        public WeaponTypeEnum WeaponType
        {
            get { return _weaponType; }
        }
        public Weapon()
        {
            _parts = new List<Part>();
            //_parts.Add(new Part(WeaponPartEnum.Accessory));
            _parts.Add(new Part(WeaponPartEnum.Barrel));
            _parts.Add(new Part(WeaponPartEnum.Body));
            _parts.Add(new Part(WeaponPartEnum.Grip));
            _parts.Add(new Part(WeaponPartEnum.Sight));
            _parts.Add(new Part(WeaponPartEnum.Stock));
            _parts.Add(new Part(WeaponPartEnum.Trigger));

            _modifiers = new List<WeaponModifiers>();
        }

        private double GetBaseDamage()
        {
            switch (_weaponType)
            { 
                case WeaponTypeEnum.LongRifle:
                    return BASE_LONGRIFLE_DAMAGE;
                case WeaponTypeEnum.Pistol:
                    return BASE_PISTOL_DAMAGE;
                case WeaponTypeEnum.SMG:
                    return BASE_SMG_DAMAGE;
                case WeaponTypeEnum.OneHanded:
                    return BASE_ONEHANDED_DAMAGE;
                case WeaponTypeEnum.TwoHanded:
                    return BASE_TWOHANDED_DAMAGE;
                case WeaponTypeEnum.AssaultRifle:
                    return BASE_ASSAULTRIFLE_DAMAGE;
                case WeaponTypeEnum.Grenade:
                    return BASE_GRENADE_DMG;
            }
            return 1;
        }

        private double GetBaseDamageVariable(int maxPercentDeviation)
        {
            int multiplier = 1;
            if (Randomizer.CoinFlip())
                multiplier = -1;
            
            var deviationAmount = multiplier * Randomizer.Roll(maxPercentDeviation);
            return GetBaseDamage() * (1 + deviationAmount);
        }

        private double GetCriticalHitMultiplier()
        {
            switch (_weaponType)
            { 
                case WeaponTypeEnum.LongRifle:
                    return 2.6;                  
                case WeaponTypeEnum.SMG:
                    return 1.6;
                case WeaponTypeEnum.OneHanded:
                    return 10;
                case WeaponTypeEnum.TwoHanded:
                    return 15;
            }
            return 2;
        }

        public Weapon(int level)
        {
            _level = level;
            _parts = new List<Part>();
            //_parts.Add(new Part(PartTypeEnum.Accessory));
            _parts.Add(new Part(WeaponPartEnum.Barrel));
            _parts.Add(new Part(WeaponPartEnum.Body));
            _parts.Add(new Part(WeaponPartEnum.Grip));
            _parts.Add(new Part(WeaponPartEnum.Sight));
            _parts.Add(new Part(WeaponPartEnum.Stock));
            _parts.Add(new Part(WeaponPartEnum.Trigger));

            _modifiers = new List<WeaponModifiers>();
        }

        public static Weapon GenerateWeapon(WeaponTypeEnum weaponType, int level)
        {
            var item = new Weapon(level);

            item._manufacturer = Randomizer.GetManufacturer();
            item._rarity = Randomizer.GetRandomRarity();
            item._weaponType = weaponType;
            item.Body.Manufacturer = item._manufacturer;
            item.Barrel.Manufacturer = Randomizer.GetManufacturer();
            item.Grip.Manufacturer = Randomizer.GetManufacturer();
            item.Sight.Manufacturer = Randomizer.GetManufacturer();
            item.Stock.Manufacturer = Randomizer.GetManufacturer();
            item.Trigger.Manufacturer = Randomizer.GetManufacturer();

            var mods = new ManufacturerPartCharacteristics(item.Body.Manufacturer);
            mods.GenerateModifiers(item.Barrel.Manufacturer, item.Barrel.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Stock.Manufacturer, item.Stock.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Grip.Manufacturer, item.Grip.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Sight.Manufacturer, item.Sight.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Body.Manufacturer, item.Body.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Trigger.Manufacturer, item.Trigger.WeaponPartType, item._weaponType);
            item._modifiers.AddRange(mods.Modifiers);
            return item;
        }

        public static Weapon GenerateWeapon(ManufacturerEnum manufacturer, RarityEnum rarity, int level)
        {
            var item = new Weapon(manufacturer, rarity, level);

            item._manufacturer = manufacturer;
            item._rarity = rarity;
            item._weaponType = Randomizer.GetWeaponType();
            item.Body.Manufacturer = item._manufacturer;
            item.Barrel.Manufacturer = item._manufacturer;
            item.Grip.Manufacturer = item._manufacturer;
            item.Sight.Manufacturer = item._manufacturer;
            item.Stock.Manufacturer = item._manufacturer;
            item.Trigger.Manufacturer = item._manufacturer;

            var mods = new ManufacturerPartCharacteristics(item.Body.Manufacturer);
            mods.GenerateModifiers(item.Barrel.Manufacturer, item.Barrel.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Stock.Manufacturer, item.Stock.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Grip.Manufacturer, item.Grip.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Sight.Manufacturer, item.Sight.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Body.Manufacturer, item.Body.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Trigger.Manufacturer, item.Trigger.WeaponPartType, item._weaponType);
            item._modifiers.AddRange(mods.Modifiers);
            return item;
        }
        public static Weapon GenerateWeapon(int level)
        {
            var item = new Weapon(level);

            item._manufacturer = Randomizer.GetManufacturer();
            item._rarity = Randomizer.GetRandomRarity();
            item._weaponType = Randomizer.GetWeaponType();
            item.Body.Manufacturer = item._manufacturer;
            item.Barrel.Manufacturer = Randomizer.GetManufacturer();
            item.Grip.Manufacturer = Randomizer.GetManufacturer();
            item.Sight.Manufacturer = Randomizer.GetManufacturer();
            item.Stock.Manufacturer = Randomizer.GetManufacturer();
            item.Trigger.Manufacturer = Randomizer.GetManufacturer();

            var mods = new ManufacturerPartCharacteristics(item.Body.Manufacturer);
            mods.GenerateModifiers(item.Barrel.Manufacturer, item.Barrel.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Stock.Manufacturer, item.Stock.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Grip.Manufacturer, item.Grip.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Sight.Manufacturer, item.Sight.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Body.Manufacturer, item.Body.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Trigger.Manufacturer, item.Trigger.WeaponPartType, item._weaponType);
            item._modifiers.AddRange(mods.Modifiers);
            return item;
        }

        public void AssignManufacturer()
        {
            Barrel.Manufacturer = Randomizer.GetManufacturer();
        }

        //public Part Accessory
        //{
        //    get { return _parts.SingleOrDefault(x => x.PartType == PartTypeEnum.Accessory); }
        //}
        public Part Body
        {
            get { return _parts.SingleOrDefault(x => x.WeaponPartType == WeaponPartEnum.Body); }
        }

        public Part Barrel
        {
            get { return _parts.SingleOrDefault(x => x.WeaponPartType == WeaponPartEnum.Barrel); }
        }

        public Part Grip
        {
            get { return _parts.SingleOrDefault(x => x.WeaponPartType == WeaponPartEnum.Grip); }
        }

        public Part Trigger
        {
            get { return _parts.SingleOrDefault(x => x.WeaponPartType == WeaponPartEnum.Trigger); }
        }
        public Part Stock
        {
            get { return _parts.SingleOrDefault(x => x.WeaponPartType == WeaponPartEnum.Stock); }
        }
        public Part Sight
        {
            get { return _parts.SingleOrDefault(x => x.WeaponPartType == WeaponPartEnum.Sight); }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            
            stringBuilder.AppendLine(_rarity.ToString() + " " + _manufacturer.ToString() + " " + _weaponType.ToString());
            stringBuilder.AppendLine("Body: " + Body.Manufacturer.ToString());
            stringBuilder.AppendLine("Barrel: " + Barrel.Manufacturer.ToString());
            stringBuilder.AppendLine("Grip: " + Grip.Manufacturer.ToString());
            stringBuilder.AppendLine("Sight: " + Sight.Manufacturer.ToString());
            stringBuilder.AppendLine("Stock: " + Stock.Manufacturer.ToString());
            stringBuilder.AppendLine("Trigger: " + Trigger.Manufacturer.ToString());

            foreach (var item in _modifiers)
                stringBuilder.AppendLine(item.Modifier.ToString() + ": " + item.Value.ToString());

            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("Effective Damage: " + EffectiveDamage.ToString());
            stringBuilder.AppendLine("Critical Hit Damage: " + EffectiveCriticalDamage.ToString());

            return stringBuilder.ToString();
        }

        public int EffectiveDamage
        {
            get
            {
                double weaponDamage = 1;
                if (_modifiers.Exists(x => x.Modifier == WeaponModifierEnum.WeaponDamage))
                    weaponDamage += _modifiers.FindAll(x => x.Modifier == WeaponModifierEnum.WeaponDamage).Sum(x => x.Value);
                return (int)(GetBaseDamageVariable(2) * (1 + ((int)_rarity) / 100d) * weaponDamage * Math.Pow(_level, GOLDEN_RATIO));
            }
        }

        public int EffectiveCriticalDamage
        {
            get
            {
                double weaponDamage = 1;
                double criticalDamage = GetCriticalHitMultiplier();
                if (_modifiers.Exists(x => x.Modifier == WeaponModifierEnum.WeaponDamage))
                    weaponDamage += _modifiers.FindAll(x => x.Modifier == WeaponModifierEnum.WeaponDamage).Sum(x => x.Value);
                if (_modifiers.Exists(x => x.Modifier == WeaponModifierEnum.CriticalHitDamage))
                    criticalDamage += _modifiers.FindAll(x => x.Modifier == WeaponModifierEnum.CriticalHitDamage).Sum(x => x.Value);
                return (int)(GetBaseDamageVariable(2) * (1 + ((int)_rarity) / 100d) * weaponDamage * Math.Pow(_level, GOLDEN_RATIO) * criticalDamage);
            }
        }

        public Weapon(ManufacturerEnum manufacturer) : base()
        {
            _manufacturer = Randomizer.GetManufacturer();
        }

        public Weapon(RarityEnum rarity)
        { 
        
        }

        public Weapon(ManufacturerEnum manufacturer, RarityEnum rarity, int level)
        {
            _level = level;
            _parts = new List<Part>();
            _rarity = rarity;

            _parts.Add(new Part(manufacturer, WeaponPartEnum.Barrel));
            _parts.Add(new Part(manufacturer, WeaponPartEnum.Body));
            _parts.Add(new Part(manufacturer, WeaponPartEnum.Grip));
            _parts.Add(new Part(manufacturer, WeaponPartEnum.Sight));
            _parts.Add(new Part(manufacturer, WeaponPartEnum.Stock));
            _parts.Add(new Part(manufacturer, WeaponPartEnum.Trigger));

            _modifiers = new List<WeaponModifiers>();
        }

        internal static object GenerateWeapon(WeaponTypeEnum weaponType, RarityEnum rarityEnum, int level)
        {
            var item = new Weapon(level);

            item._manufacturer = Randomizer.GetManufacturer();
            item._rarity = rarityEnum;
            item._weaponType = weaponType;
            item.Body.Manufacturer = item._manufacturer;
            item.Barrel.Manufacturer = Randomizer.GetManufacturer();
            item.Grip.Manufacturer = Randomizer.GetManufacturer();
            item.Sight.Manufacturer = Randomizer.GetManufacturer();
            item.Stock.Manufacturer = Randomizer.GetManufacturer();
            item.Trigger.Manufacturer = Randomizer.GetManufacturer();

            var mods = new ManufacturerPartCharacteristics(item.Body.Manufacturer);
            mods.GenerateModifiers(item.Barrel.Manufacturer, item.Barrel.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Stock.Manufacturer, item.Stock.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Grip.Manufacturer, item.Grip.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Sight.Manufacturer, item.Sight.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Body.Manufacturer, item.Body.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Trigger.Manufacturer, item.Trigger.WeaponPartType, item._weaponType);
            item._modifiers.AddRange(mods.Modifiers);
            return item;
        }

        internal static object GenerateWeapon(RarityEnum rarityEnum, int level)
        {
            var item = new Weapon(level);

            item._manufacturer = Randomizer.GetManufacturer();
            item._rarity = rarityEnum;
            item._weaponType = Randomizer.GetWeaponType();
            item.Body.Manufacturer = item._manufacturer;
            item.Barrel.Manufacturer = Randomizer.GetManufacturer();
            item.Grip.Manufacturer = Randomizer.GetManufacturer();
            item.Sight.Manufacturer = Randomizer.GetManufacturer();
            item.Stock.Manufacturer = Randomizer.GetManufacturer();
            item.Trigger.Manufacturer = Randomizer.GetManufacturer();

            var mods = new ManufacturerPartCharacteristics(item.Body.Manufacturer);
            mods.GenerateModifiers(item.Barrel.Manufacturer, item.Barrel.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Stock.Manufacturer, item.Stock.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Grip.Manufacturer, item.Grip.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Sight.Manufacturer, item.Sight.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Body.Manufacturer, item.Body.WeaponPartType, item._weaponType);
            mods.GenerateModifiers(item.Trigger.Manufacturer, item.Trigger.WeaponPartType, item._weaponType);
            item._modifiers.AddRange(mods.Modifiers);
            return item;
        }
    }
}
