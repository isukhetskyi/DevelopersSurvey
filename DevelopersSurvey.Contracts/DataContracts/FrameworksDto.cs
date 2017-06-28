// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrameworksDto.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the FrameworksDto type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Contracts.DataContracts
{
    /// <summary>
    /// The frameworks dto.
    /// </summary>
    public class FrameworksDto
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
    }
}
