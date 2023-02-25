namespace StrategyPattern.Strategy
{
    internal class SportsStrategy : IDriveStrategy
    {
        public void drive()
        {
            Console.WriteLine("Sports Drive functionality");
        }
    }
}
