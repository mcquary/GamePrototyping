using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    public enum ItemTypeEnum
    {
        None,
        Weapon,
        Armor,
        Boots,
        Gloves,
        Ring,
        Necklace,
        Headwear,
        Shield
    }

    public enum WeaponTypeEnum
    { 
        OneHanded,
        TwoHanded,
        Pistol,
        AssaultRifle,
        LongRifle,
        Grenade,
        SMG
    }

    public enum WeaponPartEnum
    {
        Body,
        Grip,
        Barrel,
        Sight,
        Stock,
        Trigger
       //Accessory
    }

    public enum ShieldPartEnum
    {
        Battery,
        Capacitor,
        Accessory
    }

    public enum GrenadePartEnum
    {
        DeliveryMechanism,
        Trigger,
        Payload
    }
    public enum PartTypeEnum
    { 
        Body,
        Grip,
        Barrel,
        Sight,
        Stock,

        Battery,
        Capacitor,
        Accessory,

        DeliveryMechanism,
        Trigger,
        Payload
    }
    public enum AreaOfEffectEnum
    { 
        PointOfImpact,
        Area,
        Locale
    }
    public enum WeaponElemental
    { 
        None,
        Fire,
        Energy,
        Concussive,
        Ice
    }
}
