namespace Elevators
{
    public class Elevator
    {
        public int Name { get; set; }
        public int CurrentFloor { get; set; } = 1;

        public int PeopleCount { get; set; } = 0;

        public Direction Direction { get; set; } = Direction.Stationery;

        public Elevator UpdateElevator(int callingFloor, int peopleWaiting)
        {
            PeopleCount = PeopleCount + peopleWaiting;
            Direction = callingFloor == CurrentFloor ? Direction.Stationery : (callingFloor < CurrentFloor ? Direction.Down : Direction.Up);
            CurrentFloor = callingFloor;

            return this;
        }
    }
}
