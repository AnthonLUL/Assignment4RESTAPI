using Assignment1;
using Assignment4RESTAPI.Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayersManagerTest
{
    [TestClass]
    public class FootballPlayersTest
    {
        FootballPlayersManager footballPlayersManager = new FootballPlayersManager();

    
        [TestMethod]
        public void GetAllTest()
        {
            List<FootballPlayer> expected = new List<FootballPlayer>()
            {
            new FootballPlayer{Id = 2, Name = "Anthon", Age = 22, ShirtNumber = 1},
            new FootballPlayer{Id = 1, Name = "Messi", Age = 28, ShirtNumber = 10},
            new FootballPlayer{Id = 3, Name = "Ronaldo", Age = 27, ShirtNumber = 7},
            new FootballPlayer{Id = 4, Name = "Peter", Age = 2, ShirtNumber = 22}
            };

            List<FootballPlayer> result =  footballPlayersManager.GetAll();
            CollectionAssert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(2)]
        public void GetById(int id)
        {
            List<FootballPlayer> list = new List<FootballPlayer>()
            {
            new FootballPlayer{Id = 1, Name = "Anthon", Age = 2, ShirtNumber = 11 },
            new FootballPlayer{Id = 2, Name = "Peter", Age = 3, ShirtNumber = 7 },
            new FootballPlayer{Id = 3, Name = "Peter", Age = 6, ShirtNumber = 28}
            };

            int idd = 1;
            FootballPlayer expected = list[idd];

            FootballPlayer actual = footballPlayersManager.GetById(idd);

            Assert.AreEqual(expected, actual);

        }

    }
}