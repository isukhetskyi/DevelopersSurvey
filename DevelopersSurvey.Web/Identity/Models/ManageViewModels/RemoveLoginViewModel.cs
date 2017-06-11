// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RemoveLoginViewModel.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the RemoveLoginViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Identity.Models.ManageViewModels
{
    /// <summary>
    /// The remove login view model.
    /// </summary>
    public class RemoveLoginViewModel
    {
        /// <summary>
        /// Gets or sets the login provider.
        /// </summary>
        public string LoginProvider { get; set; }

        /// <summary>
        /// Gets or sets the provider key.
        /// </summary>
        public string ProviderKey { get; set; }
    }
}
