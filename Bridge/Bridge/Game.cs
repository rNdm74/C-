using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bridge
{
    class Game
    {
        Bitmap[] images;

        public Game() 
        {

            images = new Bitmap[53];

            for (int card = 1; card < images.Length; card++)
            {                
                images[card] = (Bitmap) Properties.Resources.ResourceManager.GetObject("assets/" + card.ToString() + ".jpg");
            }            
        }

        public void draw(Graphics canvas) 
        {           

            for (int card = 0; card < images.Length; card++)
            {
                Rectangle dstRect = new Rectangle(0, 0, 100, 100);
                Rectangle srcRect = new Rectangle(0,0, images[card].Width, images[card].Height);

                canvas.DrawImage(images[card], dstRect, srcRect, GraphicsUnit.Pixel); 
            }
        }
    }
}
