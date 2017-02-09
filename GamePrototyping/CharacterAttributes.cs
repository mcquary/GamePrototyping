using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototyping
{
    //Initial points available = 70
    // 25 per attribute scale

    public enum PlayerAttributesEnum
    {
        Instinct, //affects perception, combat initiative, chance to evade 
        Luck, // yay luck, best of everything
        Awareness, //provides range bonus, initiative bonus, speed bonus
        Strength, //health per level, health recovery, melee bonus, 
        Speed, //combat initiative, moves per turn, 
        Intelligence, //xp gained, skill points avail
        Speech // affects vendor costs, speech options
    }

    // skill base, weapon hit percentage = 50?
    public enum SkillsEnum
    { 
        OneHanded, //increase accuracy, critical chance with type
        TwoHanded, //increase accuracy, critical chance with type
        SMG, //increase accuracy, critical chance with type
        LongRifle, //increase accuracy, critical chance with type
        AssaultRifle, //increase accuracy, critical chance with type
        Sharpshooter, //increase critical chance, critical damange with LongRifles and Assault Rifles
        Hulk, //increase critical chance and critical damage with one handed and two handed
        Pistolero, //increase critical chance and critical damage with pistols, smgs
        Healer, //increase healing capabilities on group; equiv to surgeon and field medic
        Defender, //increase in armor bonus, health recovery, ADD ANOTHER
        Chemist, // increase in grenade area of effect; elemental effect/damage bonus
        Lockpicking //increase chance of lockpick success
    }



    class CharacterAttributes
    {

        private string _baseChanceToEvade;
        private string _baseChanceToRangeHit;
        private string _baseChanceToHit;
        private string _baseChanceToCriticallyRangeHit;
        private string _baseChanceToCriticallyHit;
        private string _actionPoints;
        private string _combatSpeed;
        private string _combatInitiative;


    }
}
