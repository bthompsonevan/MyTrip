using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MyTrip.Models;
using MyTrip.Controllers;
using MyTrip.Repositories;

namespace MyTripTests
{
    public class RepositoryTests
    {
        /*********************
         *  ADD TRIP TESTS   *
         * *******************/
        [Fact]
        public void AddTripTestTripNameField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddTrip(new Trip() {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 /01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            });
            //Assert
            Assert.Equal("Trip Test 1", repo.Trips[0].TripName);                
        }
        [Fact]
        public void AddTripTestStatDateField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddTrip(new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            });
            //Assert
            Assert.Equal(DateTime.Parse("01 / 01 / 1990"), repo.Trips[0].TripStartDate);
        }
        [Fact]
        public void AddTripTestEndDateField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddTrip(new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            });
            //Assert
            Assert.Equal(DateTime.Parse("01 / 02 / 1990"), repo.Trips[0].TripEndDate);
        }
        [Fact]
        public void AddTripTestDestinationField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddTrip(new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            });
            //Assert
            Assert.Equal("Canada", repo.Trips[0].TripDestination);
        }

        /*************************
         * ADD TRIP TO USER TEST *
         *************************/

        [Fact]
        public void AddTripToUserTestTripNameField()
        {
            // Arrange
            var user = new User();
            var repo = new FakeTripRepository();
            //Act
            repo.AddTripToUser(user, new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            });
            //Assert
            Assert.Equal("Trip Test 1", user.UserTrips[0].TripName);
        }
        [Fact]
        public void AddTripToUserTestStartDateField()
        {
            // Arrange
            var user = new User();
            var repo = new FakeTripRepository();
            //Act
            repo.AddTripToUser(user, new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            });
            //Assert
            Assert.Equal(DateTime.Parse("01 / 01 / 1990"), user.UserTrips[0].TripStartDate);
        }
        [Fact]
        public void AddTripToUserTestEndDateField()
        {
            // Arrange
            var user = new User();
            var repo = new FakeTripRepository();
            //Act
            repo.AddTripToUser(user, new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            });
            //Assert
            Assert.Equal(DateTime.Parse("01 / 02 / 1990"), user.UserTrips[0].TripEndDate);
        }
        [Fact]
        public void AddTripToUserTestTripDestinationField()
        {
            // Arrange
            var user = new User();
            var repo = new FakeTripRepository();
            //Act
            repo.AddTripToUser(user, new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            });
            //Assert
            Assert.Equal("Canada", user.UserTrips[0].TripDestination);
        }

        /**************************
         *   ADD STOP TO TRIP    *
         *************************/
        [Fact]
        public void AddStopToTripTestStopNameField()
        {
            // Arrange
            var user = new User();
            var repo = new FakeTripRepository();
            Trip trip = new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            };
            TripStop stop = new TripStop()
            {
                StopName = "Stop 1",
                StopBegin = DateTime.Parse("01 / 01 / 1990"),
                StopEnd = DateTime.Parse("01 / 02 / 1990")
            };
            //Act
            repo.AddStopToTrip(trip, stop);
            
            //Assert
            Assert.Equal("Stop 1", trip.TripStops[0].StopName);
        }
        [Fact]
        public void AddStopToTripTestStartDateField()
        {
            // Arrange
            var user = new User();
            var repo = new FakeTripRepository();
            Trip trip = new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            };
            TripStop stop = new TripStop()
            {
                StopName = "Stop 1",
                StopBegin = DateTime.Parse("01 / 01 / 1990"),
                StopEnd = DateTime.Parse("01 / 02 / 1990")
            };
            //Act
            repo.AddStopToTrip(trip, stop);

            //Assert
            Assert.Equal(DateTime.Parse("01 / 01 / 1990"), trip.TripStops[0].StopBegin);
        }
        [Fact]
        public void AddStopToTripTestEndDateField()
        {
            // Arrange
            var user = new User();
            var repo = new FakeTripRepository();
            Trip trip = new Trip()
            {
                TripName = "Trip Test 1",
                TripStartDate = DateTime.Parse("01 / 01 / 1990"),
                TripEndDate = DateTime.Parse("01 / 02 / 1990"),
                TripDestination = "Canada"
            };
            TripStop stop = new TripStop()
            {
                StopName = "Stop 1",
                StopBegin = DateTime.Parse("01 / 01 / 1990"),
                StopEnd = DateTime.Parse("01 / 02 / 1990")
            };
            //Act
            repo.AddStopToTrip(trip, stop);

            //Assert
            Assert.Equal(DateTime.Parse("01 / 02 / 1990"), trip.TripStops[0].StopEnd);
        }




    }
}
