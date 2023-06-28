

using InterUserManagementAPI.Interfaces;
using InterUserManagementAPI.Models;
using InterUserManagementAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace InternTest
{
    [TestClass]
    public class UserTest
    {
        public DbContextOptions<UserContext> GetDbcontextOption()
        {
            var contextOptions = new DbContextOptionsBuilder<UserContext>()
                                    .UseInMemoryDatabase(databaseName: "userInMemory")
                                    .Options;
            return contextOptions;
        }

        [TestMethod]
        public async Task TestGetAllofRepo()
        {
            using (var userContext = new UserContext(GetDbcontextOption()))
            {

                userContext.Interns.Add(new Intern
                {
                    Name = "Gimu G",
                    Phone = "9876543210",
                    DateOfBirth = new DateTime(2001, 02, 14),
                    Age = 22,
                    Email = "gimu@gmail.com",
                    Gender = "Male",
                    User = new User() { PasswordHash = new byte[] { }, PasswordKey = new byte[] { }, Role = "Intern", Status = "Not Approved" },
                });
                await userContext.SaveChangesAsync();

            }
            using (var userContext = new UserContext(GetDbcontextOption()))
            {
                IRepo<int, User> repo = new USerRepo(userContext);
                var data = await repo.GetAll();
                Assert.AreEqual(1, data.ToList().Count);
            }
          
        }
        
    }
}