using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_Code;
using System.Data;

namespace User_Registration_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Satantra",true)]
        [DataRow("satantra",false)]
        [DataRow("Sa",false)]
        public void FirstNameShouldReturnExpectedResult(string firstName, bool expectedResult)
        {
            ValidatePattern validatePattern = new ValidatePattern();
            bool result = validatePattern.ValidateFirstName(firstName);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [DataRow("Tewari", true)]
        [DataRow("tewari",false)]
        [DataRow("Te",false)]
        public void LastNameShouldReturnExpectedResult(string lastName, bool expectedResult)
        {
            ValidatePattern validatePattern = new ValidatePattern();
            bool result = validatePattern.ValidateLastName(lastName);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [DataRow("abc@gmail.com", true)]
        [DataRow("abc@gmail.co.in", true)]
        [DataRow("abc.xyz@gmail.com", true)]
        [DataRow("abc.xyz.pqr@gmail.com", false)]
        [DataRow("abc@gmail.co.in.au", false)]
        [DataRow("abc@.com", false)]
        [DataRow("abcgmail.com", false)]
        [DataRow(".abc@gmail.com", false)]
        public void EmailIDShouldReturnExpectedResult(string emailID, bool expectedResult)
        {
            ValidatePattern validatePattern = new ValidatePattern();
            bool result = validatePattern.ValidateEmailID(emailID);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [DataRow("91 8944921556", true)]
        [DataRow("12 0876765432", false)]
        [DataRow("769876342135", false)]
        [DataRow("03 587676547", false)]
        public void PhoneNoShouldReturnExpectedResult(string phoneNo, bool expectedResult)
        {
            ValidatePattern validatePattern = new ValidatePattern();
            bool result = validatePattern.ValidateMobileNumber(phoneNo);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [DataRow("A@1rty5g", true)]
        [DataRow("abc", false)]
        [DataRow("abcd1234", false)]
        [DataRow("Asdab@abc", false)]
        [DataRow("F1sd#rt", false)]
        [DataRow("abc#v612#", false)]
        public void PasswordShouldReturnExpectedResult(string passWord, bool expectedResult)
        {
            ValidatePattern validatePattern = new ValidatePattern();
            bool result = validatePattern.ValidatePassword(passWord);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
