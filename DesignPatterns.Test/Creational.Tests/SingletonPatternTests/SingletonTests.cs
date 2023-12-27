using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DesignPatterns.Creational.SingletonPattern;

namespace DesignPatterns.Test.Creational.Tests.SingletonPatternTests
{
    public class SingletonTests
    {
        [Fact]
        public void Singleton_Constructor_ReturnsSingleObject()
        {
            // Arrange - Varriable, classes, Mock


            // Act
            Singleton singleton1 = Singleton.getSingleton();
            Singleton singleton2 = Singleton.getSingleton();

            //Assert
            Assert.True(singleton1 == singleton2);
            //Assert.NotEqual(singleton1, singleton2);
        }
    }
}
