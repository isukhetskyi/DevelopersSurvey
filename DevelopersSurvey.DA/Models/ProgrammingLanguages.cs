// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProgrammingLanguages.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the DatabasesEnum type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.DA.Models
{
    /// <summary>
    /// The databases model
    /// </summary>
    public class ProgrammingLanguages
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
