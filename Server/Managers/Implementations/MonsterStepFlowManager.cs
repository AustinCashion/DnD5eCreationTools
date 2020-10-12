using System;

using Server.Managers.Interfaces;

namespace Server.Managers.Implementations
{
    /// <summary>
    /// Manages monster step order execution.
    /// </summary>
    public class MonsterStepFlowManager : IMonsterStepFlowManager
    {
        private readonly ICorePropertiesManager _corePropertiesManager;
        private readonly ICalculationManager _calculationManager;
        private readonly ISpecialProperitesManager _specialProperitesManager;

        /// <summary>
        /// Initializes new instance of MonsterStepFlowManager.
        /// </summary>
        /// <param name="corePropertiesManager">Core property manager to use.</param>
        /// <param name="calculationManager">Calculation manager to use.</param>
        /// <param name="specialProperitesManager">Special properity manager to use.</param>
        public MonsterStepFlowManager(ICorePropertiesManager corePropertiesManager, ICalculationManager calculationManager, ISpecialProperitesManager specialProperitesManager)
        {
            _corePropertiesManager = corePropertiesManager ?? throw new ArgumentNullException("corePropertiesManager");
            _calculationManager = calculationManager ?? throw new ArgumentNullException("calculationManager");
            _specialProperitesManager = specialProperitesManager ?? throw new ArgumentNullException("specialProperitesManager");
        }

        /// <summary>
        /// Excutes steps to create a monster.
        /// </summary>
        public void Execute()
        {
            // Validation.
            // TODO: Validate object

            // Creation.
            // TODO: Set Name
            // TODO: Set Size
            // TODO: Set Speed
            // TODO: Set Type
            // TODO: Set Alignment
            // TODO: Set Languages
            // TODO: Set Level
            // TODO: Set Stats

            // Calculation.
            // TODO: Calculate Modifiers
            // TODO: Calculate Skills
            // TODO: Calculate Saving Throws
            // TODO: Calculate Hit Points
            // TODO: Calculate Attack Bonues
            // TODO: Calculate Damage
            // TODO: Calculate Save DCs
            // TODO: Calculate Passive Skills

            // Manual Entry.
            // TODO: Set Special Traits, Actions, and Reactions
            // TODO: Set Damage Vulnerabilities, Resistances, Immunities
            // TODO: Set Condition Vulnerabilities, Resistances, Immunities

            // TODO: Persist.
        }
    }
}