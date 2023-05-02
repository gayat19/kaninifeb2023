using FirstAPI.Models;
using FirstAPI.Services;

namespace FirstAPITest
{
    public class Tests
    {
        ProductRepo repo;
        [SetUp]
        public void Setup()
        {
            //Arrange
            repo = new ProductRepo();
        }

        //[Test]
        //public void TestAdd()
        //{
        //    //Action
        //    var myProduct = repo.Add(new Product { Id = 103, Name = "ABC", Price = 12.3f, Quantity = 0 });
        //    //Assert
        //    Assert.IsNotNull(myProduct);
        //}

        [TestCase(101)]
        [TestCase(104)]
        [TestCase(103)]
        public void TestAdd(int pid)
        {
            //Action
            var myProduct = repo.Add(new Product { Id = pid, Name = "ABC", Price = 12.3f, Quantity = 0 });
            //Assert
            Assert.IsNotNull(myProduct);
        }

        [TestCase(101)]
        [TestCase(104)]
        [TestCase(103)]
        public void TestGet(int pid)
        {
            //Action
            var myProduct = repo.Get(pid);
            //Assert
            Assert.IsNotNull(myProduct);
        }
        [Test] 
        public void TestGetAll() { 
            var myProduct = repo.GetAll();
            Assert.AreEqual(2, myProduct.Count);
        }

    }
}