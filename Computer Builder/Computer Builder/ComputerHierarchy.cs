using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Builder
{
    class ComputerHierarchy
    {
        public interface IComputerFactory
        {
            PartsHierarchy.Part GetCpu();
            PartsHierarchy.Part GetRam();
            PartsHierarchy.Part GetGpu();
        }

        public abstract class ComputerFactory
        {
            protected PartsHierarchy.PartFactory partFactory;

            public ComputerFactory() 
            {
                partFactory = new PartsHierarchy.PartFactory();
            }
        }

        public class BusinessFactory : ComputerFactory, IComputerFactory
        {
            public PartsHierarchy.Part GetCpu()
            {
                return partFactory.getPart(PART.CPU_SINGLE_CORE);
            }

            public PartsHierarchy.Part GetRam()
            {
                return partFactory.getPart(PART.RAM_2GB);
            }

            public PartsHierarchy.Part GetGpu()
            {
                return partFactory.getPart(PART.GPU_INTEL);
            }
        }

        public class GamingFactory : ComputerFactory, IComputerFactory
        {
            public PartsHierarchy.Part GetCpu()
            {
                return partFactory.getPart(PART.CPU_QUAD_CORE);
            }

            public PartsHierarchy.Part GetRam()
            {
                return partFactory.getPart(PART.RAM_8GB);
            }

            public PartsHierarchy.Part GetGpu()
            {
                return partFactory.getPart(PART.GPU_NVIDIA);
            }
        }

        public class MediaFactory : ComputerFactory, IComputerFactory
        {
            public PartsHierarchy.Part GetCpu()
            {
                return partFactory.getPart(PART.CPU_DUAL_CORE);
            }

            public PartsHierarchy.Part GetRam()
            {
                return partFactory.getPart(PART.RAM_4GB);
            }

            public PartsHierarchy.Part GetGpu()
            {
                return partFactory.getPart(PART.GPU_ATI);
            }
        }
    }
}
