using Server.Managers.Implementations;
using Server.Managers.Interfaces;
using System;

namespace Server
{
    public class ConsoleWrapper
    {
        private static CreatureStepFlowManager _creatureStepFlowManager;
        private static ICorePropertiesManager _corePropertiesManager;
        private static ICalculationManager _calculationManager;
        private static ISpecialProperitesManager _specialProperitesManager;

        static void Main()
        {
            Console.WriteLine("Welcome! Please type 'C' for creature creation or 'N' for NPC creation.");

            if (Console.ReadLine().ToUpper() == "C")
            {
                _corePropertiesManager = new CorePropertiesManager();
                _calculationManager = new CalculationManager();
                _specialProperitesManager = new SpecialProperitesManager();
                _creatureStepFlowManager = new CreatureStepFlowManager(_corePropertiesManager, _calculationManager, _specialProperitesManager);

                _creatureStepFlowManager.Execute();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}