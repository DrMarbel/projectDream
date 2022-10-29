using static System.Console;

namespace projDream
{
    internal class Game
    {
        public void Initialize()
        {
            Player protag = new Player();
            Rival rival = new Rival().LaunchAI_Init_Protocols();

            //Debug
            WriteLine(protag.trueName);

            for (int i = 0; i < protag.stats.stats.Count; i++)
            {
                Write(protag.stats.statistics[i]);
                WriteLine(protag.stats.stats[i]);
            }
            
            WriteLine(rival.name);
        }
    }
}