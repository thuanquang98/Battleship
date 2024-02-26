namespace BattleshipMultiplayer.Model
{
    public class Player
    {
        private readonly int player_id;
        private readonly string player_name;
        private readonly List<Ship> ships_list;
        public Player(int id, string name)
        {
            player_id = id;
            player_name = name;
            ships_list = new List<Ship>();
        }

        public int Id
        {
            get => player_id;
        }

        public string Name
        {
            get => player_name;
        }

        public void AddShip(Ship ship)
        {
            ships_list.Add(ship);
        }

    }
}