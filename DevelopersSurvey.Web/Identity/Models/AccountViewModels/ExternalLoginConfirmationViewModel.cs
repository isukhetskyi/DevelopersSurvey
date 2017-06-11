// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExternalLoginConfirmationViewModel.cs" company="Peaceful Programmers">
//   Copyright by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the ExternalLoginConfirmationViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Identity.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The external login confirmation view model.
    /// </summary>
    public class ExternalLoginConfirmationViewModel
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
