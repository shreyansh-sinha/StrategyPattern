using StrategyPattern.Strategy;

namespace StrategyPattern.Classes
{
    internal class PassengerVehicle : Vehicle
    {
        public PassengerVehicle() : base(new NormalDriveStrategy()) { }
    }
}
