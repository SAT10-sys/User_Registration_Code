using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_Code;
using System.Data;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void FirstNameShouldReturnFirstNameIsValid()
        {
            ValidatePattern validatePattern = new ValidatePattern();
            string firstName = "Satantra";

            string result = validatePattern.ValidateFirstName(firstName);

            Assert.AreEqual("First Name Is Valid", result);
        }

        [TestMethod]
        [DataRow("satantra")]
        [DataRow("sa")]
        [DataRow("")]
        public void FirstNameShouldReturnFirstNameIsInvalid(string firstName)
        {
            ValidatePattern validatePattern = new ValidatePattern();
            try
            {
                validatePattern.ValidateFirstName(firstName);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("First Name Is Invalid", e.Message);
            }
        }

        [TestMethod]
        [DataRow("abc@gmail.com")]
        [DataRow("abc@gmail.co.in")]
        [DataRow("abc.xyz@gmail.com")]
        [DataRow("abc.xyz.pqr@gmail.com")]
        public void EmailShouldReturnEmailIdIsValid(string email)
        {
            ValidatePattern validatePattern = new ValidatePattern();

            string result = validatePattern.ValidateEmailID(email);

            Assert.AreEqual("Email Id Is Valid", result);
        }

        [TestMethod]
        [DataRow("abc@gmail.co.in.au")]
        [DataRow("abc@.com")]
        [DataRow("abcgmail.com")]
        [DataRow(".abc@gmail.com")]
        public void ValidateEmailShouldReturnEmailIdIsInvalid(string eMail)
        {
            try
            {
                ValidatePattern validatePattern = new ValidatePattern();

                string result = validatePattern.ValidateEmailID(eMail);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email Id Is Invalid", e.Message);
            }
        }

        [TestMethod]
        public void PhoneNoShouldReturnPhoneNoIsValid()
        {
            ValidatePattern validatePattern = new ValidatePattern();
            string phoneNo = "91 8944921556";
            string result = validatePattern.ValidateMobileNumber(phoneNo);

            Assert.AreEqual("Phone No Is Valid", result);
        }

        [TestMethod]
        [DataRow("12 0123456789")]
        [DataRow("769876342135")]
        [DataRow("34 123456")]
        public void PhoneNoShouldReturnPhoneNoIsInvalid(string phoneNo)
        {
            try
            {
                ValidatePattern validatePattern = new ValidatePattern();

                string result = validatePattern.ValidateMobileNumber(phoneNo);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Phone No Is Invalid", e.Message);
            }
        }
        [TestMethod]
        public void PasswordShouldReturnPasswordIsValid()
        {
            ValidatePattern validatePattern = new ValidatePattern();
            string password = "A12$fgrt3";

            string result = validatePattern.ValidatePassword(password);

            Assert.AreEqual("Password Is Valid", result);
        }

        [TestMethod]
        [DataRow("123")]
        [DataRow("abcd1234")]
        [DataRow("@wert4r5")]
        [DataRow("abc1R$f5#")]
        [DataRow("123Abc$")]
        public void PasswordShouldReturnIsInvalid(string password)
        {
            try
            {
                ValidatePattern validatePattern = new ValidatePattern();

                string result = validatePattern.ValidatePassword(password);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password Is Invalid", e.Message);
            }
        }
    }
}

