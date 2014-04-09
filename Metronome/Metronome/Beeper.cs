using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metronome
{
    class Beeper
    {
        private System.Media.SoundPlayer mySoundPlayer;

        public Beeper(Metronome metronome, string filename) 
        {
            metronome.MetronomeEvent += new Metronome.MetronomeHandler(metronomeHandler);
                        
  	        mySoundPlayer = new System.Media.SoundPlayer();
            mySoundPlayer.SoundLocation = filename;            
        }

        private void metronomeHandler(object sender, MetronomeEventArgs me) 
        {
            mySoundPlayer.Play();
        }
    }
}
