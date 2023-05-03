using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Lab_interface_3
{
    public class Ipod : RadioPlayerInterface, MusicPlayerInterface
    {
        private musicFiles[] musicFiles;
        private bool ison;
        private bool isPlaying;
        private double currentFrequcy;
        private int currentVolume;
        private int currentMusicIndex;

        public Ipod()
        {
            this.musicFiles = new musicFiles[500];
            this.ison = false;
            this.isPlaying = false;
            this.currentFrequcy = 0.0;
            this.currentVolume = 0;
            this.currentMusicIndex = 0;


        }
        public void Switch(bool on)
        {
            this.ison = on;
        }
        public void Return(double frequency)
        {
            this.currentFrequcy += frequency;
        }
        public void SetVolume(int loudness)
        {
            this.currentVolume = loudness;
        }
        public void ChangeChannel()
        {

        }
        public void play(bool on) {
            this.isPlaying = on;
        }
        public void playnext()
        {
            this.currentMusicIndex = (this.currentMusicIndex + 1) % this.musicFiles.Length;

        }
        public void playPrevious()
        {
            this.currentMusicIndex=(this.currentMusicIndex - 1+ this.musicFiles.Length) % this.musicFiles.Length;
        }
        public void AddMusicFiles(musicFiles musicFiles)
        {

        }

       public void setVolume(int volume)
        {
          
        }
    }
}
