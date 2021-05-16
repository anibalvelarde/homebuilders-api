using System;
using api.domain.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeBuilders.Tests.Api.Domain.Models
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void Should_Throw_When_Creating_Instance_For_Non_Prospect()
        {
            // arrange
            var realProspect = new Client()
            {
                Name = $"Fake-EE-Name-{DateTime.Now.Millisecond}",
                Email = "some-email@homebuilder.com"
            };
            var alreadyClient = new Client(realProspect);

            // act & assert
            Assert.ThrowsException<InvalidOperationException>(() => new Client(alreadyClient));
        }

        [TestMethod]
        public void Should_Be_Correct_When_Creating_Instance_For_Prospect()
        {
            // arrange
            var realNewHire = new Client()
            {
                Name = $"Fake-EE-Name-{DateTime.Now.Millisecond}",
                Email = "some-email@homebuilder.com"
            };

            // act
            var anClient = new Client(realNewHire);

            // assert
            Assert.IsInstanceOfType(anClient, typeof(Client));
        }
    }
}