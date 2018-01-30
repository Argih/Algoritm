﻿using System;
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
        public ProcessingAlgo(Bitmap img, ref PictureBox p)
        {
            bmp = new Bitmap(img);
            picture = p;
            list = new List<Circle>();
        }    
        public Bitmap getBmp() {return bmp; }
        public void printList()
        {
            for (int i=0; i<list.Count;i++)
            {
                Console.WriteLine(list[i].getCenterX());
                Console.WriteLine(list[i].getCentery());
                Console.WriteLine(list[i].getRadius());
            }
        }
        public void drawCircle(Circle c)
        {
            Graphics G = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red);
            SolidBrush brush = new SolidBrush(Color.Red);
            float F = 4.4f;
            float d = c.getRadius();
            int a = c.getCenterX()- (int)(d*2.2);
            int b = c.getCentery()- (int)(d*2.2);
           
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