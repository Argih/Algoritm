using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
   public class vertice
    {
        Circle circle;
        int name;
        List<Arist> la;

        public vertice(Circle c, int n)
        {
            la = new List<Arist>();
            circle = c;
            name = n;
        }
        public Circle getCircle()
        {
            return circle;
        }

        public void insertAdy(vertice v, double p)
        {
            Arist ady = new Arist(v, p);
            la.Add(ady);
        }
    }
}
