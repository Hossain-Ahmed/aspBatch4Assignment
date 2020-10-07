using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class Factory
    {
        IFactorySupport _factoryUtil; 
        public Factory(IFactorySupport factoryUtil) 
        {
           _factoryUtil = factoryUtil;
        }

        public void StartServiceMachine()
        {

            _factoryUtil.StartMachine();
        }
        public void StopServiceMachine()
        {

            _factoryUtil.StopMachine();
        }
    }
}
