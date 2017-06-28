// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationDbContext.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the ApplicationDbContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.DA
{
    using DevelopersSurvey.DA.Models;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The application database context class
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the respondents dbset.
        /// </summary>
        public DbSet<Respondent> Respondents { get; set; }

        /// <summary>
        /// Gets or sets the experiances dbset.
        /// </summary>
        public DbSet<ProgrammingLanguages> ProgrammingLanguages { get; set; }

        /// <summary>
        /// Gets or sets the frameworks.
        /// </summary>
        public DbSet<Frameworks> Frameworks { get; set; }

        /// <summary>
        /// Gets or sets the databases.
        /// </summary>
        public DbSet<Databases> Databases { get; set; }

        /// <summary>
        /// Gets or sets the experiances.
        /// </summary>
        public DbSet<Experiance> Experiances { get; set; }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="builder">
        /// The builder.
        /// </param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Respondent>().HasKey(m => m.Id);
            builder.Entity<ProgrammingLanguages>().HasKey(m => m.Id);
            builder.Entity<Frameworks>().HasKey(m => m.Id);
            builder.Entity<Databases>().HasKey(m => m.Id);
            builder.Entity<Experiance>().HasKey(m => m.Id);
        }
    }
}
