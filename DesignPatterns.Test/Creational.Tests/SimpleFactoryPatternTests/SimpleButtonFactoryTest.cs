using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DesignPatterns.Creational.SimpleFactoryPattern;

namespace DesignPatterns.Test.Creational.Tests.SimpleFactoryPatternTests
{
    public class SimpleButtonFactoryTest
    {
        [Fact]
        public void testSimpleButtonFactory()
        {
            // Arrange
            SimpleButtonFactory buttonFactory = new SimpleButtonFactory();

            // Act
            Button rectangleButton = buttonFactory.createButton(ButtonType.rectangle);
            Button roundButton = buttonFactory.createButton(ButtonType.round);
            Button squareButton = buttonFactory.createButton(ButtonType.square);

            // Assert
            Assert.IsType(typeof(RectangleButton), rectangleButton);
            Assert.IsType(typeof(RoundButton), roundButton);
            Assert.IsType(typeof(SquareButton), squareButton);
        }
    }
}
