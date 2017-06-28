// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Respondent.cs" company="Peaceful Dev">
//   Copyright by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the Respondent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.DA.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The respondent data model.
    /// </summary>
    public sealed class Respondent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Respondent"/> class.
        /// </summary>
        public Respondent()
        {
            this.ProgrammingLanguages = new HashSet<ProgrammingLanguages>();
            this.Databases = new HashSet<Databases>();
            this.Frameworks = new HashSet<Frameworks>();
        }

        #region Personal info

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        public byte? Age { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the is currently employed.
        /// </summary>
        public bool? IsCurrentlyEmployed { get; set; }

        /// <summary>
        /// Gets or sets the current position.
        /// </summary>
        public string CurrentPosition { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Gets or sets the skype.
        /// </summary>
        public string Skype { get; set; }

        #endregion

        #region Education

        /// <summary>
        /// Gets or sets the place of studying.
        /// </summary>
        public string PlaceOfStudying { get; set; }

        /// <summary>
        /// Gets or sets the special cources.
        /// </summary>
        public string SpecialCources { get; set; }

        #endregion

        #region WorkExperiance 

        /// <summary>
        /// Gets or sets the programming languages.
        /// </summary>
        public ICollection<ProgrammingLanguages> ProgrammingLanguages { get; set; }

        /// <summary>
        /// Gets or sets the databases.
        /// </summary>
        public ICollection<Databases> Databases { get; set; }

        /// <summary>
        /// Gets or sets the frameworks.
        /// </summary>
        public ICollection<Frameworks> Frameworks { get; set; }

        #endregion

        #region Other info

        /// <summary>
        /// Gets or sets the other info.
        /// </summary>
        public string OtherInfo { get; set; }

        #endregion
    }
}
