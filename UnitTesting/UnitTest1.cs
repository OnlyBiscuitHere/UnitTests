using NUnit.Framework;
using CSharpHomework;

namespace UnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //If someone is **under 12** - U, PG and 12 films are available - Initial requiments
        ////If someone is 12 and under - U, PG and 12 films are available
        [TestCase(3)]
        [TestCase(11)]
        [TestCase(12)]
        public void GivenAge3BetweenAnd12(int age)
        {
            var expectedGreetings = "U, PG & 12 films are available.";
            var result = Program.AvailableClassifications(age);
            Assert.That(result, Is.EqualTo(expectedGreetings));
        }
        //If someone is **under 15** - U, PG, 12 and 15 films are available -  Initial requirements
        //If someone is  15 and under - U, PG, 12 and 15 films are available
        [TestCase(13)]
        [TestCase(15)]
        [TestCase(16)]
        public void GivenAge13Between15(int age)
        {
            var expectedGreetings = "U, PG, 12 & 15 films are available.";
            var result = Program.AvailableClassifications(age);
            Assert.That(result, Is.EqualTo(expectedGreetings));
        }
        //**Over 18** - all films available
        [TestCase(18)]
        [TestCase(20)]
        [TestCase(50)]
        //Extra test for 16
        [TestCase(16)]
        public void GivenAge18AndAbove(int age)
        {
            var expectedGreetings = "All films are available.";
            var result = Program.AvailableClassifications(age);
            Assert.That(result, Is.EqualTo(expectedGreetings));
        }
    }
}