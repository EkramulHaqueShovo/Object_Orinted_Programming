using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Lab_interface_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ipod ipod= new Ipod();
            ipod.Switch(true);
            ipod.Return(97.3);
            ipod.setVolume(50);
            ipod.play(true);
            ipod.playnext();
            Console.ReadLine();

        }
    }
}
