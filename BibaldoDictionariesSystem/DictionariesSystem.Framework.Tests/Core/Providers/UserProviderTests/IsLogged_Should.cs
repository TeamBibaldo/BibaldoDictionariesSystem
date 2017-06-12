﻿using DictionariesSystem.Contracts.Core.Factories;
using DictionariesSystem.Contracts.Data;
using DictionariesSystem.Framework.Core.Providers;
using DictionariesSystem.Framework.Tests.Core.Providers.UserProviderTests.Fakes;
using DictionariesSystem.Models.Users;
using Moq;
using NUnit.Framework;

namespace DictionariesSystem.Framework.Tests.Core.Providers.UserProviderTests
{
    [TestFixture]
    public class IsLogged_Should
    {
        [Test]
        public void ReturnFalse_WhenLoggedUserValueIsNull()
        {
            // arrange 
            var userRepository = new Mock<IRepository<User>>();
            var unitOfWork = new Mock<IUnitOfWork>();
            var userFactory = new Mock<IUserFactory>();

            var userProvider = new UserProvider(userRepository.Object, unitOfWork.Object, userFactory.Object);

            // act
            var isLogged = userProvider.IsLogged;

            // assert
            Assert.IsFalse(isLogged);
        }

        [Test]
        public void ReturnTrue_WhenLoggedUserValueIsNotNull()
        {
            // arrange 
            var userRepository = new Mock<IRepository<User>>();
            var unitOfWork = new Mock<IUnitOfWork>();
            var userFactory = new Mock<IUserFactory>();

            var userProvider = new FakeUserProvider(userRepository.Object, unitOfWork.Object, userFactory.Object);

            var user = new User();
            userProvider.SetLoggedUser(user);

            // act
            var isLogged = userProvider.IsLogged;

            // assert
            Assert.IsTrue(isLogged);
        }
    }
}
