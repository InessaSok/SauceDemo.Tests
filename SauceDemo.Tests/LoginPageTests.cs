using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SauceDemo.Tests.Pages;

namespace SauceDemo.Tests
{
    [TestClass]
    public class LoginPageTests
    {
        private IWebDriver driver;
        [TestInitialize]
        public void Initialize ()
        {
            driver = new ChromeDriver();
        }
        [TestMethod]
        public void Login_AsLockedOutUser_ShouldDisplayLockedOutMessage()
           
        {
            //Arrange
            //IWebDriver driver = new ChromeDriver();
            LoginPage loginPage = new LoginPage(driver);

            //Act
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            //loginPage.UserNameField.SendKeys("locked_out_user");
            //loginPage.PasswordField.SendKeys("secret_sauce");
            loginPage.Login("locked_out_user", "secret_sauce");
            //loginPage.LoginButton.Click();
            loginPage.LoginButtonClick();

            //Assert

            Assert.AreEqual("Epic sadface: Sorry, this user has been locked out.", loginPage.ErrorMessage.Text);
        }
        [TestCleanup]
        public void CleanUp ()
        {
            driver.Quit();
        }

    }
}
