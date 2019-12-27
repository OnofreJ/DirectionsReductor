namespace DirectionsReductor.Application.Services.Tests.Validation
{
    using AutoFixture;
    using DirectionsReductor.Application.Services.Validation;
    using System;
    using System.Linq;
    using Xunit;

    public class ValidationServiceTests
    {
        private readonly Fixture fixture;
        private readonly IValidationService validationService;

        public ValidationServiceTests()
        {
            fixture = new Fixture();
            validationService = new ValidationService();
        }

        [Fact]
        public void Validate_InvalidInputDirections_ThrowsInvalidOperationException()
        {
            // Arrange
            var directions = fixture.CreateMany<string>();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => validationService.Validate(directions.ToList()));
        }
    }
}