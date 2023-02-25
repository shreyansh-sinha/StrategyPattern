using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
