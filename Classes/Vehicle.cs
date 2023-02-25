using StrategyPattern.Strategy;

namespace StrategyPattern.Classes
{
    internal class Vehicle
    {
        private readonly IDriveStrategy driveStrategy;
        public  Vehicle(IDriveStrategy driveStrategy)
        {
            this.driveStrategy = driveStrategy;
        }

        public void drive()
        {
            driveStrategy.drive();
        }
    }
}
