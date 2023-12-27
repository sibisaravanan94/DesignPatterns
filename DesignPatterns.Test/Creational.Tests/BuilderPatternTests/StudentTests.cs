using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DesignPatterns.Creational.BuilderPattern;

namespace DesignPatterns.Test.Creational.Tests.BuilderPatternTests
{
    public class StudentTests
    {
        [Fact]
        public void Student_Constructor_ReturnsObject()
        {
            // Arrange
            Student student = Student.GetBuilder()
                                    .withName("Sibi", "Saravanan")
                                    .ofAge(29)
                                    .sonOf("saravanan")
                                    .withCredenticals("username", "password")
                                    .Build();
            // Act
            // Assert
            Assert.NotNull(student);
        }

        [Fact]
        public void Student_Constructor_ReturnsNull()
        {
            // Arrange
            Student student = Student.GetBuilder()
                                    //.withName("Sibi", "Saravanan")
                                    .ofAge(29)
                                    .sonOf("saravanan")
                                    .withCredenticals("username", "password")
                                    .Build();
            // Act
            // Assert
            Assert.Null(student);
        }
    }
}
