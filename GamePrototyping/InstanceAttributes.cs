using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    struct AttributeValue
    {
        public PlayerAttributesEnum Attribute { get; set; }
        public int Value { get; set; }
    }

    struct SkillValue
    {
        public SkillsEnum Skill { get; set;}
        public int Value { get; set;}
    }

    public enum EnemyTypes
    { 
        
    }
    public class InstanceAttributes
    {
        private const byte _attributeTrackMax = 25;
        private const byte _skillTrackMax = 20;
        private List<AttributeValue> _actorAttributes = new List<AttributeValue>();
        private List<SkillValue> _actorSkills = new List<SkillValue>();



    }
}
