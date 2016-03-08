using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace TumblrCsharp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PostToBlog()
        {
            IWebDriver browser = new FirefoxDriver();
            browser.Navigate().GoToUrl("http://tumblr.com/login");
            IWebElement email = browser.FindElement(By.Id("signup_determine_email"));
            email.SendKeys("tking@spartaglobal.com");
            IWebElement verifyButton = browser.FindElement(By.Id("signup_forms_submit"));
            verifyButton.Click();
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            IWebElement password = browser.FindElement(By.Id("signup_password"));
            password.SendKeys("******");
            IWebElement loginButton = browser.FindElement(By.Id("signup_forms_submit"));
            loginButton.Click();
            IWebElement textIcon = browser.FindElement(By.ClassName("icon_post_text"));
            textIcon.Click();
            IWebElement postTitle = browser.FindElement(By.ClassName("editor-plaintext"));
            postTitle.SendKeys("c# selenium");
            IWebElement postBody = browser.FindElement(By.ClassName("editor-richtext"));
            postBody.SendKeys("this is a c# with selenium test");
            IWebElement createPost = browser.FindElement(By.ClassName("create_post_button"));
            createPost.Click();
            //TearDown
            IWebElement postSettings = browser.FindElement(By.ClassName("post_control_menu"));
            postSettings.Click();
            IWebElement postDelete = browser.FindElement(By.ClassName("delete"));
            postDelete.Click();
            IWebElement okButton = browser.FindElement(By.ClassName("btn_1"));
            okButton.Click();
            IWebElement accountButton = browser.FindElement(By.ClassName("icon_user_settings"));
            browser.Close();
        }
    }
}
