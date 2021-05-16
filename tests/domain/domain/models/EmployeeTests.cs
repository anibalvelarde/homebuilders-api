using System;
using api.domain.models;
using api.domain.models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeBuilders.Tests.Api.Domain.Models
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Should_Throw_When_Creating_Instance_For_Non_NewHire()
        {
            // arrange
            var realNewHire = new Employee()
            {
                Name = $"Fake-EE-Name-{DateTime.Now.Millisecond}",
                Role = EmployeeRole.AdminStaff,
                Email = "some-email@homebuilder.com"
            };
            var alreadyAnEmployee = new Employee(realNewHire);

            // act & assert
            Assert.ThrowsException<InvalidOperationException>(() => new Employee(alreadyAnEmployee));
        }

        [TestMethod]
        public void Should_Be_Correct_When_Creating_Instance_For_NewHire()
        {
            // arrange
            var realNewHire = new Employee()
            {
                Name = $"Fake-EE-Name-{DateTime.Now.Millisecond}",
                Role = EmployeeRole.AdminStaff,
                Email = "some-email@homebuilder.com"
            };

            // act
            var anEmployee = new Employee(realNewHire);

            // assert
            Assert.IsInstanceOfType(anEmployee, typeof(Employee));
        }
    }
}