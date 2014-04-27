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
        public Form1()
        {
            InitializeComponent();
        }

        private static bool[,] gallerySeating = new bool[COLS, GALLERY.Length];
        private static bool[,] godsSeating = new bool[COLS, GODS.Length];

        private const string GALLERY = "ABCDEFGHIJK";
        private const string GODS = "LMNOPQRS";

        private const int COLS = 20;
        private const int ROWS = 11;
        private const int WIDTH = 16;
        private const int HEIGHT = 16;

        private const double STUDENT_RATE = 10.00;
        private const double ADULT_RATE = 15.00;
        private const double SENIOR_RATE = 9.00;

        private int allocatedGallerySeats = 0;
        private int allocatedGodsSeats = 0;


        private Graphics canvasGallery, canvasGalleryRows, canvasGallerySeats;
        private Graphics canvasGods, canvasGodsRows, canvasGodsSeats;
                
        private void Form1_Load(object sender, EventArgs e)
        {
            canvasGallery = pSeatingDisplayGallery.CreateGraphics();
            canvasGalleryRows = pGalleryRows.CreateGraphics();
            canvasGallerySeats = pGallerySeats.CreateGraphics();

            canvasGods = pSeatingDisplayGods.CreateGraphics();
            canvasGodsRows = pGodsRows.CreateGraphics();
            canvasGodsSeats = pGodsSeats.CreateGraphics();
        }

        void DrawSeating()
        {
            Draw(canvasGallery, GALLERY.Length, gallerySeating);
            Draw(canvasGods, GODS.Length, godsSeating);

            // Draw string to screen.
            DrawRow(canvasGalleryRows, GALLERY);
            DrawRow(canvasGodsRows, GODS);
            DrawSeats(canvasGallerySeats);
            DrawSeats(canvasGodsSeats);
        }

        void Draw(Graphics canvas, int rows, bool[,] array)
        {
            canvas.Clear(pSeatingDisplayGallery.BackColor);

            for (int col = 0; col < COLS; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if ((array[col, row]))
                    {
                        canvas.FillRectangle(Brushes.Turquoise, (col * WIDTH), (row * HEIGHT), WIDTH, HEIGHT);
                    }
                    else
                    {
                        canvas.FillRectangle(Brushes.White, (col * WIDTH), (row * HEIGHT), WIDTH, HEIGHT);
                    }

                    canvas.DrawRectangle(new Pen(Brushes.Black), (col * WIDTH), (row * HEIGHT), WIDTH, HEIGHT);
                }
            }
        }

        void DrawRow(Graphics canvas, string chars)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            for (int row = 0; row < chars.Length; row++)
            {
                // Create point for upper-left corner of drawing.
                PointF drawPoint = new PointF(0, HEIGHT * row);
                //
                canvas.DrawString(chars[row].ToString(), drawFont, drawBrush, drawPoint);
            }
        }

        void DrawSeats(Graphics canvas) 
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            for (int seat = 0; seat < COLS; seat++)
            {
                // Create point for upper-left corner of drawing.
                PointF drawPoint = new PointF(WIDTH * seat, 0);
                //
                canvas.DrawString((seat + 1).ToString(), drawFont, drawBrush, drawPoint);
            }
        }
        
        private void bBuySeat_Click(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
                SetPrice(rbStudent.Text);
            if (rbAdult.Checked)
                SetPrice(rbAdult.Text);
            if (rbSenior.Checked)
                SetPrice(rbSenior.Text);

            AllocateSeat();
            DrawSeating();
        }

        void AllocateSeat() 
        {
            Random rGen = new Random();

            int col = 0;
            int row = 0;

            string allocatedSeat = "";

            if (rbSeason.Checked)
            {
                if (allocatedGallerySeats < COLS * GALLERY.Length)
                {
                    col = rGen.Next(COLS);
                    row = rGen.Next(GALLERY.Length);

                    while (gallerySeating[col, row])
                    {
                        col = rGen.Next(COLS);
                        row = rGen.Next(GALLERY.Length);
                    }

                    allocatedSeat = "Gallery - " + GALLERY[row] + "," + (col + 1);
                    gallerySeating[col, row] = true;
                    allocatedGallerySeats++;
                }
                else
                {
                    MessageBox.Show("All seating has been allocated");
                }
                
            }
            else
            {
                if (allocatedGodsSeats < COLS * GODS.Length)
                {
                    col = rGen.Next(COLS);
                    row = rGen.Next(GODS.Length);

                    while (godsSeating[col, row])
                    {
                        col = rGen.Next(COLS);
                        row = rGen.Next(GODS.Length);
                    }

                    allocatedSeat = "Gods - " + GODS[row] + "," + (col + 1);
                    godsSeating[col, row] = true;
                    allocatedGodsSeats++;
                }
                else 
                {
                    MessageBox.Show("All seats have been allocated");
                }
                
            }

            lAllocatedSeating.Text = allocatedSeat;
        }
        
        void SetPrice(string text) 
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

            lTicketPrice.Text = price.ToString("C");
        }
    
        private void bClear_Click(object sender, EventArgs e)
        {
            lTicketPrice.Text = "$0.00";
            lAllocatedSeating.Text = "";
            allocatedGallerySeats = 0;
            allocatedGodsSeats = 0;
            gallerySeating = new bool[COLS, GALLERY.Length];
            godsSeating = new bool[COLS, GODS.Length];
            DrawSeating();
        }
        
        private void pSeatingDisplayGallery_Paint(object sender, PaintEventArgs e)
        {
            DrawSeating();
        }    
    }
}
