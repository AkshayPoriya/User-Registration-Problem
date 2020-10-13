using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class TestUserEntries
    {
        [TestMethod]
        [DataRow("Akshay",true)]
        [DataRow("akshay",false)]
        [DataRow("Aks1hay",false)]
        [DataRow("Poriya",true)]
        [DataRow("Ak",false)]
        [DataRow("1AksHay",false)]
        public void TestIsValidName(string name, bool expected)
        {
            //Arrange
            //Act
            bool actual = UserEntries.IsValidName(name);
            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}
