using di_example;
using Moq;
using NUnit.Framework;

namespace di_example.tests.unit
{
    [TestFixture]
    public class WelcomeTest
    {
        private Mock<IGreeting> _mockGreeting;

        [SetUp]
        public void GivenAWelcomeClass_WhenInstanciated()
        {
            _mockGreeting = new Mock<IGreeting>();

            _mockGreeting.Setup(greeting => greeting.Greet());

            new Welcome(_mockGreeting.Object);
        }

        [Test]
        public void ThenGreetingGreetIsInvokedOnce()
        {
            _mockGreeting.Verify(greeting => greeting.Greet(), Times.Once);
        }
    }
}
