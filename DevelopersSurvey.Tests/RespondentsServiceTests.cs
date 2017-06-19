using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DevelopersSurvey.Contracts.DataContracts;
using DevelopersSurvey.Contracts.Repositories;
using DevelopersSurvey.DA;
using DevelopersSurvey.DA.Models;
using DevelopersSurvey.DA.Repositories;
using DevelopersSurvey.Services.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace DevelopersSurvey.Tests
{
    [TestClass]
    public class RespondentsServiceTests
    {
        private DbContextOptions<ApplicationDbContext> _options;
        private IMapper _mapper;

        [TestInitialize]
        public void Init()
        {
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDb").Options;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RespondentDto, Respondent>();
            });
            _mapper = config.CreateMapper();
        }

        [TestCleanup]
        public void CleanUp()
        {
            using (var context = new ApplicationDbContext(_options))
            {
                context.Database.EnsureDeleted();
            }
        }

        [TestMethod]
        public void AddRespondentShouldSucced()
        {
            using (var context = new ApplicationDbContext(_options))
            {
                var repository = new RespondentsRepository(context, _mapper);
                var service = new RespondentsService(repository);
                service.Add(new RespondentDto
                {
                    FirstName = "TestName",
                    LastName = "TestSurname",
                    Address = "LA",
                    Age = 23,
                    IsCurrentlyEmployed = true,
                    CurrentPosition = "QA",
                    Databases = "T-SQL",
                    Frameworks = "EF",
                    Id = 0,
                    Mail = "mail@test.com",
                    PlaceOfStudying = "IFNTUOG",
                    SpecialCources = "",
                    PhoneNumber = "3223232323",
                    ProgrammingLanguages = "C#, SQL",
                    Skype = "testskype",
                    OtherInfo = "test"
                });
            }

            using (var context = new ApplicationDbContext(_options))
            {
                Assert.AreEqual(1, context.Respondents.Count());
            }
        }

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
                        Databases = "T-SQL",
                        Frameworks = "EF",
                        Id =  0,
                        Mail = "mail@test.com",
                        PlaceOfStudying = "IFNTUOG",
                        SpecialCources = "",
                        PhoneNumber = "3223232323",
                        ProgrammingLanguages = "C#, SQL",
                        Skype = "testskype",
                        OtherInfo = "test"
                    }
                });
            var service = new RespondentsService(mockRepository.Object);

            var result = service.GetAll();

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("TestName", result.First().FirstName);
        }
    }
}
