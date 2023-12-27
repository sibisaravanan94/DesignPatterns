using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DesignPatterns.Creational.PrototypePattern;

namespace DesignPatterns.Test.Creational.Tests.PrototypePatternTests
{
    public class BackgroundObjectRegistryTests
    {
        [Fact]
        public void testRegistry()
        {
            // Arrange
            BackgroundObject prototype = new BackgroundObject(1, 2, 3, 4, BackgroundObjectType.Building);
            BackgroundObjectRegistry registry = BackgroundObjectRegistry.getInstance();
            // Act
            registry.register(prototype);
            BackgroundObject prototype1 = registry.getPrototype(BackgroundObjectType.Building);
            // Assert
            Assert.Equal(prototype, prototype1);
        }
    }
}
