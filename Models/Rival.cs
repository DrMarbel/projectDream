namespace projDream
{
    internal class Rival : Player
    {
        // This class inherits from Player and will serve to create the rival character that the player encounters within the game
        int rID;

        // This method is meant to begin the launch sequence for the Rival's AI system

        public Rival LaunchAI_Init_Protocols()
        {
            Rival rival = new Rival();
            int[] ID_Ports = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            string[] characters;
            Random rand = new Random();

            // Generate a random number and assign it to rID
            // rID will determine which character will serve as the protagonist's rival throughout the game
            rID = rand.Next(1, ID_Ports.Length);

            characters = File.ReadAllLines(@"D:\Projects\Programming\projectDream\characterList.txt");

            rival.name = characters[rID];

            return rival;
        }
    }
}