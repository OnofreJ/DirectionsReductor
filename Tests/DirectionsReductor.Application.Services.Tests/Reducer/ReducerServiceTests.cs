namespace DirectionsReductor.Application.Services.Tests.Reducer
{
    using AutoFixture;
    using DirectionsReductor.Application.Services.Reducer;
    using DirectionsReductor.Application.Services.Validation;
    using FluentAssertions;
    using NSubstitute;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class ReducerServiceTests
    {
        private readonly Fixture fixture;
        private readonly IReducerService reducerService;

        private readonly IValidationService validationService;

        public ReducerServiceTests()
        {
            fixture = new Fixture();
            validationService = Substitute.For<IValidationService>();
            reducerService = new ReducerService(validationService);
        }

        [Fact]
        public void Reduce_InvalidInputDirections_ThrowsArgumentNullException()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => reducerService.Reduce(null));
        }

        [Fact]
        public void Reduce_InvalidInputDirections_ThrowsException()
        {
            // Arrange
            var directions = fixture.CreateMany<string>();

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => reducerService.Reduce(directions.ToList()));
        }

        [Fact]
        public void Reduce_ValidInputDirections_DirectionReduced()
        {
            // Arrange
            var directions = new List<string> { "west", "north", "south" };

            // Act
            var result = reducerService.Reduce(directions);

            // Assert
            result.First().Should().NotBeNullOrEmpty();
            result.First().Should().Be(directions.First());
            validationService.Received(1).Validate(directions);
        }
    }
}