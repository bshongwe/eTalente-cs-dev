// Ernest B. Shongwe
// Test: Authentification API
using BankingMicroservice.Models.Authentication;
using BankingMicroservice.Services;
using Xunit;

namespace BankingMicroservice.Tests
{
    public class AuthServiceTests
    {
        [Fact]
        public void Authenticate_Returns_AuthenticateResponse_With_Token()
        {
            // Arrange
            var authService = new AuthService();
            var request = new AuthenticateRequest { Username = "user", Password = "password" };

            // Act
            var response = authService.Authenticate(request);

            // Assert
            Assert.NotNull(response);
            Assert.NotNull(response.Token);
            Assert.NotEmpty(response.Token);
        }

        [Fact]
        public void Authenticate_Returns_Null_With_Invalid_Credentials()
        {
            // Arrange
            var authService = new AuthService();
            var request = new AuthenticateRequest { Username = "invalid", Password = "invalid" };

            // Act
            var response = authService.Authenticate(request);

            // Assert
            Assert.Null(response);
        }

        // Will add more test cases for other AuthService methods
    }
}
