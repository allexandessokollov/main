using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КГиГм_task_1
{
    public partial class Form1 : Form
    {

        Graphics g;
        
            public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Height = 800;
            this.Width = 1300;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.LightBlue);
            String theSun = "The Sun";
            String mt = "Mountain";
            String Gr = "Ground";

            SolidBrush gray = new SolidBrush(Color.Gray);
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            SolidBrush forStr = new SolidBrush(Color.Black);
            Pen riv = new Pen(Color.Blue, 2);
            Brush ground = new SolidBrush(Color.FromArgb(139, 69, 19));

            Font font = new Font("Arial", 16);


            g.FillEllipse(yellow, 10, 10, 200, 200);
            g.DrawString(theSun, font, forStr, 60, 90);
            Point[] MountPoints1 =
            {
                new Point (600, 100),
                new Point (1050, 600),
                new Point (150, 600)
            };
            Point[] MountPoints2 =
            {
                new Point (750, 120),
                new Point (1200, 600),
                new Point (300, 600)
            };
            Point[] rivPoints =
            {
            new Point(0, 700),
            new Point(50, 675),
            new Point(150, 675),
            new Point(200, 700),
            new Point(250, 675),
            new Point(300, 700),
            new Point(450, 675),
            new Point(500, 700),
            new Point(750, 675),
            new Point(800, 700),
            new Point(850, 675),
            new Point(900, 700),
            new Point(950, 675),
            new Point(1050, 675),
            new Point(1100, 700),
            new Point(1150, 675),
            new Point(1300, 700),
            };

            g.FillPolygon(gray, MountPoints1);
            g.FillPolygon(gray, MountPoints2);

            g.FillRectangle(ground,0,600,this.Width, 200);
            g.DrawCurve(riv, rivPoints);

            g.DrawString(mt, font, forStr, 630, 400);
            g.DrawString(Gr, font, forStr, 630, 650);




        }
    }

       
    }
