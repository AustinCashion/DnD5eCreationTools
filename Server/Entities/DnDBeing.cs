using Server.Enums;

namespace Server.Entities
{
    public class DnDBeing
    {
        /// <summary>
        /// Name of the being.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Size classification of the being.
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Speed of the being.
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Creature type of the being.
        /// </summary>
        public CreatureType Type { get; set; }

        // TODO: finish this class
    }
}
