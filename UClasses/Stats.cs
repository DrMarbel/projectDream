namespace projDream
{
    internal class Stats
    {
        // Private variables
        private int hp = 10;
        private int str = 5;
        private int dex = 5;
        private int intel = 5;
        private int wis = 5;
        private int charisma = 5;
        private int agil = 5;
        private int spd;

        // Public variables
        public List<int> stats = new List<int>();
        public Random r = new Random();
        private List<int> statistics = new List<int>();

        public void Generate()
        {
            statistics.Add(hp);
            statistics.Add(str);
            statistics.Add(dex);
            statistics.Add(intel);
            statistics.Add(wis);
            statistics.Add(charisma);
            statistics.Add(agil);
            statistics.Add(spd);

            for (int i = 0; i < 7; i++)
            {
                stats.Add(statistics[i] = AlterStat(r.Next(1, 5), statistics[i]));
            }

            /*
            stats.Add(hp = AlterStat(r.Next(1, 5)));
            stats.Add(str = AlterStat(r.Next(1, 5)));
            stats.Add(dex = AlterStat(r.Next(1, 5)));
            stats.Add(intel = AlterStat(r.Next(1, 5)));
            stats.Add(wis = AlterStat(r.Next(1, 5)));
            stats.Add(charisma = AlterStat(r.Next(1, 5)));
            stats.Add(spd = AlterStat(r.Next(1, 5)));
            stats.Add(agil = spd * dex);
            */

            statistics = stats;
        }

        public int AlterStat(int rand, int statNum)
        {
            Random r = new Random();
            int alteredStat;

            if (r.Next(0, 1) == 0)
            {
                alteredStat = statNum - rand;
            }
            else
            {
                alteredStat = statNum + rand;
            }


            return alteredStat;
        }
    }
}