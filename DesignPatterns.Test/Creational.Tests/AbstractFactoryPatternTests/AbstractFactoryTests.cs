using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.AbstractFactoryPattern;
using Xunit;

namespace DesignPatterns.Test.Creational.Tests.AbstractFactoryPatternTests
{
    public class AbstractFactoryTests
    {
        [Fact]
        public void testDarkThemeFactory()
        {
            // Arrange
            IThemeFactory darkTheme = new DarkThemeFactory();

            // Act
            Button button = darkTheme.createButton();
            RadioButton radiobutton = darkTheme.createRadioButton();
            Dropdown dropdown = darkTheme.CreateDropdown();

            // Assert
            Assert.IsType(typeof(DarkButton), button);
            Assert.IsType(typeof(DarkRadioButton), radiobutton);
            Assert.IsType(typeof(DarkDropdown), dropdown);
        }

        [Fact]
        public void testLightThemeFactory()
        {
            // Arrange
            IThemeFactory darkTheme = new LightThemeFactory();

            // Act
            Button button = darkTheme.createButton();
            RadioButton radiobutton = darkTheme.createRadioButton();
            Dropdown dropdown = darkTheme.CreateDropdown();

            // Assert
            Assert.IsType(typeof(lightButton), button);
            Assert.IsType(typeof(LightRadioButton), radiobutton);
            Assert.IsType(typeof(LightDropdown), dropdown);
        }
    }
}
