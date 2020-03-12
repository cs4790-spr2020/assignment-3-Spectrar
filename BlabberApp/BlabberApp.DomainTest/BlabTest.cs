using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain.Models;
using System;

namespace BlabberApp.DomainTest {
    [TestClass]
    public class BlabTest {
        // getset tests should never fail.  period.
        [TestMethod]
        public void TestGetSetMessage() {
            // Arrange
            var harness = new Blab();
            var expected = "Hello!";
            harness.Message = expected;
            // Act
            var actual = harness.Message;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSetUserID() {
            // Arrange
            var harness = new Blab();
            var expected = 1;
            harness.UserId = expected;
            // Act
            var actual = harness.UserId;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSetCreatedDate() {
            // Arrange
            var harness = new Blab();
            var expected = DateTime.UtcNow;
            harness.CreatedDate = expected;
            // Act
            var actual = harness.CreatedDate;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSetID() {
            // Arrange
            var harness = new Blab();
            var expected = 1;
            harness.Id = expected;
            // Act
            var actual = harness.Id;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
