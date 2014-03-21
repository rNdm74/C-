using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Builder
{
    class PartsHierarchy
    {
        public class Part
        {
            protected string name;
            protected int price;
        }

        public class SingleCore : Part
        {
            public SingleCore()
            {
                name = "Single Core, 1.86 ghz";
                price = 129;
            }
        }
        public class QuadCore : Part
        {
            public QuadCore()
            {
                name = "Quad Core, 3.2 ghz";
                price = 450;
            }
        }
        public class DualCore : Part
        {
            public DualCore()
            {
                name = "Dual Core, 2.2 ghz";
                price = 250;
            }
        }

        public class Ram2GB : Part
        {
            public Ram2GB()
            {
                name = "2GB DDR3, 1600mhz";
                price = 50;
            }
        }

        public class Ram4GB : Part
        {
            public Ram4GB()
            {
                name = "4GB DDR3, 1600mhz";
                price = 90;
            }
        }

        public class Ram8GB : Part
        {
            public Ram8GB()
            {
                name = "8GB DDR3, 1600mhz";
                price = 160;
            }
        }

        public class NvidiaGpu : Part
        {
            public NvidiaGpu()
            {
                name = "Geforce 760, 2GB";
                price = 450;
            }
        }

        public class ATIGpu : Part
        {
            public ATIGpu()
            {
                name = "Radeon HD 8000, 1GB";
                price = 250;
            }
        }

        public class IntelGpu : Part
        {
            public IntelGpu()
            {
                name = "HD5000, 512MB Ram";
                price = 150;
            }
        }
    }
}
