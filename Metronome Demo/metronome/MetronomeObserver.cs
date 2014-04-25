using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TBeeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public TBeeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TCounter : MetronomeObserver
    {
        delegate void SetCallBack();
        private NumericUpDown spinBox;

        public TCounter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {   
            if (spinBox.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetCallBack d = new SetCallBack(IncrementSpinBox);
                metronome.mainForm.Invoke(d);
            }
            else
            {
                // It's on the same thread, no need for Invoke 
                spinBox.Value++;  
            }

                
        }
        private void IncrementSpinBox()
        {
            spinBox.Value++;
        }
    } // end TCounter

    
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TTimeDisplay : MetronomeObserver
    {
        delegate void SetCallBack(string timestamp);
        private ListBox listBox;

        public TTimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            DateTime currDateTime = e.currentTime;

            if (listBox.InvokeRequired)
            {
                // It's on a different thread, so use Invoke.
                SetCallBack d = new SetCallBack(AddTimeStamp);
                metronome.mainForm.Invoke(d, currDateTime.ToString());
            }
            else 
            {
                listBox.Items.Add(currDateTime.ToString());   
            }     
        }

        private void AddTimeStamp(string timestamp) 
        {
            listBox.Items.Add(timestamp);
        }
    }






            
}
