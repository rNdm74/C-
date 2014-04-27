using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charlal1_Ticket_Purchase_System
{
    interface ITicket 
    {
        void Update();
        void Draw();

    }

    class Gallery : ITicket
    {
        public Gallery() 
        {
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }

    class Gods : ITicket
    {
        public Gods() 
        {
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }

    class Seating : ITicket
    {
        public Seating()
        {
        }
        
        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
