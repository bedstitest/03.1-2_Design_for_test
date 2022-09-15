using System;

namespace ECS.Redesign
{
    internal class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            return 45;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}