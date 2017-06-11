// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ManageLoginsViewModel.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the ManageLoginsViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Identity.Models.ManageViewModels
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Http.Authentication;
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// The manage logins view model.
    /// </summary>
    public class ManageLoginsViewModel
    {
        /// <summary>
        /// Gets or sets the current logins.
        /// </summary>
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        /// <summary>
        /// Gets or sets the other logins.
        /// </summary>
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }
}
