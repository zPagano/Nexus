namespace Nexus.Core
{
    /// <summary>
    /// Represents a real-world individual, such as a player or a candidate.</br>
    /// A Person can have multiple PlayerAccounts linked to them.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Unique identifier for the Person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Known name of the Person.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Role or position of the Person (e.g., "Top Laner", "Mid Laner").
        /// </summary>
        public required string Role { get; set; }

        /// <summary>
        /// Flag to indicate if the Person is a candidate for recruitment.
        /// </summary>
        public bool IsCandidate { get; set; }

        #region Relationships
        /// <summary>
        /// Collection of all PlayerAccounts associated with this Person.
        /// </summary>
        public ICollection<PlayerAccount> PlayerAccounts { get; set; } = new List<PlayerAccount>();
        #endregion
    }
}
