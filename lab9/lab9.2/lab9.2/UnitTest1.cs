using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

namespace lab9._2
{
    public class Tests
    {
        [Test]
        public void ICanWin()
        {
            WebDriver driver = new EdgeDriver("D:\\Games\\Webdriver\\msedgedriver.exe");
            driver.Url = "https://www.litmir.me";

            driver.FindElement(By.XPath("//a[text()='������']")).Click();
            driver.FindElement(By.XPath("//span[text()=' ������ ���� ']")).Click();

            driver.FindElement(By.Id("ui-id-6")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Quit();
        }
    }
}