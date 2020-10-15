using Server.Enums;
using System.Collections.Generic;

namespace Server.Entities
{
    public class Creature : DnDBeing
    {
        #region Properties

        /// <summary>
        /// Recommened challenge rating of the creature.
        /// </summary>
        public int ChallengeRating { get; private set; }

        /// <summary>
        /// Condition vulnerabilities of the creature.
        /// </summary>
        public Dictionary<Conditions, Vulnerability> ConditionVulnerabilities { get; private set; }

        /// <summary>
        /// Damage vulnerabilities of the creature.
        /// </summary>
        public Dictionary<DamageTypes, Vulnerability> DamageVulnerabilities { get; private set; }

        /// <summary>
        /// Relevant passive skills and their modifers for the creature.
        /// </summary>
        public Dictionary<Skills, int> PassiveSkills { get; private set; }

        /// <summary>
        /// Relevant traits and their descriptions for the creature.
        /// </summary>
        public Dictionary<string, string> Traits { get; private set; }

        #endregion

        #region Accessor methods

        /// <summary>
        /// Adds a condition vulnerability to the creature.
        /// </summary>
        /// <param name="condition">Condition to add.</param>
        /// <param name="vulnerability">Vulnerability to add.</param>
        public void AddConditionVulnerability(Conditions condition, Vulnerability vulnerability)
        {
            if (!ConditionVulnerabilities.ContainsKey(condition))
            {
                ConditionVulnerabilities.Add(condition, vulnerability);
            }
        }

        /// <summary>
        /// Clears the list of condition vulnerabilities for the creature.
        /// </summary>
        public void ResetConditionVulnerabilities()
        {
            ConditionVulnerabilities.Clear();
        }

        /// <summary>
        /// Adds a damage vulnerability to the creature.
        /// </summary>
        /// <param name="damageType">Damage type to add.</param>
        /// <param name="vulnerability">Vulnerability to add.</param>
        public void AddDamageVulnerability(DamageTypes damageType, Vulnerability vulnerability)
        {
            if (!DamageVulnerabilities.ContainsKey(damageType))
            {
                DamageVulnerabilities.Add(damageType, vulnerability);
            }
        }

        /// <summary>
        /// Clears the list of damage vulnerabilities for the creature.
        /// </summary>
        public void ResetDamageVulnerabilities()
        {
            DamageVulnerabilities.Clear();
        }

        /// <summary>
        /// Adds a passive skill and its modifier to the creature.
        /// </summary>
        /// <param name="skill">Skill to add.</param>
        /// <param name="modifier">Modifier to add.</param>
        public void AddPassiveSkill(Skills skill, int modifier)
        {
            if (!PassiveSkills.ContainsKey(skill))
            {
                PassiveSkills.Add(skill, modifier);
            }
        }

        /// <summary>
        /// Clears the list of passive skills for the creature.
        /// </summary>
        public void ResetPassiveSkills()
        {
            PassiveSkills.Clear();
        }

        /// <summary>
        /// Adds a trait and its description to the creature.
        /// </summary>
        /// <param name="trait">Trait to add.</param>
        /// <param name="description">Description to add.</param>
        public void AddTrait(string trait, string description)
        {
            if (!Traits.ContainsKey(trait))
            {
                Traits.Add(trait, description);
            }
        }

        /// <summary>
        /// Clears the list of traits for the creature.
        /// </summary>
        public void ResetTraits()
        {
            Traits.Clear();
        }

        #endregion
    }
}
