using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowXvoucher.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement usernameInput;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordInput;

        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        private IWebElement loginButton;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Login(string username, string password)
        {
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            loginButton.Click();
        }
    }
}
