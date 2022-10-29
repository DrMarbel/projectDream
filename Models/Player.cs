namespace projDream
{
    internal class Player
    {
        public string name;
        public string trueName = "Nomenon";
        public Stats stats = new Stats();
        public Bag inventory = new Bag();
        // This class is meant to be the model from which the player character is built upon
        // The Rival class inherits from this class
        public Player()
        {
            stats.Generate();
            inventory.Generate();
        }
    }
}