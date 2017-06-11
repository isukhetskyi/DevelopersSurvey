// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndexViewModel.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the IndexViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Identity.Models.ManageViewModels
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// The index view model.
    /// </summary>
    public class IndexViewModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether has password.
        /// </summary>
        public bool HasPassword { get; set; }

        /// <summary>
        /// Gets or sets the logins.
        /// </summary>
        public IList<UserLoginInfo> Logins { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether two factor.
        /// </summary>
        public bool TwoFactor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether browser remembered.
        /// </summary>
        public bool BrowserRemembered { get; set; }
    }
}
