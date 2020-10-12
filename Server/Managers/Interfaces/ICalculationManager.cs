namespace Server.Managers.Interfaces
{
    /// <summary>
    /// Manages calculation moethods.
    /// </summary>
    public interface ICalculationManager
    {
        /// <summary>
        /// Calcuates hit points.
        /// </summary>
        public void CalculateHitPoints(bool isRandom);

        /// <summary>
        /// Calcuates ability score modifiers.
        /// </summary>
        public void CalculateAbilityScoreModifier();

        /// <summary>
        /// Calcuates skill bonuses.
        /// </summary>
        public void CalculateSkillBonuses();

        /// <summary>
        /// Calcuates saving throws.
        /// </summary>
        public void CalculateSavingThrows();

        /// <summary>
        /// Calcuates attack bonuses.
        /// </summary>
        public void CalculateAttackBonuses();

        /// <summary>
        /// Calcuates save DCs.
        /// </summary>
        public void CalculateSaveDCs();

        /// <summary>
        /// Calcuates recommended damage per round.
        /// </summary>
        public void CalculateRecommendedDamage();
    }
}
