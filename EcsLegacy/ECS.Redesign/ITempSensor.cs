namespace ECS.Redesign {
    public interface ITempSensor
    {
        Random gen = new Random();
        int GetTemp();
        bool RunSelfTest();
    }
}