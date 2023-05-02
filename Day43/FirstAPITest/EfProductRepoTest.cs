using FirstAPI.Models;
using FirstAPI.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPITest
{
    public class EfProductRepoTest
    {
        List<Product> myProducts;

       [SetUp]
        public void SetUp()
        {
            //Arrange 
            //Moq for Context
            Mock<ShopContext> context = new Mock<ShopContext>();
            //List of employees
            List<Product> products = new List<Product>()
            {
                new Product(){Id=101,Name="ABC"},
                new Product(){Id=102,Name="XYZ"}
            };
            //Mock for DbSet of product
            var dbSetMoq = new Mock<DbSet<Product>>();
            //Setting up the DbSet<Product> moq
            var queriableData = products.AsQueryable();
            dbSetMoq.As<IQueryable<Product>>().Setup(emp => emp.Provider).Returns(queriableData.Provider);
            dbSetMoq.As<IQueryable<Product>>().Setup(emp => emp.Expression).Returns(queriableData.Expression);
            dbSetMoq.As<IQueryable<Product>>().Setup(emp => emp.ElementType).Returns(queriableData.ElementType);
            dbSetMoq.As<IQueryable<Product>>().Setup(emp => emp.GetEnumerator()).Returns(queriableData.GetEnumerator());
            //Setting up the moq for context
            context.Setup(ctx => ctx.Products).Returns(dbSetMoq.Object);
            ProductRepoEF repo = new ProductRepoEF(context.Object);
            //Action
            myProducts = repo.GetAll().ToList();
        }
        [Test]
        public void TestGetAllElement1()
        {
            //Assert
            Assert.AreEqual("ABC", myProducts[0].Name);
        }
        [Test]
        public void TestGetAllElement2()
        {
            //Assert
            Assert.AreEqual("VHL", myProducts[1].Name);
        }
    }
}
