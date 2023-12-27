using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DesignPatterns.Creational.FactoryMethodPattern;

namespace DesignPatterns.Test.Creational.Tests.FactoryMethodPatternTests
{
    
    public class FactoryMethodTests
    {
        [Fact]
        public void testFactoryMethod()
        {
            // Arrange
            IButtonFactory recButtonFactory = new RectangleButtonFactory();
            IButtonFactory sqarButtonFactory = new SquareButtonFactory();
            IButtonFactory roundButtonFactory = new RoundButtonFactory();

            // Act
            Button rectangleButton = recButtonFactory.createButton();
            Button squareButton = sqarButtonFactory.createButton();
            Button roundButton = roundButtonFactory.createButton();

            // Assert
            Assert.IsType(typeof(RectangleButton), rectangleButton);
            Assert.IsType(typeof(RoundButton), roundButton);
            Assert.IsType(typeof(SquareButton), squareButton);
        }
    }
}
