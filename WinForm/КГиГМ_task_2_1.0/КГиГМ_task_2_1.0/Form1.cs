using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace КГиГМ_task_2_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush Black = new SolidBrush(Color.Black);
            
            
            
            for (int i = 1, j = 1; i < this.Width - 20 || j < this.Height - 20; i++, j++)
            {

                g.FillRectangle(Black, i, j, 1, 1);

            }
           

        }

        static void Bresenham() 
        {

        }
    }
}
