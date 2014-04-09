using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metronome
{
    class TimeDisplay
    {
        private Label time;

        public TimeDisplay(Metronome metronome, Label time) 
        {
            metronome.MetronomeEvent += new Metronome.MetronomeHandler(metronomeHandler);

            this.time = time;
        }

        private void metronomeHandler(object sender, MetronomeEventArgs me) 
        {
            time.Text = me.Time;
            time.Refresh();
        }
    }
}
