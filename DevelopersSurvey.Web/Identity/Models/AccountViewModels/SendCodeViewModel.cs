// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SendCodeViewModel.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the SendCodeViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Identity.Models.AccountViewModels
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    /// <summary>
    /// The send code view model.
    /// </summary>
    public class SendCodeViewModel
    {
        /// <summary>
        /// Gets or sets the selected provider.
        /// </summary>
        public string SelectedProvider { get; set; }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        public ICollection<SelectListItem> Providers { get; set; }

        /// <summary>
        /// Gets or sets the return url.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether remember me.
        /// </summary>
        public bool RememberMe { get; set; }
    }
}
