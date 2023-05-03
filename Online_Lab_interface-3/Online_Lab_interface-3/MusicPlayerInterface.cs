using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Lab_interface_3
{
    public interface MusicPlayerInterface
    {
        void Switch(bool on);
        void play(bool on);
        void setVolume(int loudness);

        void playnext();
        void playPrevious();
    }
}
