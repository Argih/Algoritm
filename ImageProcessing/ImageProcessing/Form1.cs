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
                ProcessingAlgo IP = new ProcessingAlgo(img);
                /*  Point p_c = IP.findCenter();
                  Console.WriteLine(p_c.ToString());  */
                Circle c=IP.findCenter();
                pictureB.Image= IP.drawCircle(c);
            }
            else
            {
                
            }
        }

    }
}
