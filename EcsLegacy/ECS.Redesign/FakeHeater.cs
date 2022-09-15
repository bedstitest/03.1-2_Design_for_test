namespace ECS.Redesign
{
    public class FakeHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("FakeHeater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("FakeHeater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}