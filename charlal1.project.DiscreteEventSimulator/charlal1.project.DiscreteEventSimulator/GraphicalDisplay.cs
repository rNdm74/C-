using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace charlal1.project.DiscreteEventSimulator
{
    interface IGraphicalDisplay 
    {
        void Update(List<String[]> otherQueue, List<String[]> carStereoQueue, List<String[]> calenderList);
        void Draw(Panel pGraphical);
    }

    class GraphicalDisplay : IGraphicalDisplay
    {
        private Panel pGraphical;
        private List<String[]> otherQueue;
        private List<String[]> carStereoQueue;
        private List<String[]> calenderList;

        public GraphicalDisplay(Panel pGraphical) 
        {
            this.pGraphical = pGraphical;
        }

        public void Update(List<String[]> otherQueue, List<String[]> carStereoQueue, List<String[]> calenderList)
        {
            this.otherQueue = otherQueue;
            this.carStereoQueue = carStereoQueue;
            this.calenderList = calenderList;
        }

        public void Draw(Panel pGraphical)
        {
            pGraphical.Controls.Clear();



            pGraphical.Refresh();
        }

        private Label InitLabel(string text, Point location) 
        {
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            label.Location = location;
            label.Name = "l" + text;

            return label;
        }

        private Label InitEntityLabel(string id, Point location, Color color)
        {
            Label label = new Label();
            label.BackColor = color;
            label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label.Location = location;
            label.Name = "l" + id;
            label.Size = new System.Drawing.Size(32, 32);
            label.Text = id;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return label;
        }
    }
}
