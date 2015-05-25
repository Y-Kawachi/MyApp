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

            condition.Id = 1000;
            result = repository.Search(condition);
            Assert.IsNotNull(result);
            Assert.AreEqual<int>(0, result.Count);

            condition.Id = 0;
            condition.Title = "a";
            result = repository.Search(condition);
            Assert.IsNotNull(result);
            Assert.AreEqual<int>(1, result.Count);
        }

        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            HeaderRepository repository = new HeaderRepository();
            int total = repository.Search(null).Count;

            // Act
            Header data = new Header();
            data.AppDiv = "1";
            repository.Add(data);

            repository.SaveChanges();
            
            Assert.AreEqual<int>(total+1, repository.Search(new Header()).Count);
        }

        [TestMethod]
        public void TestDelete()
        {
            // Arrange
            HeaderRepository repository = new HeaderRepository();
            var before = repository.Search(new Header());
            int total = before.Count;

            // Act
            repository.Delete(before.ElementAt(before.Count - 1));
            repository.SaveChanges();

            Assert.AreEqual<int>(total - 1, repository.Search(new Header()).Count);
        }
    }
}
