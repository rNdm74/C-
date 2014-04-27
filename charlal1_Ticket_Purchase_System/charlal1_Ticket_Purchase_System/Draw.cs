using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace charlal1_Ticket_Purchase_System
{
    class Draw
    {
        public void Seating(Graphics canvas, int rows, bool[,] array)
        {
            canvas.Clear(Color.White);

            for (int col = 0; col < CONSTS.COLS; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if ((array[col, row]))
                    {
                        canvas.FillRectangle(Brushes.Turquoise, (col * CONSTS.WIDTH), (row * CONSTS.HEIGHT), CONSTS.WIDTH, CONSTS.HEIGHT);
                    }
                    else
                    {
                        canvas.FillRectangle(Brushes.White, (col * CONSTS.WIDTH), (row * CONSTS.HEIGHT), CONSTS.WIDTH, CONSTS.HEIGHT);
                    }

                    canvas.DrawRectangle(new Pen(Brushes.Black), (col * CONSTS.WIDTH), (row * CONSTS.HEIGHT), CONSTS.WIDTH, CONSTS.HEIGHT);
                }
            }
        }

        public void Row(Graphics canvas, string chars)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            for (int row = 0; row < chars.Length; row++)
            {
                // Create point for upper-left corner of drawing.
                PointF drawPoint = new PointF(0, CONSTS.HEIGHT * row);
                //
                canvas.DrawString(chars[row].ToString(), drawFont, drawBrush, drawPoint);
            }
        }

        public void Seats(Graphics canvas)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            for (int seat = 0; seat < CONSTS.COLS; seat++)
            {
                // Create point for upper-left corner of drawing.
                PointF drawPoint = new PointF(CONSTS.WIDTH * seat, 0);
                //
                canvas.DrawString((seat + 1).ToString(), drawFont, drawBrush, drawPoint);
            }
        }
    }
}
