using Server.Enums;
using System.Collections.Generic;

namespace Server.Entities
{
    /// <summary>
    /// Representation of a DnD being.
    /// </summary>
    public class DnDBeing
    {
        #region Properties

        /// <summary>
        /// Ability scores of the being.
        /// </summary>
        public Dictionary<AbilityScores, int> AbilityScores { get; private set; }

        /// <summary>
        /// ALignment of the being.
        /// </summary>
        public Alignments Alignment { get; private set; }

        /// <summary>
        /// Armor class of the being.
        /// </summary>
        public int ArmorClass { get; private set; }

        /// <summary>
        /// Hit point total of the being.
        /// </summary>
        public int HitPoints { get; private set; }

        /// <summary>
        /// Languages of the being.
        /// </summary>
        public HashSet<Languages> Languages { get; private set; }

        /// <summary>
        /// Level of the being.
        /// </summary>
        public int Level { get; private set; }

        /// <summary>
        /// Name of the being.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Size classification of the being.
        /// </summary>
        public Sizes Size { get; private set; }

        /// <summary>
        /// Speed of the being.
        /// </summary>
        public int Speed { get; private set; }

        /// <summary>
        /// Creature type of the being.
        /// </summary>
        public BeingTypes Type { get; private set; }

        #endregion

        #region Accessor methods

        /// <summary>
        /// Adds an ability and score to the being.
        /// </summary>
        /// <param name="ability">Ability to add.</param>
        /// <param name="score">Score to add.</param>
        public void AddAbilityScores(AbilityScores ability, int score)
        {
            if (!AbilityScores.ContainsKey(ability))
            {
                AbilityScores.Add(ability, score);
            }
        }

        /// <summary>
        /// Clears the list of ability scores for the being.
        /// </summary>
        public void ResetAbilityScores()
        {
            AbilityScores.Clear();
        }

        /// <summary>
        /// Sets an alignment to the being.
        /// </summary>
        /// <param name="alignment">Alignment to set.</param>
        public void SetAlignment(Alignments alignment)
        {
            Alignment = alignment;
        }

        /// <summary>
        /// Sets an armor class to the being.
        /// </summary>
        /// <param name="alignment">Armor class to set.</param>
        public void SetArmorClass(int armorClass)
        {
            ArmorClass = armorClass;
        }

        /// <summary>
        /// Sets a hit point value to the being.
        /// </summary>
        /// <param name="hitPoints">Hit points to set.</param>
        public void SetHitPoints(int hitPoints)
        {
            HitPoints = hitPoints;
        }

        /// <summary>
        /// Adds a language to the being.
        /// </summary>
        /// <param name="language">Language to add.</param>
        public void AddLanguage(Languages language)
        {
            if (!Languages.Contains(language))
            {
                Languages.Add(language);
            }
        }

        /// <summary>
        /// Clears the list of languages for the being.
        /// </summary>
        public void ResetLanguages()
        {
            Languages.Clear();
        }

        /// <summary>
        /// Sets the level of the being.
        /// </summary>
        /// <param name="level">Level to set.</param>
        public void SetLevel(int level)
        {
            Level = level;
        }

        /// <summary>
        /// Sets the size to the being.
        /// </summary>
        /// <param name="size">Size to set.</param>
        public void SetSize(Sizes size)
        {
            Size = size;
        }

        /// <summary>
        /// Sets the speed to the being.
        /// </summary>
        /// <param name="size">Speed to set.</param>
        public void SetSpeed(int speed)
        {
            Speed = speed;
        }

        /// <summary>
        /// Sets the type to the being.
        /// </summary>
        /// <param name="type">Type to set.</param>
        public void SetBeingType(BeingTypes type)
        {
            Type = type;
        }

        #endregion
    }
}
