using System.DirectoryServices.Protocols;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.Infrastructure.Security.Ldap;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class LdapUtilityUnitTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void LdapUtility_GetGroups_ReturnsGetGroupsBehaviorResult()
        {
            string[] getLdapGroupsBehaviorResult = { "allfnc", "devs" };

            var mockConnectToGroupLdapBehavior = new Mock<IConnectToGroupLdapBehavior>();
            mockConnectToGroupLdapBehavior.Setup(x => x.Connect()).Returns(new LdapConnection("GroupServer"));

            var mockConnectToAuthLdapBehavior = new Mock<IConnectToAuthLdapBehavior>();
            mockConnectToGroupLdapBehavior.Setup(x => x.Connect()).Returns(new LdapConnection("AuthServer"));

            var mockGetLdapGroupsBehavior = new Mock<IGetLdapGroupsBehavior>();
            mockGetLdapGroupsBehavior.Setup(x =>
                    x.GetGroups(It.IsAny<LdapConnection>(), It.IsAny<LdapConnection>(), It.IsAny<string>()))
                .Returns(getLdapGroupsBehaviorResult);

            var ldapUtility = new LdapUtility(mockConnectToAuthLdapBehavior.Object, mockConnectToGroupLdapBehavior.Object, mockGetLdapGroupsBehavior.Object);

            //Act
            var result = ldapUtility.GetGroups("", "");

            Assert.IsTrue(getLdapGroupsBehaviorResult.SequenceEqual(result));
        }
    }
}
