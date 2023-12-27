using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.PrototypePattern;
using Xunit;

namespace DesignPatterns.Test.Creational.Tests.PrototypePatternTests
{
    public class BackgroundObjectTests
    {
        [Fact]
        public void BackgroundObject_constructor_returnsObject()
        {
            // Arrange
            BackgroundObject prototype = new BackgroundObject(2,3,4,5,BackgroundObjectType.Tree);


            // Act
            BackgroundObject cloneObj = prototype.Clone() as BackgroundObject;

            // Step 3 -> Change required fields
            cloneObj.x = 2;
            cloneObj.y = 9;

            // Assert
            Assert.NotNull(cloneObj);
            Assert.NotEqual(prototype, cloneObj);

        }
    }
}
