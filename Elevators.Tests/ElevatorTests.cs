using Xunit;

namespace Elevators.Tests
{
    public class ElevatorTests
    {

        [Fact]
        public void GivenNewBuildingWhenSeedElevatorsIsCalledWithCorrectDataThenExpectCorrectElevatorCounts()
        {
            var building = new Building();

            building.SeedElevators(10, 15);

            Assert.Equal(10, building.BuildingElevators.Count());
        }

        [Fact]
        public void GivenNewBuildingWhenCallUpdateElevatorEnsurePeopleCountIsToBeAsExpected()
        {
            var building = new Building();

            building.SeedElevators(10, 15);

            var elevator = building.CallNearestElevator(2, 8);
            elevator.UpdateElevator(2, 8);

            Assert.Equal(8, elevator.PeopleCount);
        }

        [Fact]
        public void GivenNewBuildingWhenUpdateElevatorEnsureCurrentFloortIsToBeAsExpected()
        {
            var building = new Building();

            building.SeedElevators(10, 15);

            var elevator = building.CallNearestElevator(2, 8);
            elevator.UpdateElevator(2, 8);

            Assert.Equal(2, elevator.CurrentFloor);
        }

        [Fact]
        public void GivenNewBuildingWhenUpdateElevatorEnsureDirectionIsToBeAsExpected()
        {
            var building = new Building();

            building.SeedElevators(10, 15);

            var elevator = building.CallNearestElevator(2, 8);
            elevator.UpdateElevator(2, 8);

            Assert.Equal(Direction.Up, elevator.Direction);
        }

        [Fact]
        public void GivenNewBuildingWhenUpdateElevatorEnsurePeopleCountIsSUmOfBothCalls()
        {
            var building = new Building();

            building.SeedElevators(10, 15);

            var elevator = building.CallNearestElevator(2, 8);
            elevator.UpdateElevator(2, 8);
            elevator.UpdateElevator(2, 4);

            Assert.Equal(12, elevator.PeopleCount);
        }

        [Fact]
        public void GivenNewBuildingWhenCallNearestElevatorEnsureWeightLimitIsObserved()
        {
            var building = new Building();

            building.SeedElevators(10, 14);

            var elevator = building.CallNearestElevator(2, 8);
            elevator.UpdateElevator(2, 8);

            var elevator2 = building.CallNearestElevator(2, 8);
            elevator.UpdateElevator(2, 8);

            Assert.NotEqual(elevator.Name, elevator2.Name);
        }

        [Fact]
        public void GivenNewBuildingWhenSeedElevatorsIsCalledWithAWeightLimitExpectWeightLimitToBeAsExpected()
        {
            var building = new Building();

            building.SeedElevators(10, 15);

            Assert.Equal(15, building.WeightLimit);
        }
    }
}