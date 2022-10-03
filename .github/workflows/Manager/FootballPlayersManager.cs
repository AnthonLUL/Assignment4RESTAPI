using Assignment1;

namespace Assignment4RESTAPI.Manager
{
    public class FootballPlayersManager
    {
        private static int _nextId = 1;

        public static List<FootballPlayer> PlayerList = new List<FootballPlayer>()
        {
            new FootballPlayer{Id = 2, Name = "Anthon", Age = 22, ShirtNumber = 1},
            new FootballPlayer{Id = 1, Name = "Messi", Age = 28, ShirtNumber = 10},
            new FootballPlayer{Id = 3, Name = "Ronaldo", Age = 27, ShirtNumber = 7},
            new FootballPlayer{Id = 4, Name = "Peter", Age = 2, ShirtNumber = 22}
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(PlayerList);
        }


        public FootballPlayer GetById(int id)
        {
            return PlayerList.Find(player => player.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newFootballPlayer)
        {
            newFootballPlayer.Id = _nextId++;
            PlayerList.Add(newFootballPlayer);
            return newFootballPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer footballPlayer = PlayerList.Find(player1 => player1.Id == id);
            if (footballPlayer == null) return null;
            PlayerList.Remove(footballPlayer);
            return footballPlayer;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer footballPlayer = PlayerList.Find(player1 => player1.Id == id);
            if (footballPlayer == null) return null;
            footballPlayer.Name = updates.Name;
            footballPlayer.Age = updates.Age;
            footballPlayer.ShirtNumber = updates.ShirtNumber;
            return footballPlayer;
        }
    }
}
