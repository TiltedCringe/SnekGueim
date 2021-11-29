using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Snake2
{
    public enum DireccioSnek { Dreta,Esquerra, Avall, Amunt}
    class Snek
    {
        public const int X_SIZE = 5;
        public const int Y_SIZE = 5;

        Point capSerp = new Point(X_SIZE/2, Y_SIZE/2);
        DireccioSnek direccio = DireccioSnek.Avall;

        public Point CapSerp { get => capSerp; set => capSerp = value; }
        public DireccioSnek Direccio { get => direccio; set => direccio = value; }

        internal void Moure()
        {
            capSerp.Y++;
        }
    }
}
