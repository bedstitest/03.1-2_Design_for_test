using System;

namespace ECS.Redesign
{
    internal class FakeTempSensor : ITempSensor
    {
        private double temp;
        private double thr;
        public double Temp { set { temp = value; } get { return Temp; } }
        public double Thr { set { thr = value; } get { return Thr; } }

        public double GetTemp()
        {
            return temp;
        }


        public bool Regulate()
        {
            temp = Temp;
            if (temp < Thr)
            {
                return true;
            }
            else return false;

        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}