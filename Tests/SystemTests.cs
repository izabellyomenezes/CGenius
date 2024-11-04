using Xunit;


namespace CGenius.Tests.SystemTests
{
    public class AuthSystemTests : IClassFixture<ChromeDriverFixture>
    {
        private readonly IWebDriver _driver;

        public AuthSystemTests(ChromeDriverFixture fixture)
        {
            _driver = fixture.Driver;
        }

        [Fact]
        public void LoginPage_ShouldDisplayError_WhenCredentialsAreInvalid()
        {
            // Arrange
            _driver.Navigate().GoToUrl("https://localhost:7210/login");

            // Act
            _driver.FindElement(By.Name("username")).SendKeys("invalidUser");
            _driver.FindElement(By.Name("password")).SendKeys("invalidPassword");
            _driver.FindElement(By.Id("loginButton")).Click();

            // Assert
            var errorMessage = _driver.FindElement(By.Id("errorMessage")).Text;
            Assert.Equal("Invalid credentials", errorMessage);
        }
    }

    public class ChromeDriverFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public ChromeDriverFixture()
        {
            Driver = new ChromeDriver();
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
