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
                Pen pen1 = new Pen(Color.Black, 3);
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
            }
            else
            {
                MessageBox.Show("Ningúna imagen detectada");
            }
        }
    }
}
