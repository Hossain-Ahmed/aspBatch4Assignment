using System;
using System.Collections.Generic;
using System.Text;

namespace DIP2
{
    public class SmartMobile
    {
        private AdvanceDisplaySupport displaySupport;

        public SmartMobile(AdvanceDisplaySupport displaySupport)
        {
            this.displaySupport = displaySupport;
        }


        public void Show() 
        {
            displaySupport.AmoledDisplay();
        }
    }
}
