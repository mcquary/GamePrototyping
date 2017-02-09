using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    public class Part
    {
        private Guid _id;
        private ManufacturerEnum _manufacturer;
        private PartTypeEnum _partType;
        private WeaponPartEnum _weaponPart;


        public Part(WeaponPartEnum partType)
        {
            _id = Guid.NewGuid();
            _weaponPart = partType;
        }
        public Part(ManufacturerEnum manufacturer, WeaponPartEnum partType)
        {
            _id = Guid.NewGuid();
            _manufacturer = manufacturer;
            _weaponPart = partType;
        }
        public Part(PartTypeEnum partType)
        {
            _id = Guid.NewGuid();
            _partType = partType;
            _manufacturer = ManufacturerEnum.Bell;
        }
        public Part(ManufacturerEnum manufacturer, PartTypeEnum partType)
        {
            _id = Guid.NewGuid();
            _manufacturer = manufacturer;
            _partType = partType;
        }

        public ManufacturerEnum Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        public PartTypeEnum PartType
        {
            get { return _partType;  }
            set { _partType = value; }
        }

        public WeaponPartEnum WeaponPartType
        {
            get { return _weaponPart; }
            set { _weaponPart = value; }
        }
    }
}
