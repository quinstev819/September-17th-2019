using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

/// <summary>
/// Quinlan Stevenson
/// September 24th, 2019
/// Calendar and Remembrance Day poppy with moving clouds and information.
/// </summary>

namespace September_17th__2019
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Gray);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Cambria", 16);
            Font dayFont = new Font("Arial", 10);
            Font dateFont = new Font("Arial", 32);
            SolidBrush dateBrush = new SolidBrush(Color.Red);
            SoundPlayer player = new SoundPlayer(Properties.Resources.notification);

            //calendar
            g.Clear(Color.White);
            player.Play();
            g.DrawString("S", dayFont, drawBrush, 100, 0);
            g.DrawString("M", dayFont, drawBrush, 200, 0);
            g.DrawString("T", dayFont, drawBrush, 300, 0);
            g.DrawString("W", dayFont, drawBrush, 400, 0);
            g.DrawString("T", dayFont, drawBrush, 500, 0);
            g.DrawString("F", dayFont, drawBrush, 600, 0);
            g.DrawString("S", dayFont, drawBrush, 700, 0);
            g.DrawRectangle(drawPen, 0, 25, 800, 1);
            g.DrawString("November", drawFont, drawBrush, 555, 30);
            g.DrawRectangle(drawPen, 560, 55, 240, 1);
            g.DrawString("1", dateFont, drawBrush, 585, 60);
            g.DrawString("2", dateFont, drawBrush, 685, 60);
            g.DrawRectangle(drawPen, 0, 105, 800, 1);
            g.DrawString("3", dateFont, drawBrush, 85, 105);
            g.DrawString("4", dateFont, drawBrush, 190, 105);
            g.DrawString("5", dateFont, drawBrush, 290, 105);
            g.DrawString("6", dateFont, drawBrush, 390, 105);
            g.DrawString("7", dateFont, drawBrush, 490, 105);
            g.DrawString("8", dateFont, drawBrush, 585, 105);
            g.DrawString("9", dateFont, drawBrush, 685, 105);
            g.DrawRectangle(drawPen, 0, 150, 800, 1);
            g.DrawString("10", dateFont, drawBrush, 70, 150);
            g.DrawString("11", dateFont, dateBrush, 175, 150);
            g.DrawString("12", dateFont, drawBrush, 275, 150);
            g.DrawString("13", dateFont, drawBrush, 375, 150);
            g.DrawString("14", dateFont, drawBrush, 475, 150);
            g.DrawString("15", dateFont, drawBrush, 570, 150);
            g.DrawString("16", dateFont, drawBrush, 670, 150);
            g.DrawRectangle(drawPen, 0, 195, 800, 1);
            g.DrawString("17", dateFont, drawBrush, 70, 195);
            g.DrawString("18", dateFont, drawBrush, 175, 195);
            g.DrawString("19", dateFont, drawBrush, 275, 195);
            g.DrawString("20", dateFont, drawBrush, 380, 195);
            g.DrawString("21", dateFont, drawBrush, 480, 195);
            g.DrawString("22", dateFont, drawBrush, 575, 195);
            g.DrawString("23", dateFont, drawBrush, 675, 195);
            g.DrawRectangle(drawPen, 0, 240, 800, 1);
            g.DrawString("24", dateFont, drawBrush, 70, 240);
            g.DrawString("25", dateFont, drawBrush, 180, 240);
            g.DrawString("26", dateFont, drawBrush, 280, 240);
            g.DrawString("27", dateFont, drawBrush, 380, 240);
            g.DrawString("28", dateFont, drawBrush, 480, 240);
            g.DrawString("29", dateFont, drawBrush, 575, 240);
            g.DrawString("30", dateFont, drawBrush, 675, 240);
            g.DrawRectangle(drawPen, 0, 285, 800, 1);
            g.DrawString("Click anywhere to continue", drawFont, drawBrush, 255, 310);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush darkredBrush = new SolidBrush(Color.DarkRed);
            Font drawFont = new Font("Arial", 16);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.FromArgb(123, 255, 255, 255));
            SolidBrush purewhiteBrush = new SolidBrush(Color.White);
            SolidBrush silverBrush = new SolidBrush(Color.Silver);
            SolidBrush darkblueBrush = new SolidBrush(Color.DarkBlue);
            SolidBrush lightBlueBrush = new SolidBrush(Color.LightBlue);
            SoundPlayer lastpostplayer = new SoundPlayer(Properties.Resources.last_post);

            //frame 1
            //background and clouds
            g.Clear(Color.Gray);
            lastpostplayer.Play();
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, 10, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 330, 20);
            g.FillEllipse(whiteBrush, 810, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 1020, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 2
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, 0, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 320, 20);
            g.FillEllipse(whiteBrush, 800, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 1010, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 3
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -10, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 300, 20);
            g.FillEllipse(whiteBrush, 790, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 1000, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 4
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -20, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 290, 20);
            g.FillEllipse(whiteBrush, 780, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 990, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 5
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -30, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 280, 20);
            g.FillEllipse(whiteBrush, 770, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 980, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 6
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -40, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 270, 20);
            g.FillEllipse(whiteBrush, 760, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 970, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 7
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -50, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 260, 20);
            g.FillEllipse(whiteBrush, 750, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 960, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 8
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -60, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 250, 20);
            g.FillEllipse(whiteBrush, 740, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 950, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 9
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -70, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 240, 20);
            g.FillEllipse(whiteBrush, 730, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 940, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 10
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -80, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 230, 20);
            g.FillEllipse(whiteBrush, 720, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 930, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 11
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -90, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 220, 20);
            g.FillEllipse(whiteBrush, 710, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 920, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 12
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -100, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 210, 20);
            g.FillEllipse(whiteBrush, 700, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 910, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 13
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -110, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 200, 20);
            g.FillEllipse(whiteBrush, 690, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 900, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 14
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -120, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 190, 20);
            g.FillEllipse(whiteBrush, 680, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 890, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 15
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -130, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 180, 20);
            g.FillEllipse(whiteBrush, 670, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 880, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 16
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -140, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 170, 20);
            g.FillEllipse(whiteBrush, 660, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 870, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 17
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -150, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 160, 20);
            g.FillEllipse(whiteBrush, 650, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 860, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 18
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -160, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 150, 20);
            g.FillEllipse(whiteBrush, 640, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 850, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 19
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -170, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 140, 20);
            g.FillEllipse(whiteBrush, 630, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 840, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 20
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -180, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 130, 20);
            g.FillEllipse(whiteBrush, 620, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 830, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 21
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -190, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 120, 20);
            g.FillEllipse(whiteBrush, 610, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 820, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 22
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -200, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 110, 20);
            g.FillEllipse(whiteBrush, 600, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 810, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 23
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -210, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 100, 20);
            g.FillEllipse(whiteBrush, 590, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 800, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 24
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -220, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 90, 20);
            g.FillEllipse(whiteBrush, 580, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 790, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 25
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -230, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 80, 20);
            g.FillEllipse(whiteBrush, 570, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 780, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 26
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -240, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 70, 20);
            g.FillEllipse(whiteBrush, 560, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 770, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 27
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -250, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 60, 20);
            g.FillEllipse(whiteBrush, 550, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 760, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 28
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -260, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 50, 20);
            g.FillEllipse(whiteBrush, 540, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 750, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 29
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -270, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 40, 20);
            g.FillEllipse(whiteBrush, 530, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 740, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 30
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -280, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 30, 20);
            g.FillEllipse(whiteBrush, 520, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 730, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 31
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -290, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 20, 20);
            g.FillEllipse(whiteBrush, 510, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 720, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 32
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -300, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 10, 20);
            g.FillEllipse(whiteBrush, 500, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 710, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 33
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -310, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, 0, 20);
            g.FillEllipse(whiteBrush, 490, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 700, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 34
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -320, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -10, 20);
            g.FillEllipse(whiteBrush, 480, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 690, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 35
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -330, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -20, 20);
            g.FillEllipse(whiteBrush, 470, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 680, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 36
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -340, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -30, 20);
            g.FillEllipse(whiteBrush, 460, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 670, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 37
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -350, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -40, 20);
            g.FillEllipse(whiteBrush, 450, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 660, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 38
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -360, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -50, 20);
            g.FillEllipse(whiteBrush, 440, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 650, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 39
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -370, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -60, 20);
            g.FillEllipse(whiteBrush, 430, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 640, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 40
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -380, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -70, 20);
            g.FillEllipse(whiteBrush, 420, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 630, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 41
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -390, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -80, 20);
            g.FillEllipse(whiteBrush, 410, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 620, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 42
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -400, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -90, 20);
            g.FillEllipse(whiteBrush, 400, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 610, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 43
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -410, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -100, 20);
            g.FillEllipse(whiteBrush, 390, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 600, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 44
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -420, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -110, 20);
            g.FillEllipse(whiteBrush, 380, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 590, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 45
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -430, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -120, 20);
            g.FillEllipse(whiteBrush, 370, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 580, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 46
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -440, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -130, 20);
            g.FillEllipse(whiteBrush, 360, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 570, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 47
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -450, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -140, 20);
            g.FillEllipse(whiteBrush, 350, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 560, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 48
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -460, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -150, 20);
            g.FillEllipse(whiteBrush, 340, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 550, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 49
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -470, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -160, 20);
            g.FillEllipse(whiteBrush, 330, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 540, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 50
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -480, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -170, 20);
            g.FillEllipse(whiteBrush, 320, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 530, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 51
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -490, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -180, 20);
            g.FillEllipse(whiteBrush, 310, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 520, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 52
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -500, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -190, 20);
            g.FillEllipse(whiteBrush, 300, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 510, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 53
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -510, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -200, 20);
            g.FillEllipse(whiteBrush, 290, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 500, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 54
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -520, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -210, 20);
            g.FillEllipse(whiteBrush, 280, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 490, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 55
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -530, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -220, 20);
            g.FillEllipse(whiteBrush, 270, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 480, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 56
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -540, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -230, 20);
            g.FillEllipse(whiteBrush, 260, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 470, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 57
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -550, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -240, 20);
            g.FillEllipse(whiteBrush, 250, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 460, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 58
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -560, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -250, 20);
            g.FillEllipse(whiteBrush, 240, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 450, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 59
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -570, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -260, 20);
            g.FillEllipse(whiteBrush, 230, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 440, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 60
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -580, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -270, 20);
            g.FillEllipse(whiteBrush, 220, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 430, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 61
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -590, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -280, 20);
            g.FillEllipse(whiteBrush, 210, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 420, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 62
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -600, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -290, 20);
            g.FillEllipse(whiteBrush, 200, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 410, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 63
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -610, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -300, 20);
            g.FillEllipse(whiteBrush, 190, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 400, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 64
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -620, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -310, 20);
            g.FillEllipse(whiteBrush, 180, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 390, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 65
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -630, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -320, 20);
            g.FillEllipse(whiteBrush, 170, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 380, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 66
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -640, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -330, 20);
            g.FillEllipse(whiteBrush, 160, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 370, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 67
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -650, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -340, 20);
            g.FillEllipse(whiteBrush, 150, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 360, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 68
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -660, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -350, 20);
            g.FillEllipse(whiteBrush, 140, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 350, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 69
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -670, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -360, 20);
            g.FillEllipse(whiteBrush, 130, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 340, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 70
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -680, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -370, 20);
            g.FillEllipse(whiteBrush, 120, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 330, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 71
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -690, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -380, 20);
            g.FillEllipse(whiteBrush, 110, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 320, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 72
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -700, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -390, 20);
            g.FillEllipse(whiteBrush, 100, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 310, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 73
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -710, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -400, 20);
            g.FillEllipse(whiteBrush, 90, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 300, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 74
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -720, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -410, 20);
            g.FillEllipse(whiteBrush, 80, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 290, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 75
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -730, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -420, 20);
            g.FillEllipse(whiteBrush, 70, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 280, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 76
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -740, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -430, 20);
            g.FillEllipse(whiteBrush, 60, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 270, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 77
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -750, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -440, 20);
            g.FillEllipse(whiteBrush, 50, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 260, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 78
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -760, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -450, 20);
            g.FillEllipse(whiteBrush, 40, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 250, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 79
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -770, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -460, 20);
            g.FillEllipse(whiteBrush, 30, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 240, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 80
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -780, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -470, 20);
            g.FillEllipse(whiteBrush, 20, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 230, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);

            //frame 81
            //background and clouds
            g.Clear(Color.Gray);
            g.FillRectangle(lightBlueBrush, 0, 0, 800, 200);
            g.FillEllipse(whiteBrush, -790, 10, 760, 40);
            g.DrawString("Lest we forget", drawFont, blackBrush, -480, 20);
            g.FillEllipse(whiteBrush, 10, 10, 760, 40);
            g.DrawString("July 28, 1914 - September 2, 1945", drawFont, blackBrush, 220, 20);

            //poppy
            g.FillRectangle(darkredBrush, 350, 150, 100, 100);
            g.FillEllipse(darkredBrush, 325, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 125, 100, 50);
            g.FillEllipse(darkredBrush, 425, 150, 50, 100);
            g.FillEllipse(darkredBrush, 350, 225, 100, 50);
            g.FillPie(blackBrush, 375, 175, 50, 50, 0, 360);
            g.FillPie(silverBrush, 398, 198, 4, 4, 0, 360);
            Thread.Sleep(975);
        }
    }
}