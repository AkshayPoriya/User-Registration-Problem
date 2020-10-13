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

        [TestMethod]
        [DataRow("91 1234567890", true)]
        [DataRow("91-0123456789", false)]
        [DataRow("91 12897456871", false)]
        [DataRow("67 1000000000", true)]
        [DataRow("9876543210", false)]
        [DataRow("123 9874568584", false)]
        public void TestIsValidMobileNumber(string name, bool expected)
        {
            //Arrange
            //Act
            bool actual = UserEntries.IsValidMobileNumber(name);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Arjun@Karn11", true)]
        [DataRow("Arjun@karan@122", false)]
        [DataRow("arjun@karan11", false)]
        [DataRow("arjunKar#11", true)]
        [DataRow("KaranArjun11", false)]
        [DataRow("Karan@Arjun", false)]
        public void TestIsValidPassword(string name, bool expected)
        {
            //Arrange
            //Act
            bool actual = UserEntries.IsValidPassword(name);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc-100@yahoo.com", true)]
        [DataRow("abc@.com.my", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("bc@1.com", true)]
        [DataRow("abc@gmail.com.aa.au", false)]
        [DataRow("abc@%*.com", false)]
        public void TestIsValidEmail(string name, bool expected)
        {
            //Arrange
            //Act
            bool actual = UserEntries.IsValidEmail(name);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
