using System;
using System.Collections.Generic;
using System.Text;

namespace SRP2
{
    public class Division
    {
        Messenger messenger = new Messenger();
        public  double result { get; set; }
        public void Divider(double a)
        {
            try
            {
                result = a / 0;
                
            }
            catch (Exception ex)
            {
                 messenger.Message(ex.ToString());
            }
        }
    }
}
