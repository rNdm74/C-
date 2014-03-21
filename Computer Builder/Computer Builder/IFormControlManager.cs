using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Builder
{
    interface IFormControlManager
    {
        void update(COMPUTER computerType);
        void display();
    }

    public class FormControlManager : IFormControlManager
    {                
        // Variables
        private ListBox listBox;  
      
        private ComputerHierarchy.IComputerFactory computerFactory;

        public FormControlManager(ListBox listBox)
        {
            this.listBox = listBox; 
        }
        
        public void update(COMPUTER computerType)
        {
            listBox.Items.Clear();

            switch (computerType)
            {
                case COMPUTER.BUSINESS:
                    computerFactory = new ComputerHierarchy.BusinessFactory();
                    break;
                case COMPUTER.GAMING:
                    computerFactory = new ComputerHierarchy.GamingFactory();
                    break;
                case COMPUTER.MEDIA:
                    computerFactory = new ComputerHierarchy.MediaFactory();
                    break;
            }     
        }

        public void display()
        {
            PartsHierarchy.Part cpu = computerFactory.GetCpu();
            PartsHierarchy.Part ram = computerFactory.GetRam();
            PartsHierarchy.Part gpu = computerFactory.GetGpu();

            listBox.Items.Add("Price\tComponent\tSpeed");
            listBox.Items.Add("---------------------------------------------------------------------------------------------");
            listBox.Items.Add(cpu.ToString());
            listBox.Items.Add(ram.ToString());
            listBox.Items.Add(gpu.ToString());
            listBox.Items.Add("---------------------------------------------------------------------------------------------");
            listBox.Items.Add("Total Price: " + (cpu.Price + ram.Price + gpu.Price));
        }
    }
}
