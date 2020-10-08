using System;

namespace DIP3
{
    class Program
    {
        static void Main(string[] args)
        {
            TowerNormal towerNormal = new TowerNormal();
            NormalNetwork normalNetwork = new NormalNetwork(towerNormal);

            TowerAdvance towerAdvance = new TowerAdvance();
            AdvanceNetwork advance = new AdvanceNetwork(towerAdvance);

        }
    }
}
