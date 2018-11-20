using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snake.BLL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.BLL.Managers.Tests
{
    [TestClass()]
    public class SnakeManagerTests
    {
        [TestMethod()]
        public void СoordinatesChangerTest()
        {
            // Arrange
            SnakeManager snakeManager = new SnakeManager();

            //Act
            var results = snakeManager.GetSnake();

            //Assert
            Assert.AreEqual(3, results.Bodyes.Count);
        }
    }
}