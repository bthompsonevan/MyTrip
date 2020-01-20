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
            var user = new AppUser();
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
            Assert.Equal("Trip Test 1", user.Trips[0].TripName);
        }
        [Fact]
        public void AddTripToUserTestStartDateField()
        {
            // Arrange
            var user = new AppUser();
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
            Assert.Equal(DateTime.Parse("01 / 01 / 1990"), user.Trips[0].TripStartDate);
        }
        [Fact]
        public void AddTripToUserTestEndDateField()
        {
            // Arrange
            var user = new AppUser();
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
            Assert.Equal(DateTime.Parse("01 / 02 / 1990"), user.Trips[0].TripEndDate);
        }
        [Fact]
        public void AddTripToUserTestTripDestinationField()
        {
            // Arrange
            var user = new AppUser();
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
            Assert.Equal("Canada", user.Trips[0].TripDestination);
        }

        /**************************
         *   ADD STOP TO TRIP    *
         *************************/
        [Fact]
        public void AddStopToTripTestStopNameField()
        {
            // Arrange
            var user = new AppUser();
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
            var user = new AppUser();
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
            var user = new AppUser();
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

        /****************
        * ADD USER TEST *
        ****************/

        [Fact]
        public void AddUserTestUserNameField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddUser(new AppUser()
            {
               UserName = "BernieD",
              // Password = "Treatos",
               FirstName = "Bernie",
               LastName = "Doodle",
               Email = "bDoodle@gmail.com",
               Bio = "I am puppers it is time for suppers"
            });
            //Assert
            Assert.Equal("BernieD", repo.Users[0].UserName);
        }

        [Fact]
        public void AddUserPasswordField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddUser(new AppUser()
            {
                UserName = "BernieD",
              //  Password = "Treatos",
                FirstName = "Bernie",
                LastName = "Doodle",
                Email = "bDoodle@gmail.com",
                Bio = "I am puppers it is time for suppers"
            });
            //Assert
           // Assert.Equal("Treatos", repo.Users[0].Password);
        }

        [Fact]
        public void AddUserTestFirstNameField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddUser(new AppUser()
            {
                UserName = "BernieD",
              //  Password = "Treatos",
                FirstName = "Bernie",
                LastName = "Doodle",
                Email = "bDoodle@gmail.com",
                Bio = "I am puppers it is time for suppers"
            });
            //Assert
            Assert.Equal("Bernie", repo.Users[0].FirstName);
        }

        [Fact]
        public void AddUserTestLastNameField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddUser(new AppUser()
            {
                UserName = "BernieD",
              //  Password = "Treatos",
                FirstName = "Bernie",
                LastName = "Doodle",
                Email = "bDoodle@gmail.com",
                Bio = "I am puppers it is time for suppers"
            });
            //Assert
            Assert.Equal("Doodle", repo.Users[0].LastName);
        }

        [Fact]
        public void AddUserTestEmailField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddUser(new AppUser()
            {
                UserName = "BernieD",
              //  Password = "Treatos",
                FirstName = "Bernie",
                LastName = "Doodle",
                Email = "bDoodle@gmail.com",
                Bio = "I am puppers it is time for suppers"
            });
            //Assert
            Assert.Equal("bDoodle@gmail.com", repo.Users[0].Email);
        }

        [Fact]
        public void AddUserBioField()
        {
            // Arrange
            var repo = new FakeTripRepository();
            //Act
            repo.AddUser(new AppUser()
            {
                UserName = "BernieD",
               // Password = "Treatos",
                FirstName = "Bernie",
                LastName = "Doodle",
                Email = "bDoodle@gmail.com",
                Bio = "Ball is life"
            });
            //Assert
            Assert.Equal("Ball is life", repo.Users[0].Bio);
        }

        /******************************/
        [Fact]
        public void GetUserByUserName()
        {
            //Arrange
            FakeTripRepository repo = new FakeTripRepository();

            //Act
            repo.AddUser(new AppUser()
            {
                UserName = "BernieD",
              //  Password = "Treatos",
                FirstName = "Bernie",
                LastName = "Doodle",
                Email = "bDoodle@gmail.com",
                Bio = "Ball is life"
            });

            AppUser user = repo.GetUserByUserName("BernieD");

            //Assert
            Assert.Equal("Bernie", user.FirstName);
        }







    }
}
