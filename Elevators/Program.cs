namespace Elevators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var building = new Building();

            Console.WriteLine("Enter the number of elevators in the building:");
            var elevatorCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the weight limit(in number of people) of the elevators:");
            var weightLimit = Convert.ToInt32(Console.ReadLine());

            building.SeedElevators(elevatorCount, weightLimit);

            Console.WriteLine();

            while (true)
            {
               
                Console.WriteLine("Enter the floor number:");
                var callingFloor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number of people waiting on the floor:");
                var peopleWaiting = Convert.ToInt32(Console.ReadLine());

                var elevator = building.CallNearestElevator(callingFloor, peopleWaiting);
                elevator.UpdateElevator(callingFloor, peopleWaiting);

                Console.WriteLine($"Elevator: {elevator.Name}");
                Console.WriteLine($"Floor: {elevator.CurrentFloor}");
                Console.WriteLine($"Direction: {elevator.Direction}");
                Console.WriteLine($"Current Occupancy: {elevator.PeopleCount}");
                Console.WriteLine();
                Console.WriteLine($"Press Enter to call an elevator.");
                Console.ReadLine();
            }           
        }
    }
}