using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.DAL.Repositories;
using CorrespondentPortal.WebApi.DAL.Repositories.InfrastructureLog;
using CorrespondentPortal.WebApi.Domain.Services;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class InfrastructureLogServiceUnitTests
    {
        private IInfrastructureLogService _infrastructureLogService;
        private EFInfrastructureLogRepository _infrastructureLogRepository;

        [TestInitialize]
        public async Task InitAsync()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFInfrastructureLogRepository>();
            optionsBuilder.UseSqlite("DataSource=:memory:");
            _infrastructureLogRepository = new EFInfrastructureLogRepository(optionsBuilder.Options);
            await _infrastructureLogRepository.Database.OpenConnectionAsync().ConfigureAwait(false);
            await _infrastructureLogRepository.Database.EnsureCreatedAsync().ConfigureAwait(false);
            _infrastructureLogService = new InfrastructureLogService(_infrastructureLogRepository);
        }

        [TestCleanup]
        public async Task CleanUpAsync()
        {
            await _infrastructureLogRepository.Database.EnsureDeletedAsync().ConfigureAwait(false);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task InfrastructureLogService_AddInformationLog_SuccessfullyAddsLog()
        {
            //Arrange
            const string testCategory = "Test.Category";
            const string testContent = "Test Content";
            const LogLevel testLogLevel = LogLevel.Information;

            //Act
            _infrastructureLogService.AddInformationLog(testCategory, testContent);
            await _infrastructureLogService.SaveChangesAsync().ConfigureAwait(false);
            var infrastructureLog = await _infrastructureLogRepository.InfrastructureLogs.SingleOrDefaultAsync(x => x.LogLevel == testLogLevel && x.Category == testCategory && x.Content == testContent).ConfigureAwait(false);

            //Assert
            Assert.IsNotNull(infrastructureLog);
            Assert.AreEqual(testCategory, infrastructureLog.Category);
            Assert.AreEqual(testContent, infrastructureLog.Content);
            Assert.AreEqual(testLogLevel, infrastructureLog.LogLevel);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task InfrastructureLogService_AddWarningLog_SuccessfullyAddsWarningLog()
        {
            //Arrange
            const string testCategory = "Test.Categroy";
            const string testContent = "Test Content";
            const LogLevel testLogLevel = LogLevel.Warning;

            //Act
            _infrastructureLogService.AddWarningLog(testCategory, testContent);
            await _infrastructureLogService.SaveChangesAsync().ConfigureAwait(false);
            var infrastructureLog = await _infrastructureLogRepository.InfrastructureLogs.SingleOrDefaultAsync(x => x.LogLevel == testLogLevel && x.Category == testCategory && x.Content == testContent).ConfigureAwait(false);

            //Assert
            Assert.IsNotNull(infrastructureLog);
            Assert.AreEqual(testCategory, infrastructureLog.Category);
            Assert.AreEqual(testContent, infrastructureLog.Content);
            Assert.AreEqual(testLogLevel, infrastructureLog.LogLevel);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task InfrastructureLogService_AddErrorLog_SuccessfullyAddsErrorLog()
        {
            //Arrange
            const string testCategory = "Test.Category";
            const string testContent = "Test Content";
            const LogLevel testLogLevel = LogLevel.Error;

            //Act
            _infrastructureLogService.AddErrorLog(testCategory, testContent);
            await _infrastructureLogService.SaveChangesAsync().ConfigureAwait(false);
            var infrastructureLog = await _infrastructureLogRepository.InfrastructureLogs.SingleOrDefaultAsync(x => x.LogLevel == testLogLevel && x.Category == testCategory && x.Content == testContent).ConfigureAwait(false);

            //Assert
            Assert.IsNotNull(infrastructureLog);
            Assert.AreEqual(testCategory, infrastructureLog.Category);
            Assert.AreEqual(testContent, infrastructureLog.Content);
            Assert.AreEqual(testLogLevel, infrastructureLog.LogLevel);
        }
    }
}
