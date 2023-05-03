using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Lab_interface_3
{
    public interface RadioPlayerInterface
    {
        void Switch(bool on);
        void Return(double frequency);
        void SetVolume(int loudness);

        void ChangeChannel();
    }
}
