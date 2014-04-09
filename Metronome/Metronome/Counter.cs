using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metronome
{
    class Counter
    {
        private NumericUpDown nUpDown;

        public Counter(Metronome metronome, NumericUpDown nUpDown) 
        {
            metronome.MetronomeEvent += new Metronome.MetronomeHandler(metronomeHandler);

            this.nUpDown = nUpDown;
        }

        private void metronomeHandler(object sender, MetronomeEventArgs me) 
        {
            nUpDown.Value = me.Count;
            nUpDown.Refresh();
        }
    }
}
