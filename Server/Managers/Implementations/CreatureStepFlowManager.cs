using System;

using Server.Managers.Interfaces;

namespace Server.Managers.Implementations
{
    /// <summary>
    /// Manages Creature step order execution.
    /// </summary>
    public class CreatureStepFlowManager : ICreatureStepFlowManager
    {
        private readonly ICorePropertiesManager _corePropertiesManager;
        private readonly ICalculationManager _calculationManager;
        private readonly ISpecialProperitesManager _specialProperitesManager;

        /// <summary>
        /// Initializes new instance of <cref>CreatureStepFlowManager.
        /// </summary>
        /// <param name="corePropertiesManager">Core property manager to use.</param>
        /// <param name="calculationManager">Calculation manager to use.</param>
        /// <param name="specialProperitesManager">Special properity manager to use.</param>
        public CreatureStepFlowManager(ICorePropertiesManager corePropertiesManager, ICalculationManager calculationManager, ISpecialProperitesManager specialProperitesManager)
        {
            _corePropertiesManager = corePropertiesManager ?? throw new ArgumentNullException(nameof(corePropertiesManager));
            _calculationManager = calculationManager ?? throw new ArgumentNullException(nameof(calculationManager));
            _specialProperitesManager = specialProperitesManager ?? throw new ArgumentNullException(nameof(specialProperitesManager));
        }

        /// <summary>
        /// Excutes steps to create a Creature.
        /// </summary>
        public void Execute()
        {
            // Validation.
            // TODO: Validate object

            // Creation.
            _corePropertiesManager.SetName();
            _corePropertiesManager.SetSize();
            _corePropertiesManager.SetSpeed();
            _corePropertiesManager.SetType();
            _corePropertiesManager.SetAlignment();
            _corePropertiesManager.SetLanguages();
            _corePropertiesManager.SetLevel();
            _corePropertiesManager.CreateAbilityScores(false);

            // Calculation.
            _calculationManager.CalculateAbilityScoreModifier();
            _calculationManager.CalculateSkillBonuses();
            _calculationManager.CalculateSavingThrows();
            _calculationManager.CalculateHitPoints(false);
            _calculationManager.CalculateAttackBonuses();
            _calculationManager.CalculateRecommendedDamage();
            _calculationManager.CalculateSaveDCs();

            // Manual Entry.
            _specialProperitesManager.SetConditionStatuses();
            _specialProperitesManager.SetDamageStatuses();
            _specialProperitesManager.SetSpecialTraits();

            // TODO: Persist.
        }
    }
}