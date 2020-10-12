namespace Server.Managers.Interfaces
{
    /// <summary>
    /// Manages setting special properties.
    /// </summary>
    public interface ISpecialProperitesManager
    {
        /// <summary>
        /// Set special traits, actions, and reactions.
        /// </summary>
        public void SetSpecialTraits();

        /// <summary>
        /// Set damage vulnerabilities, resistances, immunities.
        /// </summary>
        public void SetDamageStatuses();

        /// <summary>
        /// Set condition vulnerabilities, resistances, immunities.
        /// </summary>
        public void SetConditionStatuses();
    }
}
