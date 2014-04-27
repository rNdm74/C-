using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace charlal1_Ticket_Purchase_System
{
    interface ISales
    {
        void Update();
        void Draw();
    }
    class Sales
    {
        protected Label lAllocatedSeating;
        protected bool[,] seating;
        protected int[] seat;
        protected string allocatedSeatLabel = "";
        protected int allocatedSeats = 0;

        public int AllocatedSeats 
        {
            set { value = allocatedSeats; }
        }

        protected int[] getSeat(bool[,] seating, int maxCols, int maxRows)
        {
            Random rGen = new Random();

            // Allocate col and row
            int col = rGen.Next(maxCols);
            int row = rGen.Next(maxRows);

            // set col row until seating [false]
            while (seating[col, row])
            {
                col = rGen.Next(maxCols);
                row = rGen.Next(maxRows);
            }

            // seat is allocated
            seating[col, row] = true;

            // 
            return new int[] { col, row };
        }
    }

    class Season : Sales, ISales
    {
        public Season(Label lAllocatedSeating, bool[,] seating)
        {
            this.lAllocatedSeating = lAllocatedSeating;
            this.seating = seating;
        }

        public void Update()
        {
            // Checks so that no more seats are allocated
            if (allocatedSeats < CONSTS.COLS * CONSTS.GALLERY.Length)
            {
                // allocate seat
                seat = getSeat(seating, CONSTS.COLS, CONSTS.GALLERY.Length);

                // update for label
                allocatedSeatLabel = allocatedSeats + " : Gallery : " + CONSTS.GALLERY[seat[1]] + "," + (seat[0] + 1);

                // keep track of allocated seats
                allocatedSeats++;
            }
            else
            {
                MessageBox.Show("All seating has been allocated");
            }
            
            Draw();
        }

        public void Draw()
        {
            lAllocatedSeating.Text = allocatedSeatLabel;
        }
    }

    class Door : Sales, ISales
    {
        public Door(Label lAllocatedSeating, bool[,] seating)
        {
            this.lAllocatedSeating = lAllocatedSeating;
            this.seating = seating;
        }

        public void Update()
        {
            // Checks so that no more seats are allocated
            if (allocatedSeats < CONSTS.COLS * CONSTS.GODS.Length)
            {
                // allocate seat
                seat = getSeat(seating, CONSTS.COLS, CONSTS.GODS.Length);

                // update for label
                allocatedSeatLabel = allocatedSeats + " : Gods : " + CONSTS.GODS[seat[1]] + "," + (seat[0] + 1);

                // keep track of allocated seats
                allocatedSeats++;
            }
            else
            {
                MessageBox.Show("All seats have been allocated");
            }
            
            Draw();
        }

        public void Draw()
        {
            lAllocatedSeating.Text = allocatedSeatLabel;
        }
    }
}
