using Server.Managers.Implementations;
using Server.Managers.Interfaces;

namespace Server
{
    public class ConsoleWrapper
    {
        private static CreatureStepFlowManager _creatureStepFlowManager;
        private static readonly ICorePropertiesManager _corePropertiesManager;
        private static readonly ICalculationManager _calculationManager;
        private static readonly ISpecialProperitesManager _specialProperitesManager;

        static void Main()
        {
            _creatureStepFlowManager = new CreatureStepFlowManager(_corePropertiesManager, _calculationManager, _specialProperitesManager);
            _creatureStepFlowManager.Execute();

            // TODO: Creature or NPC?
            // TODO: Call step flow manager
            // TODO: Persist save object across visitors/states
            // TODO: Save object
            // TODO: Parse object into XML file (of javascript friendly file type)
        }
    }
}