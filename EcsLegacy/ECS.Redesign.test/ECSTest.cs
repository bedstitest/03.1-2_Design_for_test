using System;
using ECS.Redesign;

namespace ECS.Redesign.test
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            var uut = new ECS(45,);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}