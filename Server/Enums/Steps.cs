namespace Server.Enums
{
    public enum Steps : int
    {
        /// <summary>
        /// Creature name.
        /// </summary>
        Name = 1,

        /// <summary>
        /// Creature size.
        /// </summary>
        Size = 2,

        /// <summary>
        /// Creature speed.
        /// </summary>
        Speed = 3,

        /// <summary>
        /// Creature type.
        /// </summary>
        Type = 4,

        /// <summary>
        /// Creature alignment.
        /// </summary>
        Alignment = 5,

        /// <summary>
        /// Creature languages.
        /// </summary>
        Languages = 6,

        /// <summary>
        /// Creature level.
        /// </summary>
        Level = 7,

        /// <summary>
        /// Creature ability scores.
        /// </summary>
        AbilityScores = 8,

        /// <summary>
        /// Calculate creature ability score modifiers.
        /// </summary>
        AbilityScoreModifiers = 9,

        /// <summary>
        /// Calculate creature skill bonuses.
        /// </summary>
        SKillBonuses = 10,

        /// <summary>
        /// Calculate creature saving throws.
        /// </summary>
        SavingThrows = 11,

        /// <summary>
        /// Calculate creature hit points.
        /// </summary>
        HitPoints = 12,

        /// <summary>
        /// Calculate creature attack bonuses.
        /// </summary>
        AttackBonuses = 13,

        /// <summary>
        /// Calculate creature recommended damage.
        /// </summary>
        REcommendedDamage = 14,

        /// <summary>
        /// Calculate creature save DCs.
        /// </summary>
        SaveDCs = 15,

        /// <summary>
        /// Set creature condition statuses.
        /// </summary>
        ConditionStatuses = 16,

        /// <summary>
        /// Set creature damage statuses.
        /// </summary>
        DamageStatuses = 17,

        /// <summary>
        /// Set creature special traits.
        /// </summary>
        SpecialTraits = 18,
    }
}
