using CGenius.Controllers;
using Moq;
using Xunit;

namespace CGenius.Tests.Unit.Tests
{
    public class AuthControllerTests
    {
        private readonly Mock<IAuthService> _authServiceMock;
        private readonly AuthController _controller;

        public AuthControllerTests()
        {
            _authServiceMock = new Mock<IAuthService>();
            _controller = new AuthController(_authServiceMock.Object);
        }

        [Fact]
        public void Login_ReturnsToken_WhenCredentialsAreValid()
        {
            // Arrange
            var userLogin = new UserLogin { Username = "test", Password = "password" };
            var expectedToken = "some.jwt.token";
            _authServiceMock.Setup(x => x.Login(userLogin)).Returns(expectedToken);

            // Act
            var result = _controller.Login(userLogin);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedToken, result);
        }
    }
}
