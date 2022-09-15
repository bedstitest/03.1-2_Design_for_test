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
            Assert.That(uut.GetThreshold(), Is.EqualTo(25));
        }
        [Test]
        public void IsHeater_on()
        {

            FH.heaterWasTurnOn = false;
            uut._heater.TurnOn();

            Assert.That(FH.heaterWasTurnOn, Is.EqualTo(true));
        }


        [Test]
        public void IsHeater_off()
        {
            FH.heaterWasTurnOff = false;
            uut._heater.TurnOff();
            Assert.That(FH.heaterWasTurnOff, Is.EqualTo(true));
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
            FS.Temp = -5;
            uut.Regulate();

            Assert.That();
            
        }
        public void Regulate_fake_low()
        {
            FS.Temp = -5;
            FS.Thr = 10;
            bool reg_low_or_high = FS.Regulate();

            if(reg_low_or_high == true)
            {
                FH.TurnOn();
            }
            else
            {
                throw new Exception("Heater was not turned on");
            }

            Assert.That(FH.heaterWasTurnOn, Is.True);
        }
        public void Regulate_fake_high()
        {
            FS.Temp = 15;
            FS.Thr = 10;
            bool reg_low_or_high = FS.Regulate();

            if (reg_low_or_high == true)
            {
                FH.TurnOff();
            }
            else
            {
                throw new Exception("Heater was not turned on");
            }

            Assert.That(FH.heaterWasTurnOff, Is.True);
        }


        public void regulate()
        {
            FS.Temp = 100;


        }

        [Test]
        public void RunSelfTest()
        {
            bool isTestran_ = false;

            isTestran_ = uut.RunSelfTest();

            Assert.That(isTestran_, Is.EqualTo(true));
        }
    }
}