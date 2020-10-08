using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Laptop
    {
        private IProcessor iprocessor;
        public Laptop(IProcessor iprocessor)
        {
            this.iprocessor = iprocessor;
        }

        public void run()
        {
            iprocessor.AdvancedProcessor();
        }

    }
}
