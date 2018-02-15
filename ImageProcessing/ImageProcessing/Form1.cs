//formulario inicial
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Graphh graph;

        bool isOpen;
        public Form1()
        {
            InitializeComponent();
            isOpen = false;
        }


        private void load_Click(object sender, EventArgs e)
        {
            path.Enabled = false;
            graphButton.Enabled = false;
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                isOpen = true;
                
            }
            if (isOpen)
            {
                pictureB.Image = new Bitmap(openFile.FileName);
            }
        }

        private void detect_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {
                Bitmap img = new Bitmap(openFile.FileName);
                ProcessingAlgo IP = new ProcessingAlgo(ref pictureB);
                IP.findCenter();
                IP.printList();
                graph = new Graphh(IP.GetList());
                graphButton.Enabled = true;
                path.Enabled = true;
            }
            else
            {
                MessageBox.Show("No has seleccionado ninguna imagen");
            }
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            if (graph != null)
            {
                Bitmap imgGraph = new Bitmap(pictureB.Image);
                Graphics graphic = Graphics.FromImage(imgGraph);
                Pen pen1 = new Pen(Color.Black, 2);
                foreach (vertice v in graph.getLV())
                {
                    foreach (Arist a in v.getLA())
                    {
                        Point pi = v.getPoint();
                        Point pf = a.V.getPoint();
                        graphic.DrawLine(pen1, pi, pf);
                    }
                }
                pictureB.Image = imgGraph;
              /*  foreach(vertice v in graph.getLV())
                {
                    String t = "";
                    foreach (Arist a in v.getLA())
                    {
                        String myStrin = String.Format("{0}-", a.V.getName());
                        t= t + myStrin;
                    }
                    String final = "";
                    final = final + t;
                }*/
            }
            else
            {
                MessageBox.Show("Ningúna imagen detectada");
            }
        }

        private void path_Click(object sender, EventArgs e)
        {
            double min=9999, posible;
            List<vertice> t;


          
            List<vertice> calcul()
            {
                List<vertice> j = new List<vertice>();

                foreach (vertice v in graph.getLV())
                {
                    foreach (Arist v2 in v.getLA())
                    {
                        foreach (Arist v3 in v2.V.getLA())
                        {
                            foreach (Arist v4 in v3.V.getLA())
                            {
                                bool ty = v.getName() != v2.V.getName() && v.getName() != v3.V.getName() && v.getName() != v4.V.getName() && v2.V.getName() != v3.V.getName() && v2.V.getName() != v4.V.getName() && v3.V.getName() != v4.V.getName();
                                if (ty)
                                {
                                    posible = v2.Lenght + v3.Lenght + v4.Lenght;
                                    if (min > posible)
                                    {
                                        min = posible;
                                        j = new List<vertice>();
                                        j.Add(new vertice(v));
                                        j.Add(new vertice(v2.V));
                                        j.Add(new vertice(v3.V));
                                        j.Add(new vertice(v4.V));
                                    }
                                }
                            }
                        }
                    }
                }
                return j;
            }
            t = calcul();
            Bitmap imgGraph = new Bitmap(pictureB.Image);
            Graphics graphic = Graphics.FromImage(imgGraph);
            SolidBrush b = new SolidBrush(Color.FromArgb(100, Color.Orange));
            Pen pen1 = new Pen(b,3);
            int m = t.Count;
            for (int i = 1; i <m;i++)
            {
                Point pi = t[i-1].getPoint();
                Point pf = t[i].getPoint();
                graphic.DrawLine(pen1, pi, pf);
            }
            pictureB.Image = imgGraph;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
