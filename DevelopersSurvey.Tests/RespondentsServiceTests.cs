// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RespondentsServiceTests.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the RespondentsServiceTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Tests
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using DevelopersSurvey.Contracts.DataContracts;
    using DevelopersSurvey.Contracts.Repositories;
    using DevelopersSurvey.DA;
    using DevelopersSurvey.DA.Models;
    using DevelopersSurvey.DA.Repositories;
    using DevelopersSurvey.Services.Services;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    /// <summary>
    /// The respondents service tests.
    /// </summary>
    [TestClass]
    public class RespondentsServiceTests
    {
        /// <summary>
        /// The dbcontext options.
        /// </summary>
        private DbContextOptions<ApplicationDbContext> options;

        /// <summary>
        /// The mapper
        /// </summary>
        private IMapper mapper;

        /// <summary>
        /// Initialize inmemory database
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            this.options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDb").Options;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RespondentDto, Respondent>();
            });
            this.mapper = config.CreateMapper();
        }

        /// <summary>
        /// Clean up inmemory repository
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                context.Database.EnsureDeleted();
            }
        }

        /// <summary>
        /// The add respondent should succed test
        /// </summary>
        [TestMethod]
        public void AddRespondentShouldSucced()
        {
            using (var context = new ApplicationDbContext(this.options))
            {
                var repository = new RespondentsRepository(context, this.mapper);
                var service = new RespondentsService(repository);
                service.Add(new RespondentDto
                {
                    FirstName = "TestName",
                    LastName = "TestSurname",
                    Address = "LA",
                    Age = 23,
                    IsCurrentlyEmployed = true,
                    CurrentPosition = "QA",
                    DatabasesString = "T-SQL",
                    FrameworksString = "EF",
                    Id = 0,
                    Mail = "mail@test.com",
                    PlaceOfStudying = "IFNTUOG",
                    SpecialCources = "ITA",
                    PhoneNumber = "3223232323",
                    ProgrammingLanguagesString = "C#, SQL",
                    Skype = "testskype",
                    OtherInfo = "test"
                });
            }

            using (var context = new ApplicationDbContext(this.options))
            {
                Assert.AreEqual(1, context.Respondents.Count());
            }
        }

        /// <summary>
        /// The get all should return all respondents.
        /// </summary>
        [TestMethod]
        public void GetAllShouldReturnAllRespondents()
        {
            var mockRepository = new Mock<IRespondentsRepository>();
            mockRepository.Setup(x => x.GetAll()).Returns(
                new List<RespondentDto>
                {
                    new RespondentDto
                    {
                        FirstName = "TestName",
                        LastName = "TestSurname",
                        Address = "LA",
                        Age = 23,
                        IsCurrentlyEmployed = true,
                        CurrentPosition = "QA",
                        DatabasesString = "T-SQL",
                        FrameworksString = "EF",
                        Id = 0,
                        Mail = "mail@test.com",
                        PlaceOfStudying = "IFNTUOG",
                        SpecialCources = "ITA",
                        PhoneNumber = "3223232323",
                        ProgrammingLanguagesString = "C#, SQL",
                        Skype = "testskype",
                        OtherInfo = "test"
                    }
                });
            var service = new RespondentsService(mockRepository.Object);

            var result = service.GetAll();

            var respondents = result as IList<RespondentDto> ?? result.ToList();
            Assert.AreEqual(1, respondents.Count());
            Assert.AreEqual("TestName", respondents.First().FirstName);
        }
    }
}
