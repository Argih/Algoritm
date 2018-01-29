using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Circle
    {
        private int cX, cY;
        private float radius;

        private void calculateRadius(int x, int y)
        {
            double n = Math.Pow((x - cX), 2);
            double t = Math.Pow((y - cY), 2);
            radius =((float) Math.Sqrt(t))/2;
        }
        public Circle() { }
        public Circle(int x, int y, int a, int b)
        {
                cX = x;
                cY = y;
                calculateRadius(a,b);
        }

        public Circle(int x, int y, int r)
        {
            cX = x;
            cY = y;
            radius = r;
        }



        public void setCenter(int x, int y)
        {
            cX = x;
            cY = y;
        }
        
	    public int getCenterX() { return cX; }
        public int getCentery() { return cY; }
        public float getRadius() { return radius; }
        public float getDiameter() { return (radius * 2); }
    }
}
