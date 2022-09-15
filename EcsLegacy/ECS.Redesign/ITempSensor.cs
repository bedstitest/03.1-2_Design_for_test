namespace ECS.Redesign {
    public interface ITempSensor
    {
        double GetTemp();
        bool RunSelfTest();
    }
}