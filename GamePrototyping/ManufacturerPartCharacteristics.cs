using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{

    public class ManufacturerPartCharacteristics
    {
        public List<WeaponModifiers> _modifiers = new List<WeaponModifiers>();
        private ManufacturerEnum _manufacturerBonusToMatch;

        public List<WeaponModifiers> Modifiers
        {
            get { return _modifiers; }
        }
        public ManufacturerPartCharacteristics(ManufacturerEnum parentManufacturer)
        {
            _manufacturerBonusToMatch = parentManufacturer;
        }
        public ManufacturerPartCharacteristics(ManufacturerEnum parentManufacturer, WeaponTypeEnum weaponType, ManufacturerEnum manufacturer, WeaponPartEnum part)
        {
            _manufacturerBonusToMatch = parentManufacturer;
            GenerateModifiers(manufacturer, part, weaponType);
        }

#region PART MODIFIERS PER WEAPON
        private void TwoHandedPartModifiers(ManufacturerEnum manufacturer, WeaponPartEnum part)
        {
            switch (part)
            {
                case WeaponPartEnum.Barrel:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:


                            break;
                        case ManufacturerEnum.Longhorn:
                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Grip:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:

                            break;
                        case ManufacturerEnum.Longhorn:

                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Sight:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
                case WeaponPartEnum.Stock:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
            }
        }
        private void OneHandedPartModifiers(ManufacturerEnum manufacturer, WeaponPartEnum part)
        {
            switch (part)
            {
                case WeaponPartEnum.Barrel:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:


                            break;
                        case ManufacturerEnum.Longhorn:
                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Grip:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:

                            break;
                        case ManufacturerEnum.Longhorn:

                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Sight:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
                case WeaponPartEnum.Stock:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
            }
        }
        private void GrenadePartModifiers(ManufacturerEnum manufacturer, WeaponPartEnum part)
        {
            switch (part)
            {
                case WeaponPartEnum.Barrel:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:


                            break;
                        case ManufacturerEnum.Longhorn:
                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Grip:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:

                            break;
                        case ManufacturerEnum.Longhorn:

                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Sight:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
                case WeaponPartEnum.Stock:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
            }
        }
        private void SMGPartModifiers(ManufacturerEnum manufacturer, WeaponPartEnum part)
        {
            switch (part)
            {
                case WeaponPartEnum.Barrel:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:


                            break;
                        case ManufacturerEnum.Longhorn:
                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Grip:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:

                            break;
                        case ManufacturerEnum.Longhorn:

                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Sight:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
                case WeaponPartEnum.Stock:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
            }
        }
        private void AssualtRiflePartModifiers(ManufacturerEnum manufacturer, WeaponPartEnum part)
        {
            switch (part)
            {
                case WeaponPartEnum.Barrel:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:


                            break;
                        case ManufacturerEnum.Longhorn:
                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Grip:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:

                            break;
                        case ManufacturerEnum.Longhorn:

                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:

                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Sight:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
                case WeaponPartEnum.Stock:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:

                            break;
                    }
                    break;
            }
        }
        private void PistolPartModifiers(ManufacturerEnum manufacturer, WeaponPartEnum part)
        {
            switch (part)
            {
                case WeaponPartEnum.Barrel:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:
                    
                    
                            break;
                        case ManufacturerEnum.Longhorn:
                            break;
                        case ManufacturerEnum.Smith:
                    
                            break;
                        case ManufacturerEnum.Edison:
                    
                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Grip:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:

                            break;
                        case ManufacturerEnum.Longhorn:
                    
                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:
                    
                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Sight:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:
                    
                            break;
                    }
                    break;
                case WeaponPartEnum.Stock:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:
                    
                            break;
                    }
                    break;
            }
        }
        private void LongRiflePartModifiers(ManufacturerEnum manufacturer, WeaponPartEnum part)
        {
            switch (part)
            {
                case WeaponPartEnum.Barrel:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.Accuracy, .02));
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.MagazineSize, -.01));
                            break;
                        case ManufacturerEnum.Longhorn:
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.WeaponDamage, .02));
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.Accuracy, .01));
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.CriticalHitChance, .01));
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.CriticalHitDamage, .05));
                            break;
                        case ManufacturerEnum.Smith:
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.Accuracy, .01));
                            break;
                        case ManufacturerEnum.Edison:
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.ElementalEffectChance, .02));
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.ElementalEffectDamage, .01));
                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Grip:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Nell:

                            break;
                        case ManufacturerEnum.Longhorn:
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.Accuracy, .01));
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.MagazineSize, .01));
                            break;
                        case ManufacturerEnum.Smith:

                            break;
                        case ManufacturerEnum.Edison:
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.ElementalEffectChance, .01));
                            break;
                        default:
                            break;
                    }
                    break;
                case WeaponPartEnum.Sight:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.Accuracy, .02));
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.CriticalHitChance, .02));
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.CriticalHitDamage, .05));
                            break;
                    }
                    break;
                case WeaponPartEnum.Stock:
                    switch (manufacturer)
                    {
                        case ManufacturerEnum.Longhorn:
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.MagazineSize, .01));
                            _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.CriticalHitDamage, .01));
                            break;
                    }
                    break;
            }
        
        }
#endregion

        public void GenerateModifiers(ManufacturerEnum manufacturer, WeaponPartEnum part, WeaponTypeEnum weaponType)
        {
            if (manufacturer == _manufacturerBonusToMatch)
                _modifiers.Add(new WeaponModifiers(WeaponModifierEnum.WeaponDamage, .01));
            
            switch (weaponType)
            { 
                case WeaponTypeEnum.LongRifle:
                    LongRiflePartModifiers(manufacturer, part);
                    break;
                case WeaponTypeEnum.Pistol:
                    PistolPartModifiers(manufacturer, part);
                    break;
                case WeaponTypeEnum.SMG:
                    SMGPartModifiers(manufacturer, part);
                    break;
                case WeaponTypeEnum.AssaultRifle:
                    AssualtRiflePartModifiers(manufacturer, part);
                    break;
                default:
                    break;
            }
        }

        //private void GenerateModifiers(ManufacturerEnum manufacturer, WeaponPartEnum part)
        //{
            
        
        //}
    }
}
