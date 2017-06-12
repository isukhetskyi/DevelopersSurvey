﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationUser.cs" company="Peaceful Programmers">
//   Copyrights by Peaceful Programmers 2017
// </copyright>
// <summary>
//   Defines the ApplicationUser type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.DA.Models
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    // Add profile data for application users by adding properties to the ApplicationUser class

    /// <summary>
    /// The application user.
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
    }
}
