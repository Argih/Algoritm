using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class Graphh
    {
        List<vertice> lv;
         public Graphh()
        {
            lv = new List<vertice>();
        }
        public double distancy (Circle origin, Circle destiny)
        {
            return Math.Sqrt(Math.Pow(destiny.getCenterX() - origin.getCenterX(), 2)+ Math.Pow(destiny.getCentery() - origin.getCentery(),2));
        }
        public Graphh(List<Circle> llc)
        {
            lv = new List<vertice>();
            int cont = 0;
            foreach(Circle c in llc)
            {
                cont++;
                vertice v = new vertice(c,cont);
                this.lv.Add(v);

            }
            foreach(vertice origen in this.lv)
            {
                foreach(vertice destino in this.lv)
                {
                    if (origen != destino)
                    {
                        double wheight = distancy(origen.getCircle(), destino.getCircle());
                        origen.insertAdy(destino, wheight);
                    }
                }
            }
        }





    }
}
