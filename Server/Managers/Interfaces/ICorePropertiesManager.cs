namespace Server.Managers.Interfaces
{
    /// <summary>
    /// Manages setting core properties.
    /// </summary>
    public interface ICorePropertiesManager
    {
        /// <summary>
        /// Set name characteristic.
        /// </summary>
        public void SetName();

        /// <summary>
        /// Set size characteristic.
        /// </summary>
        public void SetSize();

        /// <summary>
        /// Set speed characteristic.
        /// </summary>
        public void SetSpeed();

        /// <summary>
        /// Set type of creature characteristic.
        /// </summary>
        public void SetType();

        /// <summary>
        /// Set alignment characteristic.
        /// </summary>
        public void SetAlignment();

        /// <summary>
        /// Set languages.
        /// </summary>
        public void SetLanguages();

        /// <summary>
        /// Set level characteristic.
        /// </summary>
        public void SetLevel();

        /// <summary>
        /// Creates ability scores.
        /// </summary>
        public void CreateAbilityScores(bool isRandom);
    }
}