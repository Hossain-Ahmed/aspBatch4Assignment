using System;
using System.Collections.Generic;
using System.Text;

namespace DIP3
{
    public class NormalNetwork
    {
        private INormalSupport inormalSupport;

        public NormalNetwork(INormalSupport inormalSupport)
        {
            this.inormalSupport = inormalSupport;
        }


        public void RuralArea()
        {
            inormalSupport.NormalBTS();
        }
    }
}
