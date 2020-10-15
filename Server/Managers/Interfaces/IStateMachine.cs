using Server.Enums;

namespace Server.Managers.Interfaces
{
    /// <summary>
    /// Contains all methods for managing state.
    /// </summary>
    public interface IStateMachine
    {
        /// <summary>
        /// Changes state to SetName.
        /// </summary>
        /// <returns>SetName state.</returns>
        public States SetNameState();

        /// <summary>
        /// Changes state to SetSize.
        /// </summary>
        /// <returns>SetSize state.</returns>
        public States SetSizeState();

        /// <summary>
        /// Changes state to SetSpeed.
        /// </summary>
        /// <returns>SetSpeed state.</returns>
        public States SetSpeedState();

        /// <summary>
        /// Changes state to SetType.
        /// </summary>
        /// <returns>SetType state.</returns>
        public States SetTypeState();

        /// <summary>
        /// Changes state to SetAlignment.
        /// </summary>
        /// <returns>SetAlignment state.</returns>
        public States SetAlignmentState();

        /// <summary>
        /// Changes state to SetLanguages.
        /// </summary>
        /// <returns>SetLanguages state.</returns>
        public States SetLanguagesState();

        /// <summary>
        /// Changes state to CreateAbilityScores.
        /// </summary>
        /// <returns>CreateAbilityScores state.</returns>
        public States CreateAbilityScoresState();

        /// <summary>
        /// Changes state to CalculateAbilityScoreModifier.
        /// </summary>
        /// <returns>CalculateAbilityScoreModifier state.</returns>
        public States CalculateAbilityScoreModifierState();

        /// <summary>
        /// Changes state to CalculateSkillBonuses.
        /// </summary>
        /// <returns>CalculateSkillBonuses state.</returns>
        public States CalculateSkillBonusesState();

        /// <summary>
        /// Changes state to CalculateSavingThrows.
        /// </summary>
        /// <returns>CalculateSavingThrows state.</returns>
        public States CalculateSavingThrowsState();

        /// <summary>
        /// Changes state to CalculateHitPoints.
        /// </summary>
        /// <returns>CalculateHitPoints state.</returns>
        public States CalculateHitPointsState();

        /// <summary>
        /// Changes state to CalculateAttackBonuses.
        /// </summary>
        /// <returns>CalculateAttackBonuses state.</returns>
        public States CalculateAttackBonusesState();

        /// <summary>
        /// Changes state to CalculateRecommendedDamage.
        /// </summary>
        /// <returns>CalculateRecommendedDamage state.</returns>
        public States CalculateRecommendedDamageState();

        /// <summary>
        /// Changes state to CalculateSaveDCs.
        /// </summary>
        /// <returns>CalculateSaveDCs state.</returns>
        public States CalculateSaveDCsState();

        /// <summary>
        /// Changes state to SetConditionStatuses.
        /// </summary>
        /// <returns>SetConditionStatuses state.</returns>
        public States SetConditionStatusesState();

        /// <summary>
        /// Changes state to SetDamageStatuses.
        /// </summary>
        /// <returns>SetDamageStatuses state.</returns>
        public States SetDamageStatusesState();

        /// <summary>
        /// Changes state to SetSpecialTraits.
        /// </summary>
        /// <returns>SetSpecialTraits state.</returns>
        public States SetSpecialTraitsState();
    }
}
