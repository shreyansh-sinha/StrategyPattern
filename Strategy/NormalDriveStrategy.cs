namespace StrategyPattern.Strategy
{
    internal class NormalDriveStrategy : IDriveStrategy
    {
        public void drive()
        {
            Console.WriteLine("Normal Drive Strategy");
        }
    }
}
