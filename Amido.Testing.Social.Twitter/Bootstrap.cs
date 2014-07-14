using System;

using Amido.Testing.Social.Twitter.PageObjects;

using OpenQA.Selenium;

namespace Amido.Testing.Social.Twitter
{
    public static class Bootstrap
    {
        public static void Init(Func<IWebDriver> webDriver)
        {
            TwitterAllowAppPageObject.Init(webDriver);
        }
    }
}