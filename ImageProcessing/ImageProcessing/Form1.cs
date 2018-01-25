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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            pictureB.Image = new Bitmap(openFile.FileName);
        }

        private void detect_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(openFile.FileName);
            ProcessingAlgo IP = new ProcessingAlgo(img);
            Point p_c = IP.findCircleCenter();
            Console.WriteLine(p_c.ToString());
        }
    }
}
