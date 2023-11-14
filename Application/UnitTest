using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

[TestFixture]
public class TurkishIdentityValidationTests
{
    [Test]
    public void TurkishIdentityValidation_ValidTurkishIdentity_ReturnsSuccess()
    {
        // Arrange
        var turkishIdValidation = new TurkishIdentityValidation.TCKCheck();
        var validationContext = new ValidationContext(new { TurkishId = "12345678901" });

        // Act
        var result = turkishIdValidation.GetValidationResult("12345678901", validationContext);

        // Assert
        Assert.AreEqual(ValidationResult.Success, result);
    }

    [Test]
    public void TurkishIdentityValidation_InvalidTurkishIdentity_ReturnsError()
    {
        // Arrange
        var turkishIdValidation = new TurkishIdentityValidation.TCKCheck();
        var validationContext = new ValidationContext(new { TurkishId = "12345678900" });

        // Act
        var result = turkishIdValidation.GetValidationResult("12345678900", validationContext);

        // Assert
        Assert.AreNotEqual(ValidationResult.Success, result);
        Assert.AreEqual("Invalid TCK.", result.ErrorMessage);
    }
    
    [Test]
    public void TurkishIdentityValidation_NullTurkishIdentity_ReturnsError()
    {
        // Arrange
        var turkishIdValidation = new TurkishIdentityValidation.TCKCheck();
        var validationContext = new ValidationContext(new { TurkishId = (string)null });

        // Act
        var result = turkishIdValidation.GetValidationResult(null, validationContext);

        // Assert
        Assert.AreNotEqual(ValidationResult.Success, result);
        Assert.AreEqual("TCK cannot be empty.", result.ErrorMessage);
    }
}

