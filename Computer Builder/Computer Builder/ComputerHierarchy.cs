using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Builder
{
    class ComputerHierarchy
    {   
        public abstract class Computer
        {
            protected PartsHierarchy.Part cpu;
            protected PartsHierarchy.Part ram;
            protected PartsHierarchy.Part gpu;
        }

        public class Business : Computer
        {
            public Business()
            {
                cpu = new PartsHierarchy.SingleCore();
                ram = new PartsHierarchy.Ram2GB();
                gpu = new PartsHierarchy.IntelGpu();
            }
        }
        public class Gaming : Computer
        {
            public Gaming()
            {
                cpu = new PartsHierarchy.QuadCore();
                ram = new PartsHierarchy.Ram8GB();
                gpu = new PartsHierarchy.NvidiaGpu();
            }
        }
        public class Media : Computer
        {
            public Media()
            {
                cpu = new PartsHierarchy.DualCore();
                ram = new PartsHierarchy.Ram4GB();
                gpu = new PartsHierarchy.ATIGpu();
            }
        }
    }
}
