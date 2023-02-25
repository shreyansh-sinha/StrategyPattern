using StrategyPattern.Strategy;

namespace StrategyPattern.Classes
{
    internal class SportsVehicle : Vehicle
    {
        public SportsVehicle() : base(new SportsStrategy()) { }
    }
}
