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

        private Control cArrival;
        private Control cSwitchComplete;
        private Control cQueueOther;
        private Control cQueueCarStereo;
        private Control cResourceOther;
        private Control cResourceCarStereo;
        private Control cTimeDisplay;

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

            // Get indexes of the gbControls
            int gbArrivalIndex = pGraphical.Controls.IndexOfKey("gbArrival");
            int gbSwitchIndex = pGraphical.Controls.IndexOfKey("gbSwitch");
            int gbOtherQueueIndex = pGraphical.Controls.IndexOfKey("gbOtherQueue");
            int gbCarStereoQueueIndex = pGraphical.Controls.IndexOfKey("gbCarStereoQueue");
            int gbResourcesOtherIndex = pGraphical.Controls.IndexOfKey("gbResourcesOther");
            int gbResourcesCarStereoIndex = pGraphical.Controls.IndexOfKey("gbResourcesCarStereo");
            int lTimeDisplayIndex = pGraphical.Controls.IndexOfKey("lTimeDisplay");

            // Add the controls from pGraphics
            cArrival = pGraphical.Controls[gbArrivalIndex];
            cSwitchComplete = pGraphical.Controls[gbSwitchIndex];
            cQueueOther = pGraphical.Controls[gbOtherQueueIndex];
            cQueueCarStereo = pGraphical.Controls[gbCarStereoQueueIndex];
            cResourceOther = pGraphical.Controls[gbResourcesOtherIndex];
            cResourceCarStereo = pGraphical.Controls[gbResourcesCarStereoIndex];
            cTimeDisplay = pGraphical.Controls[lTimeDisplayIndex];
        }

        /// <summary>
        /// Keeps the simulation information current for Calender, Other and CarStereo Queue 
        /// </summary>
        public void Update(Calender calender, ResourceManager resourceMananger, Statistics statistics)
        {
            // Clear the lists
            Arrival.Clear();
            SwitchComplete.Clear();
            QueueOther.Clear();
            QueueCarStereo.Clear();
            ResourceOther.Clear();
            ResourceCarStereo.Clear();

            // Update the lists
            updateDisplayDataList(resourceMananger.GetQueueEntityData(ECallType.OTHER));
            updateDisplayDataList(resourceMananger.GetQueueEntityData(ECallType.CAR_STEREO));
            updateDisplayDataList(calender.GetEventData());

            
        }

        /// <summary>
        /// Keeps the display data lists up to date
        /// </summary>
        private void updateDisplayDataList(List<String[]> list) 
        {
            // Loop through all data from the list
            foreach (string[] data in list)
            {
                // Pull the data we need for display
                string entityID = data[Constants.EVENT_ENTITY_POS];
                string eventType = data[Constants.EVENT_TYPE_POS];
                string callType = data[Constants.EVENT_CALL_TYPE_POS];

                // Create a placeholder list
                List<string> listToBeProcessed = null;

                // Used If statements as to much computation for switch
                //
                // Change list to arrival
                if (eventType.Equals(EEventType.ARRIVAL.ToString()))
                    listToBeProcessed = Arrival;

                // Switch complete list
                if (eventType.Equals(EEventType.SWITCH_COMPLETE.ToString()))
                    listToBeProcessed = SwitchComplete;

                // If no event enitity is in queue && change list to other 
                if (eventType.Equals("---") && callType.Equals(ECallType.OTHER.ToString()))
                    listToBeProcessed = QueueOther;

                // If no event enitity is in queue && change list to car stereo 
                if (eventType.Equals("---") && callType.Equals(ECallType.CAR_STEREO.ToString()))
                    listToBeProcessed = QueueCarStereo;

                // Get the event and calltype
                if (eventType.Equals(EEventType.PROCESSING_COMPLETE.ToString()) && callType.Equals(ECallType.OTHER.ToString()))
                    listToBeProcessed = ResourceOther;

                // Get the event and calltype
                if (eventType.Equals(EEventType.PROCESSING_COMPLETE.ToString()) && callType.Equals(ECallType.CAR_STEREO.ToString()))
                    listToBeProcessed = ResourceCarStereo;

                // Add info to the list if the simulation is still running
                if(!eventType.Equals(EEventType.END_SIMULATION.ToString()))
                    listToBeProcessed.Add(entityID);
            }
        }

        /// <summary>
        /// Draw the controls on the panel
        /// </summary>
        public void Draw()
        {
            // Clear controls
            foreach (Control c in pGraphical.Controls)
                foreach (Label l in c.Controls.Find("lEntity", true))
                    c.Controls.Remove(l);

            // Add the controls to the gbControls
            cArrival.Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_ARRIVAL));
            cSwitchComplete.Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_SWITCH));
            cQueueOther.Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_QUEUE_TYPE_1));
            cQueueCarStereo.Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_QUEUE_TYPE_2));
            cResourceOther.Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_RESOURCE_TYPE_1));
            cResourceCarStereo.Controls.AddRange(gdFactory.MakeQueue(ELabelType.L_RESOURCE_TYPE_2));

            // Get global clock time
            TimeSpan st = TimeSpan.FromSeconds(Global.Clock);
            // Format the hours 
            int stHours = st.Hours + (Global.StartSimulationTime / Constants.DATE_TIME_FACTOR);
            // Update display
            cTimeDisplay.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", stHours, st.Minutes, st.Seconds);

            // Refresh controls
            foreach (Control c in pGraphical.Controls)
                c.Refresh();
        }
    }

    class GraphicalDisplayFactory
    {
        private GraphicalDisplay gDisplay;

        public GraphicalDisplayFactory(GraphicalDisplay gDisplay) 
        {
            this.gDisplay = gDisplay;
        }

        /// <summary>
        /// Returns a list of labels a queue type
        /// </summary>
        public Label[] MakeQueue(ELabelType labelType)
        {
            switch (labelType)
            {
                case ELabelType.L_ARRIVAL:
                    return makeEntityLabelList(gDisplay.Arrival, Color.LightGreen);
                case ELabelType.L_SWITCH:
                    return makeEntityLabelList(gDisplay.SwitchComplete, Color.LightGoldenrodYellow);
                case ELabelType.L_QUEUE_TYPE_1:
                    return makeEntityLabelList(gDisplay.QueueOther, Color.LightBlue);
                case ELabelType.L_QUEUE_TYPE_2:
                    return makeEntityLabelList(gDisplay.QueueCarStereo, Color.LightPink);
                case ELabelType.L_RESOURCE_TYPE_1:
                    return makeEntityLabelList(gDisplay.ResourceOther, Color.LightBlue);
                case ELabelType.L_RESOURCE_TYPE_2:
                    return makeEntityLabelList(gDisplay.ResourceCarStereo, Color.LightPink);
                default:
                    return new Label[0];
            }
        }

        /// <summary>
        /// Create the list of labels
        /// </summary>
        private Label[] makeEntityLabelList(List<string> list, Color color) 
        {
            Label[] labelList = null;

            labelList = new Label[list.Count];

            for (int col = 0; col < list.Count; col++)
            {
                string text = list[col];

                // Reverse the order so first is on the right
                int x = (Constants.LABEL_START_X - Constants.LABEL_SIZE) + ((list.Count - col) * Constants.LABEL_SIZE);
                int y = Constants.LABEL_START_Y;

                labelList[col] = makeEntityLabel(text, color, x, y);
            }

            // Return a list of labels 
            return labelList;
        }

        /// <summary>
        /// Return a new label 
        /// </summary>
        private Label makeEntityLabel(string text, Color color, int x, int y)
        {
            return new Label 
            { 
                BackColor = color,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Location = new Point(x, y),
                Name = "lEntity",
                Size = new System.Drawing.Size(Constants.LABEL_SIZE, Constants.LABEL_SIZE),
                Text = text,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
        }
    }
}
