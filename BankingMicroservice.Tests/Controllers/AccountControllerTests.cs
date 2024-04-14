// Ernest B. Shongwe
// Test: API Endpoints
using System;
using System.Collections.Generic;
using BankingMicroservice.Controllers;
using BankingMicroservice.Models;
using BankingMicroservice.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace BankingMicroservice.Tests
{
    public class AccountControllerTests
    {
        [Fact]
        public void GetAccount_Returns_OkObjectResult_With_Account()
        {
            // Arrange
            var mockAccountRepository = new Mock<AccountRepository>();
            mockAccountRepository.Setup(repo => repo.GetAccountById(It.IsAny<int>()))
                .Returns(new Account { Id = 1, AccountNumber = "123456", Name = "John Doe", AvailableBalance = 1000 });

            var controller = new AccountController(mockAccountRepository.Object, null, null);

            // Act
            var result = controller.GetAccount(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var account = Assert.IsType<Account>(okResult.Value);
            Assert.Equal(1, account.Id);
            Assert.Equal("123456", account.AccountNumber);
        }

        // Will add more test cases for other controller methods
    }
}
