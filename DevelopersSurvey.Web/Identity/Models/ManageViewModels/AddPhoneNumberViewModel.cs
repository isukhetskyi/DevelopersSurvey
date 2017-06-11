// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddPhoneNumberViewModel.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the AddPhoneNumberViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Identity.Models.ManageViewModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The add phone number view model.
    /// </summary>
    public class AddPhoneNumberViewModel
    {
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
