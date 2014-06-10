using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace charlal1.project.DiscreteEventSimulator
{
    enum ELabelType 
    { 
        L_ARRIVAL, 
        L_IVR, 
        L_OTHER_QUEUE, 
        L_CAR_STEREO_QUEUE, 
        L_RESOURCE_OTHER, 
        L_RESOURCE_CAR_STEREO 
    }

    interface IGraphicalDisplay 
    {
        void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics);
        void Draw();
    }

    class GraphicalDisplay : IGraphicalDisplay
    {
        private Panel pGraphical;

        public List<string> Arrival;
        public List<string> SwitchComplete;
        public List<string> QueueOther;
        public List<string> QueueCarStereo;
        public List<string> ResourceOther;
        public List<string> ResourceCarStereo;

        private GraphicalDisplayFactory gdFactory;

        public GraphicalDisplay(Panel pGraphical) 
        {
            this.pGraphical = pGraphical;
            this.gdFactory = new GraphicalDisplayFactory(this);

            Arrival = new List<string>();
            SwitchComplete = new List<string>();
            QueueOther = new List<string>();
            QueueCarStereo = new List<string>();
            ResourceOther = new List<string>();
            ResourceCarStereo = new List<string>();

            //pGraphical.Controls.Add(gdFactory.MakeLabel(ELabelType.L_ARRIVAL));
            //pGraphical.Controls.Add(gdFactory.MakeLabel(ELabelType.L_IVR));
            //pGraphical.Controls.Add(gdFactory.MakeLabel(ELabelType.L_OTHER_QUEUE));
            //pGraphical.Controls.Add(gdFactory.MakeLabel(ELabelType.L_CAR_STEREO_QUEUE));
            //pGraphical.Controls.Add(gdFactory.MakeLabel(ELabelType.L_RESOURCE_OTHER));
            //pGraphical.Controls.Add(gdFactory.MakeLabel(ELabelType.L_RESOURCE_CAR_STEREO));
        }

        public void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            Arrival.Clear();
            SwitchComplete.Clear();
            QueueOther.Clear();
            QueueCarStereo.Clear();
            ResourceOther.Clear();
            ResourceCarStereo.Clear();

            process(resourceMananger.GetQueueEntityData(ECallType.OTHER));
            process(resourceMananger.GetQueueEntityData(ECallType.CAR_STEREO));
            process(calender.GetEventData());
        }

        private void process(List<String[]> list) 
        {
            foreach (string[] data in list)
            {
                string entityID = data[Constants.EVENT_ENTITY_POS];
                string eventType = data[Constants.EVENT_TYPE_POS];
                string callType = data[Constants.EVENT_CALL_TYPE_POS];

                List<string> updatedList = null;

                if (eventType.Equals(EEventType.ARRIVAL.ToString()))
                    updatedList = Arrival;
                
                if (eventType.Equals(EEventType.SWITCH_COMPLETE.ToString()))
                    updatedList = SwitchComplete;
                
                if (eventType.Equals("---") && callType.Equals(ECallType.OTHER.ToString()))
                    updatedList = QueueOther;

                if (eventType.Equals("---") && callType.Equals(ECallType.CAR_STEREO.ToString()))
                    updatedList = QueueCarStereo;
                
                if (eventType.Equals(EEventType.PROCESSING_COMPLETE.ToString()) && callType.Equals(ECallType.OTHER.ToString()))
                    updatedList = ResourceOther;
                
                if (eventType.Equals(EEventType.PROCESSING_COMPLETE.ToString()) && callType.Equals(ECallType.CAR_STEREO.ToString()))
                    updatedList = ResourceCarStereo;

                if(!eventType.Equals(EEventType.END_SIMULATION.ToString()))
                    updatedList.Add(entityID);
            }
        }

        public void Draw()
        {
            // Clear controls
            foreach (Control c in pGraphical.Controls)
            {
                foreach (Label l in c.Controls.Find("lEntity", true))
                {
                    c.Controls.Remove(l);
                    //pGraphical.Controls[1].Controls.Remove(l);
                    //pGraphical.Controls[2].Controls.Remove(l);
                    //pGraphical.Controls[3].Controls.Remove(l);
                    //pGraphical.Controls[4].Controls.Remove(l);
                    //pGraphical.Controls[5].Controls.Remove(l);
                }
            }

            pGraphical.Controls[4].Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_OTHER_QUEUE));
            pGraphical.Controls[3].Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_CAR_STEREO_QUEUE));
            pGraphical.Controls[2].Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_ARRIVAL));
            pGraphical.Controls[5].Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_IVR));
            pGraphical.Controls[0].Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_RESOURCE_OTHER));
            pGraphical.Controls[1].Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_RESOURCE_CAR_STEREO));

            pGraphical.Controls[0].Refresh();
            pGraphical.Controls[1].Refresh();
            pGraphical.Controls[2].Refresh();
            pGraphical.Controls[3].Refresh();
            pGraphical.Controls[4].Refresh();
            pGraphical.Controls[5].Refresh();
        }
    }

    class GraphicalDisplayFactory
    {
        private const int SIZE = 64;

        private GraphicalDisplay gDisplay;

        public GraphicalDisplayFactory(GraphicalDisplay gDisplay) 
        {
            this.gDisplay = gDisplay;
        }

        public Label[] MakeQueue(ELabelType labelType)
        {
            switch (labelType)
            {
                case ELabelType.L_ARRIVAL:
                    return makeEntityLabelList(gDisplay.Arrival, Color.LightGreen, 32, 32);
                case ELabelType.L_IVR:
                    return makeEntityLabelList(gDisplay.SwitchComplete, Color.LightGoldenrodYellow, 32, 32);
                case ELabelType.L_OTHER_QUEUE:
                    return makeEntityLabelList(gDisplay.QueueOther, Color.LightBlue, 32, 32);
                case ELabelType.L_CAR_STEREO_QUEUE:
                    return makeEntityLabelList(gDisplay.QueueCarStereo, Color.LightPink, 32, 32);
                case ELabelType.L_RESOURCE_OTHER:
                    return makeEntityLabelList(gDisplay.ResourceOther, Color.LightBlue, 32, 32);
                case ELabelType.L_RESOURCE_CAR_STEREO:
                    return makeEntityLabelList(gDisplay.ResourceCarStereo, Color.LightPink, 32, 32);
                default:
                    return new Label[0];
            }
            
        }

        public Label MakeLabel(ELabelType labelType) 
        {
            switch (labelType)
            {
                case ELabelType.L_ARRIVAL:
                    return makeLabel(Constants.ARRIVAL, 32, 192);
                case ELabelType.L_IVR:
                    return makeLabel(Constants.SWITCH, 164, 192);
                case ELabelType.L_OTHER_QUEUE:
                    return makeLabel(Constants.OTHER_QUEUE, 312, 32);
                case ELabelType.L_CAR_STEREO_QUEUE:
                    return makeLabel(Constants.STEREO_QUEUE, 312, 240);
                case ELabelType.L_RESOURCE_OTHER:
                    return makeLabel(Constants.OTHER_RESOURCE, 740, 32);
                case ELabelType.L_RESOURCE_CAR_STEREO:
                    return makeLabel(Constants.STEREO_RESOURCE, 740, 364);
                default:
                    return new Label { Text = "Default Label" };
            }
        }

        private Label makeLabel(string text, int x, int y)
        {
            return new Label 
            {
                Text = text,
                AutoSize = true,
                Location = new Point(x, y),
                Name = "l" + text
            };
        }

        private Label[] makeEntityLabelList(List<string> list, Color color, int startX, int startY) 
        {
            Label[] labelList = null;

            try
            {
                labelList = new Label[list.Count];

                for (int col = 0; col < labelList.Length; col++)
                {
                    string text = list[col];

                    int x = (startX - SIZE) + ((list.Count - col) * SIZE);
                    int y = startY;

                    labelList[col] = makeEntityLabel(text, color, x, y);
                }
            }
            catch (Exception)
            {
                
                //throw;
            }
            

            return labelList;
        }

        private Label makeEntityLabel(string text, Color color, int x, int y)
        {
            return new Label 
            { 
                BackColor = color,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Location = new Point(x, y),
                Name = "lEntity",
                Size = new System.Drawing.Size(SIZE, SIZE),
                Text = text,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
        }
    }
}
