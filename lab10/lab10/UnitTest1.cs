using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace lab10
{
    public class Tests
    {
        private IWebDriver GetEdgeDriver()
        {
            return new EdgeDriver(_driverPath, new EdgeOptions());
        }
        private IWebDriver _webDriver { get; set; } = null!;
        private string _searchGenre = "Боевик";
        private string _driverPath { get; set; } = @"D:\\Games\\Webdriver\\msedgedriver.exe";

        [SetUp]
        public void Setup()
        {
            _webDriver = GetEdgeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://www.litmir.me");
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void AuthorsLatestRatings()
        {
            TearDown();
        }

        [Test]
        public void SearchForBooksByGenre()
        {
            var book = new LitmirWithPageObject(_webDriver);
            book.SearchForBooksByGenre(_searchGenre);
            TearDown();
        }
    }
}