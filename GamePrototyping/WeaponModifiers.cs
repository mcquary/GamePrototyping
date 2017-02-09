using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    public enum WeaponModifierEnum
    { 
        WeaponDamage,
        CriticalHitChance,
        CriticalHitDamage,
        AreaOfEffectDamage,
        AreaOfEffectDistance,
        Accuracy,
        FireRate, // lessen cost of AP?
        MagazineSize,
        AmmoConsumption,
        ElementalEffectChance,
        ElementalEffectDamage,
        MeleeDamage,
    }
    public class WeaponModifiers
    {
        public WeaponModifiers()
        { }
        public WeaponModifiers(WeaponModifierEnum modifier, double value)
        {
            Modifier = modifier;
            Value = value;
        }
        public WeaponModifierEnum Modifier { get; set; }
        //percentage modifier
        public double Value { get; set; }
    }
}
