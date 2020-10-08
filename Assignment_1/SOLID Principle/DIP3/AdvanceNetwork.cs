using System;
using System.Collections.Generic;
using System.Text;

namespace DIP3
{
    public class AdvanceNetwork
    {
        private ILTESupport ilTESupport;

        public AdvanceNetwork(ILTESupport ilTESupport)
        {
            this.ilTESupport = ilTESupport;

        }

        public void UrbanArea()
        {
            ilTESupport.LteBTS();
        }
    }
}
