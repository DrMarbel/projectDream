namespace projDream
{
    internal class Bag
    {
        // This class is meant to act as the inventory of the player and all NPCs within the game
        int numPock = 5;

        /// <summary>
        /// Generates the initial inventory for all players
        /// </summary>
        public void Generate()
        {
            List<string> armor = new List<string>();
            string gauntlet;
            string greaves;
            string helm;
            string breastplate;
            string boots;

            armor.Add(gauntlet = null);
            armor.Add(greaves = null);
            armor.Add(helm = null);
            armor.Add(breastplate = null);
            armor.Add(boots = null);

            /*
            slot0.item.name = "Shortbow";
            slot1.item.name = "Daggar";
            slot2.item.name = "Hand Axe";
            slot3.item.name = "Elixir";
            slot4.item.name = "Tonic";
            */
        }

        /*
        public void ChrisPlayArea(){
            BagPocket[] bag = new BagPocket[numPock];

            for(i = 0; i < 31; i++){
                Console.Writeline(bag[2, i]);
            }
        }
        */
    }

    internal class BagPocket{

    }
}