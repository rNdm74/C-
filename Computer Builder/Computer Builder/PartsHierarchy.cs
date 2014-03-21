using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Builder
{
    enum PART
    {
        CPU_SINGLE_CORE,
        CPU_DUAL_CORE,
        CPU_QUAD_CORE,
        RAM_2GB,
        RAM_4GB,
        RAM_8GB,
        GPU_INTEL,
        GPU_NVIDIA,
        GPU_ATI
    }

    class PartsHierarchy
    {
        interface IPartFactory
        {
            Part getPart(PART part);
        }

        public class PartFactory : IPartFactory
        {            
            public Part getPart(PART part)
            {
                switch(part)
                {
                    case PART.CPU_SINGLE_CORE:  return new SingleCore();
                    case PART.CPU_DUAL_CORE:    return new DualCore();
                    case PART.CPU_QUAD_CORE:    return new QuadCore();
                    case PART.RAM_2GB:          return new Ram2GB();
                    case PART.RAM_4GB:          return new Ram4GB();
                    case PART.RAM_8GB:          return new Ram8GB();
                    case PART.GPU_INTEL:        return new IntelGpu();
                    case PART.GPU_NVIDIA:       return new NvidiaGpu();
                    case PART.GPU_ATI:          return new ATIGpu();
                    default:                    return new PartNotFound(); 
                }
            }
        }

        public class Part
        {
            protected string name;
            protected int price;
            public int Price 
            {
                get { return price; } // Read Only
            }
            public override string ToString()
            {
                return price.ToString() + "\t" + name;
            }
        }

        public class PartNotFound : Part
        {
            public PartNotFound()
            {
                name = "Part not found";
                price = 0;
            }
        }
        public class SingleCore : Part
        {
            public SingleCore()
            {
                name = "Single Core\t1.86 ghz";
                price = 129;
            }
        }
        public class QuadCore : Part
        {
            public QuadCore()
            {
                name = "Quad Core\t3.2 ghz";
                price = 450;
            }
        }
        public class DualCore : Part
        {
            public DualCore()
            {
                name = "Dual Core\t\t2.2 ghz";
                price = 250;
            }
        }

        public class Ram2GB : Part
        {
            public Ram2GB()
            {
                name = "2GB DDR3\t1600mhz";
                price = 50;
            }
        }

        public class Ram4GB : Part
        {
            public Ram4GB()
            {
                name = "4GB DDR3\t1600mhz";
                price = 90;
            }
        }

        public class Ram8GB : Part
        {
            public Ram8GB()
            {
                name = "8GB DDR3\t1600mhz";
                price = 160;
            }
        }

        public class NvidiaGpu : Part
        {
            public NvidiaGpu()
            {
                name = "Geforce 760\t2GB";
                price = 450;
            }
        }

        public class ATIGpu : Part
        {
            public ATIGpu()
            {
                name = "Radeon HD 8000\t1GB";
                price = 250;
            }
        }

        public class IntelGpu : Part
        {
            public IntelGpu()
            {
                name = "HD5000\t\t512MB Ram";
                price = 150;
            }
        }
    }
}
