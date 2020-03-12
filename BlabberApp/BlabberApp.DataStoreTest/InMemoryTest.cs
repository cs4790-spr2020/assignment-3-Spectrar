using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BlabberApp.DataStore;
using BlabberApp.Domain.Models;

namespace BlabberApp.DataStoreTest {
    [TestClass]
    public class InMemoryTest {
        [TestMethod]
        public void TestAdd() {
            // Arrange
            var harness = new InMemory();
            var expected = new Blab {
                Id = 1,
                CreatedBy = -1,
                CreatedDate = DateTime.Now,
                LastModifiedBy = null,
                LastModifiedDate = null,
                Message = "This is a really cool app!",
                UserId = 1
            };

            // Act
            harness.Create(expected);
            var actual = harness.Read(0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdate() {
            // Arrange
            var harness = new InMemory();
            var initial = new Blab {
                Id = 1,
                CreatedBy = -1,
                CreatedDate = DateTime.Now,
                LastModifiedBy = null,
                LastModifiedDate = null,
                Message = "This is a really cool app!",
                UserId = 1
            };

            var expected = new Blab {
                Id = 2,
                CreatedBy = -1,
                CreatedDate = DateTime.UtcNow,
                LastModifiedBy = null,
                LastModifiedDate = null,
                Message = "This is a really cool app! #Updated",
                UserId = 2
            };

            // Act
            harness.Create(initial);
            harness.Update(initial, expected);
            var actual = harness.Read(0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDelete() {
            // Arrange
            var harness = new InMemory();
            var expected = new Blab {
                Id = 1,
                CreatedBy = -1,
                CreatedDate = DateTime.Now,
                LastModifiedBy = null,
                LastModifiedDate = null,
                Message = "This is a really cool app!",
                UserId = 1
            };

            // Act
            harness.Create(expected);
            var blab = harness.Read(0);
            harness.Delete(blab); 
            var actual = harness.Read(0);
            // Assert
            Assert.IsNull(actual);
        }
    }
}
