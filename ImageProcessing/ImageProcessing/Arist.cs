using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class Arist
    {
        double lenght;
        vertice v;
        public Arist(vertice b, double l)
        {
            v = b;
            lenght = l;
        }
        public Arist(Arist a)
        {
            lenght = a.lenght;
            v = a.v;
        }

        public vertice V { get => v; }
        public double Lenght { get => lenght; set => lenght = value; }
    }
}
