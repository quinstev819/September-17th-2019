using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace September_17th__2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 16);

            g.DrawString("Greetings!", drawFont, drawBrush, 350, 150);
            g.DrawString("Click anywhere to continue.", drawFont, drawBrush, 270, 200);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush darkredBrush = new SolidBrush(Color.DarkRed);
            Font drawFont = new Font("Arial", 16);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush silverBrush = new SolidBrush(Color.Silver);
            SolidBrush darkblueBrush = new SolidBrush(Color.DarkBlue);

            g.Clear(Color.Gray);
            g.DrawString("Lest we forget", drawFont, blackBrush, 330, 20);
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
             g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
        }
    }
}
