// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Frameworks.cs" company="Peaceful Dev">
//   Copyrigts by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the Frameworks type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.DA.Models
{
    /// <summary>
    /// The frameworks type
    /// </summary>
    public class Frameworks
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the respondent id.
        /// </summary>
        public int RespondentId { get; set; }

        /// <summary>
        /// Gets or sets the experiance id.
        /// </summary>
        public int ExperianceId { get; set; }

        /// <summary>
        /// Gets or sets the respondent.
        /// </summary>
        public virtual Respondent Respondent { get; set; }

        /// <summary>
        /// Gets or sets the experiance.
        /// </summary>
        public virtual Experiance Experiance { get; set; }
    }
}
