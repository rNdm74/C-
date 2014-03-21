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
            Computer BuildComputer();
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
            public Computer BuildComputer()
            {
                return new Computer
                (
                    partFactory.getPart(PART.CPU_SINGLE_CORE),
                    partFactory.getPart(PART.RAM_2GB),
                    partFactory.getPart(PART.GPU_INTEL)
                );
            }
        }

        public class GamingFactory : ComputerFactory, IComputerFactory
        {
            public Computer BuildComputer()
            {
                return new Computer
                (
                    partFactory.getPart(PART.CPU_QUAD_CORE),
                    partFactory.getPart(PART.RAM_8GB),
                    partFactory.getPart(PART.GPU_NVIDIA)
                );
            }
        }

        public class MediaFactory : ComputerFactory, IComputerFactory
        {
            public Computer BuildComputer()
            {
                return new Computer
                (
                    partFactory.getPart(PART.CPU_DUAL_CORE),
                    partFactory.getPart(PART.RAM_4GB),
                    partFactory.getPart(PART.GPU_ATI)
                );
            }
        }

        public class Computer
        {
            protected PartsHierarchy.Part cpu;
            protected PartsHierarchy.Part ram;
            protected PartsHierarchy.Part gpu;

            public Computer(PartsHierarchy.Part cpu, PartsHierarchy.Part ram, PartsHierarchy.Part gpu)
            {
                this.cpu = cpu;
                this.ram = ram;
                this.gpu = gpu;
            }

            // Accessors - READ ONLY
            public string Cpu
            { 
                get{ return cpu.ToString();}
            }
            public string Ram 
            { 
                get { return ram.ToString(); } 
            }
            public string Gpu 
            { 
                get { return gpu.ToString(); } 
            }
            public int TotalPrice()
            {
                return cpu.Price + ram.Price + gpu.Price;
            }
        }
    }
}
