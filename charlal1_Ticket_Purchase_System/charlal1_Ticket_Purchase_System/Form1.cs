using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace charlal1_Ticket_Purchase_System
{
    public partial class Form1 : Form
    {
        // Constants
        private const double STUDENT_RATE = 10.00;
        private const double ADULT_RATE = 15.00;
        private const double SENIOR_RATE = 9.00;

        // Variables
        private IAllocateSeatSubject allocateSeatSubject;
        private Season season;
        private Door door;

        private Graphics canvasGallery, canvasGalleryRows, canvasGallerySeats;
        private Graphics canvasGods, canvasGodsRows, canvasGodsSeats;

        private bool[,] gallerySeating = new bool[CONSTS.COLS, CONSTS.GALLERY.Length];
        private bool[,] godsSeating = new bool[CONSTS.COLS, CONSTS.GODS.Length];

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set canvas for regent seating display
            canvasGallery = pSeatingDisplayGallery.CreateGraphics();
            canvasGalleryRows = pGalleryRows.CreateGraphics();
            canvasGallerySeats = pGallerySeats.CreateGraphics();
            canvasGods = pSeatingDisplayGods.CreateGraphics();
            canvasGodsRows = pGodsRows.CreateGraphics();
            canvasGodsSeats = pGodsSeats.CreateGraphics();

            // Create subject
            allocateSeatSubject = new Subject();
            allocateSeatSubject.AddObserver(new Gallery(canvasGallery, canvasGalleryRows, canvasGallerySeats, gallerySeating));
            allocateSeatSubject.AddObserver(new Gods(canvasGods, canvasGodsRows, canvasGodsSeats, godsSeating));

            // Create intefaces
            season = new Season(lAllocatedSeating, gallerySeating);
            door = new Door(lAllocatedSeating, godsSeating);                       
        }
        
        private void bBuySeat_Click(object sender, EventArgs e)
        {
            // Set ticket price
            if (rbStudent.Checked)
                SetPrice(rbStudent.Text);
            if (rbAdult.Checked)
                SetPrice(rbAdult.Text);
            if (rbSenior.Checked)
                SetPrice(rbSenior.Text);
            
            // allocate seat
            if (rbSeason.Checked)
                season.Update();
            else
                door.Update();
            
            // display
            //allocateSeatSubject.UpdateData(0, 0);
            allocateSeatSubject.NotifyObservers();
        }        
                
        private void SetPrice(string text) 
        {
            double price = 0;

            switch (text)
            {
                case "Student":
                    price = STUDENT_RATE;
                    break;
                case "Adult":
                    price = ADULT_RATE;
                    break;
                case "Senior":
                    price = SENIOR_RATE;
                    break;
            }

            lTicketPrice.Text = price.ToString("C"); // currency formating
        }
    
        private void bClear_Click(object sender, EventArgs e)
        {
            // Clear all data
            lTicketPrice.Text = "$0.00";
            lAllocatedSeating.Text = "";
            //season.AllocatedSeats = 0;
            //door.AllocatedSeats = 0;
            gallerySeating = new bool[CONSTS.COLS, CONSTS.GALLERY.Length];
            godsSeating = new bool[CONSTS.COLS, CONSTS.GODS.Length];

            season = new Season(lAllocatedSeating, gallerySeating);
            door = new Door(lAllocatedSeating, godsSeating); 
            allocateSeatSubject.Clear();
            allocateSeatSubject.AddObserver(new Gallery(canvasGallery, canvasGalleryRows, canvasGallerySeats, gallerySeating));
            allocateSeatSubject.AddObserver(new Gods(canvasGods, canvasGodsRows, canvasGodsSeats, godsSeating));
            allocateSeatSubject.NotifyObservers();
        }
        
        private void pSeatingDisplayGallery_Paint(object sender, PaintEventArgs e)
        {
            // Used to display grid
            allocateSeatSubject.NotifyObservers();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            // Updates price on radiobutton change
            RadioButton rb = (RadioButton)sender;

            SetPrice(rb.Text);
        }
    }
}
