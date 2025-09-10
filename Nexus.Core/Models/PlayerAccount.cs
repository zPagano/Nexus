using System.Collections.Generic;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Nexus.Core
{
    /// <summary>
    /// Represents a League of Legends player account.<br/>
    /// Linked to a Person.
    /// </summary>
    public class PlayerAccount
    {
        /// <summary>
        /// Player Universal Unique ID (PUUID) from Riot Games API.
        /// </summary>
        public required string PUUID { get; set; }

        /// <summary>
        /// Player's in-game name (IGN).
        /// </summary>
        public required string GameName { get; set; }

        /// <summary>
        /// Player's tag line (discriminator).
        /// </summary>
        public required string TagLine { get; set; }

        /// <summary>
        /// Date and time of when the account was last fetched from Riot Games API.
        /// </summary>
        public DateTime LastFetched { get; set; }

        #region Relationships
        /// <summary>
        /// Foreign key to the associated Person entity.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Navigation property to the associated Person entity.
        /// </summary>
        public Person Person { get; set; } = null!;
        #endregion
    }
}
