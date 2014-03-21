using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Builder
{
    class ComputerFactoryHierarchy
    {
        interface IComputerFactory
        {
            ComputerHierarchy.Computer BuildComputer();
        }

        public class ComputerFactory : IComputerFactory
        {
            public ComputerHierarchy.Computer BuildComputer(COMPUTER computerType)
            {
                switch (computerType)
                {
                    case COMPUTER.BUSINESS:
                        return new ComputerHierarchy.Business();
                    case COMPUTER.GAMING:
                        return new ComputerHierarchy.Gaming();
                    case COMPUTER.MEDIA:
                        return new ComputerHierarchy.Media();
                    default:
                        return new ComputerHierarchy.Business(); // Default machine type
                }
            }
        }
    }
}
