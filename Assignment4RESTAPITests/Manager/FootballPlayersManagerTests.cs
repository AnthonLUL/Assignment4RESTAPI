using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4RESTAPI.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4RESTAPI.Manager.Tests
{
    [TestClass()]
    public class FootballPlayersManagerTests
    {
        private List<FootballPlayer> GetFootballPlayers()
        {
            var testPlayers = new List<FootballPlayer>();
            testPlayers.Add(new FootballPlayer{ Id = 1, Name = "Anthon", Age = 10, ShirtNumber = 22});
            testPlayers.Add(new FootballPlayer{ Id = 2, Name = "Messi", Age = 28, ShirtNumber = 10});
            testPlayers.Add(new FootballPlayer{ Id = 3, Name = "Ronaldo", Age = 26, ShirtNumber = 7});
            testPlayers.Add(new FootballPlayer{ Id = 4, Name = "Peter", Age = 40, ShirtNumber = 1});

            return testPlayers;
            
        }

        [TestMethod()]
        public void GetAllTest_returnsAllFootballplayers()
        {
            var testPlayers = GetFootballPlayers();
            var manager = new FootballPlayersManager();

            var result = manager.GetAll()  as List<FootballPlayer>;
            Assert.AreEqual(testPlayers.Count, result.Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            var testPlayers = GetFootballPlayers();
            var manager = new FootballPlayersManager();

            var result = manager.GetById(4) as FootballPlayer;

            Assert.IsNotNull(result);
            Assert.AreEqual(testPlayers[3].Name, result.Name);
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}