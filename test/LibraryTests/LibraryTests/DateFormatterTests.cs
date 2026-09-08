using Ucu.Poo.TestDateFormat;

namespace Ucu.Poo.TestDateFormat.Tests
{
    public class DateFormatterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChangeFormat_ValidInputDate_ReturnsConvertedDate()
        {
            // Arrange
            const string date = "10/11/1997";
            const string dateExpected = "1997-11-10";
            DateFormatter df = new DateFormatter();
            // Act
            string dateResult = df.ChangeFormat(date);
            // Assert
            Assert.That(dateResult, Is.EqualTo(dateExpected));

        }

        [Test]
        public void ChangeFormat_InvalidInputDate_ReturnsEmpty()
        {
            //Arrange
            const string date = "10/13/1997";
            const string resultExpected = "Fecha inválida";
            DateFormatter df = new DateFormatter();
            //Act
            string result = df.ChangeFormat(date);
            //Assert
            Assert.That(result, Is.EqualTo(resultExpected));
        }
    }
}
