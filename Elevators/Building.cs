namespace Elevators
{
    public class Building
    {
        public int Floors { get; set; } = 1;

        public int WeightLimit { get; set; } = 10;

        public List<Elevator> BuildingElevators { get; set; } = new List<Elevator>();

        public Elevator CallNearestElevator(int callingFloor, int occupants)
        {
            return BuildingElevators.OrderBy(item => Math.Abs(callingFloor - item.CurrentFloor)).Where(item => (item.PeopleCount + occupants) < WeightLimit).First();
        }

        public void SeedElevators(int amount, int weightLimit)
        {
            WeightLimit = weightLimit;

            for (var i = 1; i <= amount; i++)
            {
                BuildingElevators.Add(new Elevator() { Name = i });
            }
        }
    }
}
