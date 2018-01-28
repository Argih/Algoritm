using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class ProcessingAlgo
    {
        private Bitmap bmp;
        public ProcessingAlgo() { }
        public ProcessingAlgo(Bitmap img) => bmp = new Bitmap(img);
        public Point findCenter()
        {
            int x_i, x_c, x_f;
            int y_i, y_c, y_f;
            for(int j = 0; j < bmp.Height; j++)
            {
                for(int i = 0; i < bmp.Width; i++)
                {   
                    //circulo encontrado
                    if(bmp.GetPixel(i,j).R==0 && bmp.GetPixel(i, j).B == 0 && bmp.GetPixel(i, j).G == 0)
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
                        for (y_f = x_i; y_f < bmp.Height; y_f++)
                        {
                            if (bmp.GetPixel(y_f, x_i).R != 0 && bmp.GetPixel(y_f, x_i).B != 0 && bmp.GetPixel(y_f, x_i).G != 0)
                            {
                                y_f--;
                                break;
                            }
                        }
                        x_c = (x_i + x_f) / 2;
                        y_c = (y_i + y_f) / 2;
                        return new Point(x_c, y_c);
                    }
                }
            }
            return new Point(-1, -1);
        }

    }
}
