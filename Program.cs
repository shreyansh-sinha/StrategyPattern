using StrategyPattern.Classes;

namespace StrategyPattern
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Vehicle sportsVehicle = new SportsVehicle();
            sportsVehicle.drive();

            Vehicle passengerVehicle = new PassengerVehicle();
            passengerVehicle.drive();

            Vehicle offRoadVehicle = new OffRoadVehicle();
            offRoadVehicle.drive();
        }
    }
}
