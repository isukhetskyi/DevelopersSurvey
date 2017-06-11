// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VerifyPhoneNumberViewModel.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the VerifyPhoneNumberViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Identity.Models.ManageViewModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The verify phone number view model.
    /// </summary>
    public class VerifyPhoneNumberViewModel
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
