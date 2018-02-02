//image processing
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    class ProcessingAlgo
    {
        private Bitmap bmp;
        List<Circle> list;
        private PictureBox picture;
        public ProcessingAlgo()
        {
            list = new List<Circle>();
        }
        public ProcessingAlgo(ref PictureBox p)
        {
            bmp = new Bitmap(p.Image);
            picture = p;
            list = new List<Circle>();
        }    
        public void printList()
        {
            for (int i=0; i<list.Count;i++)
            {
                String myString = String.Format("{0}{1},{2},{3}{4}", "{", list[i].getCenterX(), list[i].getCentery(),list[i].getRadius(),"}");
                Console.WriteLine(myString);
  
            }
        }
        private void drawCircle(Circle c)
        {
            Graphics G = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red);
            SolidBrush brush = new SolidBrush(Color.Red);
            float F = 2f;
            float d = c.getRadius()+2;
            int a = c.getCenterX()- (int)(d);
            int b = c.getCentery()- (int)(d);
           
            G.DrawEllipse(pen, a, b, d*F, d*F);
            G.FillEllipse(brush, a, b, d*F, d*F);
            picture.Image= bmp;
        }
        public void findCenter()
        {
            int x_i, x_c, x_f;
            int y_i, y_c, y_f;

            for (int j = 0; j < bmp.Height; j++)
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    //circulo encontrado
                    if (bmp.GetPixel(i, j).R == 0 && bmp.GetPixel(i, j).B == 0 && bmp.GetPixel(i, j).G == 0)
                    {
                        x_i = i;
                        y_i = j;
                        for (x_f = x_i; x_f < bmp.Width; x_f++)
                        {
                            if (bmp.GetPixel(x_f, y_i).R != 0 && bmp.GetPixel(x_f, y_i).B != 0 && bmp.GetPixel(x_f, y_i).G != 0)
                            {
                                x_f--;
                                break;
                            }
                        }
                        for (y_f = y_i; y_f < bmp.Height; y_f++)
                        {
                            if (bmp.GetPixel(x_i, y_f).R != 0 && bmp.GetPixel(x_i,y_f).B != 0 && bmp.GetPixel(x_i, y_f).G != 0)
                            {
                                y_f--;
                                break;
                            }
                        }
                        x_c = (x_i + x_f) / 2;
                        y_c = (y_i + y_f) / 2;
                        

                        Circle circle = new Circle(x_c, y_c, x_i, j);
                        list.Add(circle);
                        drawCircle(circle);
                        bmp.SetPixel(x_c, y_c, Color.White);
                    }
                }
            }
            
        }

    }
}