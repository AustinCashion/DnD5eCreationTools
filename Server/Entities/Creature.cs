using System.Collections.Generic;

namespace Server.Entities
{
    public class Creature : DnDBeing
    {
        /// <summary>
        /// Recommened challenge rating of the creature.
        /// </summary>
        public int ChallengeRating { get; set; }

        private HashSet<string> ConditionResistances { get; set; }

        private HashSet<string> ConditionImmunities { get; set; }

        private HashSet<string> DamageResistances { get; set; }

        private HashSet<string> DamageImmunities { get; set; }

        /// <summary>
        /// Relevant passive skills and their modifers for the creature.
        /// </summary>
        public Dictionary<string, int> PassiveSkills { get; set; }

        /// <summary>
        /// Relevant traits and their descriptions for the creature.
        /// </summary>
        public Dictionary<string, int> Traits { get; set; }


        /// <summary>
        /// Get set of damage resistances.
        /// </summary>
        /// <returns>Set of damage resistances.</returns>
        public HashSet<string> GetDamageResistances()
        {
            return damageResistances;
        }

        /// <summary>
        /// Adds a given damage resistance to the creature.
        /// </summary>
        /// <param name="resistance">Resistance to add.</param>
        public void AddDamageResistance(string resistance)
        {
            if (!damageResistances.Contains(resistance))
            {
                damageResistances.Add(resistance);
            }
        }
    }
}
