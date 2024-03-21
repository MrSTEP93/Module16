using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Module16.UserTicketService.Tests
{
    public class UserRepositoryTests
    {
        [Test]
        public void FindAll_MustRerurnNotNull()
        {
            var userList = new List<User>()
            {
                new User() { Name = "Anton" },
                new User() { Name = "Ivan" },
                new User() { Name = "Aleg" }
            };

            var mock = new Mock<IUserRepository>();
            mock.Setup(v => v.FindAll()).Returns(userList);

            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Anton"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Ivan"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Aleg"));

        }
    }
}
