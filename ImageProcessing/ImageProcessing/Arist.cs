using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Arist
    {
        double lenght;
        vertice v;
        public Arist(vertice b, double l)
        {
            v = b;
            lenght = l;
        }

        public double Lenght { get => lenght; set => lenght = value; }
    }
}
