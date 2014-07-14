using System;

using Amido.WebDriver.Utilities.Extensions;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Amido.Testing.Social.Twitter.PageObjects
{
    public class TwitterAllowAppPageObject
    {
        private static Func<IWebDriver> webDriver;

        public static void Init(Func<IWebDriver> getWebDriver)
        {
            webDriver = getWebDriver;
        }

        public TwitterAllowAppPageObject()
        {
            if (webDriver == null)
            {
                throw new Exception("You must call TwitterAllowAppPageObject.Init once before using this class");
            }

            PageFactory.InitElements(webDriver(), this);
        }

        [FindsBy(How = How.Id, Using = "username_or_email")]
        public IWebElement UserNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "allow")]
        public IWebElement SignInAllow { get; set; }

        public bool IsLoaded()
        {
            return this.SignInAllow.WaitUntil(e => e.Displayed).Displayed;
        }
    }
}