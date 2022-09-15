using System;

namespace ECS.Redesign
{
    internal class FakeTempSensor : ITempSensor
    {
        private double temp;
        public double Temp { set { temp = value} }

        public double GetTemp()
        {
            return temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}