using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Lab_interface_3
{
    public class musicFiles
    {
        private string title;
        private string artist;
        private int yearofRelease;
        private int durationinseconds;

        public musicFiles(string title, string artist, int yearofRelease, int durationinseconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearofRelease = yearofRelease;
            this.durationinseconds = durationinseconds;
        } 
        public void ChangeTitle(string title)
        {
            this.title = title;
        }
    }
}
