using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace lab10
{
    public class LitmirWithPageObject
    {
        private IWebDriver _driver;
        
        public LitmirWithPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement _AuthorsInMenu => _driver.FindElement(By.XPath("//a[text()='АВТОРЫ']"));
        private IWebElement _AuthorsName => _driver.FindElement(By.XPath("//span[text()=' Глайнс Эбби ']"));
        private IWebElement _LatestRatings => _driver.FindElement(By.Id("ui-id-6"));


        private IWebElement _GenreInMenu => _driver.FindElement(By.XPath("//a[text()='ЖАНРЫ']"));
        private IWebElement _SearchField => _driver.FindElement(By.XPath("//input[@class='genre_search']"));
        private IWebElement _SearchGenre => _driver.FindElement(By.XPath("/html/body/div[1]/div/table/tbody/tr[1]/td/div/div/div/table/tbody/tr/td/div/table/tbody/tr[2]/td[1]/div[2]/div[2]/ul/li[1]/a/span"));
        private IWebElement _FoundBook => _driver.FindElement(By.XPath("//span[text()='День гнева']"));


        public LitmirWithPageObject AuthorsLatestRatings()
        {
            _AuthorsInMenu.Click();
            _AuthorsName.Click();
            _LatestRatings.Click();
            return new LitmirWithPageObject(_driver);
        }

        public LitmirWithPageObject SearchForBooksByGenre(string genre)
        {
            _GenreInMenu.Click();
            _SearchField.Click();
            _SearchField.SendKeys(genre);
            _SearchGenre.Click();
            _FoundBook.Click();
            return new LitmirWithPageObject(_driver);
        }
    }
}
