using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mix_and_Match
{
    interface IFormControlManager
    {
        void DisplayHead();
        void DisplayBody();
        void DisplayLegs();
    }

    public class FormControlManager : IFormControlManager
    {
        public FormControlManager()
        { 
        }

        public void DisplayHead()
        {
            throw new NotImplementedException();
        }

        public void DisplayBody()
        {
            throw new NotImplementedException();
        }

        public void DisplayLegs()
        {
            throw new NotImplementedException();
        }
    }

    
}
