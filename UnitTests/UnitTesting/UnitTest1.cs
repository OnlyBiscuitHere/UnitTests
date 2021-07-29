using NUnit.Framework;
using UnitTests;

namespace UnitTesting
{
    public class GreetingsTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            var time = 21;
            var expectedGreeting = "Good evening!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenATimeOf12_Greeting_ReturnsGoodMorning()
        {
            var time = 12;
            var expectedGreeting = "Good morning!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenATimeOf6_Greeting_ReturnsGoodMorning()
        {
            var time = 6;
            var expectedGreeting = "Good morning!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenATimeOf24_Greeting_ReturnsGoodEvening()
        {
            var time = 24;
            var expecetedGreeting = "Good evening!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expecetedGreeting));
        }
        [TestCase(8)]
        [TestCase(12)]
        [TestCase(5)]
        public void GivenATimeOf8_Greeting_ReturnsGoodMorning(int time)
        {
            var expectedGreeting = "Good morning!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [TestCase(13)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenATimeBetween12and18Inclusive_Greeting_ReturnsGoodMorning(int time)
        {
            var expectedGreeting = "Good afternoon!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(19)]
        [TestCase(24)]
        [TestCase(3)]
        public void GivenATimeBetween18and5Inclusive_Greeting_ReturnsGoodAfternoon(int time)
        {
            var expectedGreeting = "Good evening!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}