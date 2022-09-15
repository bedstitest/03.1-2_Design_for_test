using System;
using ECS.Redesign;

namespace ECS.Redesign.test
{
    public class Tests
    {
        ECS uut;
        FakeTempSensor FS;
        FakeHeater FH;

        [SetUp]
        public void Setup()
        {
            FS = new FakeTempSensor();
            FH = new FakeHeater();
            uut = new ECS(45,FS,FH);
        }

        [Test]
        public void SetThreshold()
        {
            uut.SetThreshold(25);
            Assert.That(uut.GetThreshold(), Is.EqualTo(25))
        }
        [Test]
        public void IsHeater_on()
        {
           
            

            Assert.Pass();

        }

        [Test]
        public void Regulate_High_Temp()
        {
            FS.Temp = 45;
            uut.Regulate();
        }
        [Test]
        public void Regulate_Low_Temp()
        {
            
        }

        [Test]
        public void RunSelfTest()
        {

        }
    }
}