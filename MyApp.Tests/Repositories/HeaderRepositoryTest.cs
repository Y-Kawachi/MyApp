using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp;
using MyApp.Repositories;
using MyApp.Models.Entity;

namespace MyApp.Tests.Repositories
{
    [TestClass]
    public class HeaderRepositoryTest
    {
        [TestMethod]
        public void TestFind()
        {
            // Arrange
            HeaderRepository repository = new HeaderRepository();

            // Act
            var result = repository.Find(1);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestSearchById()
        {
            // Arrange
            HeaderRepository repository = new HeaderRepository();

            // Act
            Header condition = new Header();
            ICollection<Header> result = null;

            condition.Id = 1;
            result = repository.Search(condition);
            Assert.IsNotNull(result);
            Assert.AreEqual<int>(1, result.Count);
            Assert.AreEqual<int>(2, result.Single().Details.Count);

            condition.Id = 3;
            result = repository.Search(condition);
            Assert.IsNotNull(result);
            Assert.AreEqual<int>(0, result.Count);
        }
    }
}
