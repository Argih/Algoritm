using System;
using System.Collections.Generic;
using System.Drawing;
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
        public vertice(vertice a)
        {
            circle = a.circle;
            name = a.name;
            la = a.la;
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

        public List<Arist> getLA()
        {
            return la;
        }

        public Point getPoint()
        {
            return new Point(circle.getCenterX(), circle.getCentery());
        }
        public int getName()
        {
            return name;
        }
    }
}
