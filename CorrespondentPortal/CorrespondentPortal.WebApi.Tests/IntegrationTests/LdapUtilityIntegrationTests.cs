using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Security.Ldap;
using CorrespondentPortal.WebApi.Infrastructure.Shared;
using CorrespondentPortal.WebApi.Tests.Shared;

namespace CorrespondentPortal.WebApi.Tests.IntegrationTests
{
    [TestClass]
    public class LdapUtilityIntegrationTests
    {
        [TestMethod]
        [TestCategory("Integration")]
        public void LdapUtility_ConnectToGroup_FncConnectToGroupLdapBehavior()
        {
            //Arrange
            var fncConnectToLdapBehavior = new FncConnectToGroupLdapBehavior(TestHelper.GetConfigurationSettings());

            //Act Assert
            try
            {
                using (fncConnectToLdapBehavior.Connect())
                {
                    Assert.IsTrue(true);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void LdapUtility_ConnectToAuth_CoreLogicConnectToAuthLdapBehavior()
        {
            //Arrange
            var coreLogicToAuthBehavior = new CoreLogicConnectToAuthLdapBehavior(TestHelper.GetConfigurationSettings());

            //Act Assert
            try
            {
                using (coreLogicToAuthBehavior.Connect("ISC-SA-FNCAutomation", "Core@123"))
                {
                    //Pass
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void LdapUtility_AutomationTestAccount_GetGroups()
        {
            //Arrange
            var ldapUtility = new LdapUtility(new CoreLogicConnectToAuthLdapBehavior(TestHelper.GetConfigurationSettings()), new FncConnectToGroupLdapBehavior(TestHelper.GetConfigurationSettings()), new GetLdapGroupsBehavior());

            //Act Assert
            try
            {
                var groups = ldapUtility.GetGroups("ISC-SA-FNCAutomation", "Core@123");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task LdapUtility_HealthCheck_Behaviors()
        {
            //Arrange
            var coreLogicToAuthBehavior = new CoreLogicConnectToAuthLdapBehavior(TestHelper.GetConfigurationSettings());
            var fncConnectToLdapBehavior = new FncConnectToGroupLdapBehavior(TestHelper.GetConfigurationSettings());
            var getLdapGroupsBehavior = new GetLdapGroupsBehavior();
            var healthCheckNotifierUtility = new Mock<IHealthCheckNotifierUtility>();

            var ldapUtility = new LdapUtility(coreLogicToAuthBehavior, fncConnectToLdapBehavior, getLdapGroupsBehavior);

            //Act
            var healthCheckUtility = new HealthCheckUtility(new List<IHealthCheckable>()
            {
                ldapUtility
            }, healthCheckNotifierUtility.Object, TestHelper.GetConfigurationSettings());

            //Assert
            Assert.AreEqual((await healthCheckUtility.GetHealthCheckResultAsync().ConfigureAwait(false)).Status, HealthStatus.Active);
        }
    }
}
