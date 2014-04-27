using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace charlal1_Ticket_Purchase_System
{
    struct CONSTS
    {
        public const string GODS = "LMNOPQRS";
        public const string GALLERY = "ABCDEFGHIJK";

        public const int COLS = 20;
        public const int ROWS = 11;
        public const int WIDTH = 16;
        public const int HEIGHT = 16;
    }

    interface IAllocateSeatSubject
    {
        void Clear();
        void AddObserver(ITicketObserver o);
        void RemoveObserver(ITicketObserver o);
        void NotifyObservers();
    }

    class Subject : IAllocateSeatSubject
    {
        private List<ITicketObserver> observerList;
        
        public Subject()
        {            
            observerList = new List<ITicketObserver>();
        }

        public void Clear() 
        {
            observerList.Clear();
        }
        public void AddObserver(ITicketObserver o)
        {
            observerList.Add(o);
        }

        public void RemoveObserver(ITicketObserver o)
        {
            // Add error checking
            observerList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (ITicketObserver currentObserver in observerList)
                currentObserver.Update();
        }
    }

    interface ITicketObserver 
    {
        void Update();
        void Draw();
    }

    class Gallery : ITicketObserver
    {
        private Graphics canvasGallery, canvasGalleryRows, canvasGallerySeats;
        private Draw draw;
        

        private bool[,] gallerySeating;

        public Gallery(Graphics canvasGallery, Graphics canvasGalleryRows, Graphics canvasGallerySeats, bool[,] gallerySeating) 
        {
            this.canvasGallery = canvasGallery;
            this.canvasGalleryRows = canvasGalleryRows;
            this.canvasGallerySeats = canvasGallerySeats;
            this.gallerySeating = gallerySeating;
            this.draw = new Draw();
        }
        
        public void Update()
        {
            Draw();
        }

        public void Draw()
        {
            draw.Seating(canvasGallery, CONSTS.GALLERY.Length, gallerySeating);
            draw.Row(canvasGalleryRows, CONSTS.GALLERY);
            draw.Seats(canvasGallerySeats);
        }
    }

    class Gods : ITicketObserver
    {
        private Graphics canvasGods, canvasGodsRows, canvasGodsSeats;
        private Draw draw;
        
        private bool[,] godsSeating;

        public Gods(Graphics canvasGods, Graphics canvasGodsRows, Graphics canvasGodsSeats, bool[,] godsSeating) 
        {
            this.canvasGods = canvasGods;
            this.canvasGodsRows = canvasGodsRows;
            this.canvasGodsSeats = canvasGodsSeats;
            this.godsSeating = godsSeating;
            this.draw = new Draw();
        }

        public void Update()
        {
            Draw();
        }

        public void Draw()
        {
            draw.Seating(canvasGods, CONSTS.GODS.Length, godsSeating);
            draw.Row(canvasGodsRows, CONSTS.GODS);            
            draw.Seats(canvasGodsSeats);
        }
    }    
}

        
