using StrategyPattern.Strategy;

namespace StrategyPattern.Classes
{
    internal class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle() : base(new SportsStrategy()) { }
    }
}
