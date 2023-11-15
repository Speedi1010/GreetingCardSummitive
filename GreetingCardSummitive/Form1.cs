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
using System.Media;
using System.IO;
namespace GreetingCardSummitive
{
    public partial class Form1 : Form
    {
        Pen yellowpen = new Pen(Color.Yellow, 5);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        Font drawfont = new Font("Ariel", 24, FontStyle.Bold);
        Graphics g;
        System.Windows.Media.MediaPlayer waka = new System.Windows.Media.MediaPlayer();
        int line = 10;
        int linecalibrate;
        int column = 0;
        private Random rnd = new Random();
        int size = 60;
        public Form1()
        {
            
            InitializeComponent();
            waka.Open(new Uri(Application.StartupPath + "/Resources/waka.wav"));
            g = this.CreateGraphics();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            g.DrawString("Welcome\n  friends", drawfont, whiteBrush, 215, 98);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            g.FillPie(yellowBrush, column, 10, 80, 80, 30, 300);
            g.FillRectangle(blueBrush, 0, 105, 490, 10);
            g.FillRectangle(blueBrush, 130, 225, 490, 10);
            g.FillRectangle(blueBrush, 0, 345, 490, 10);
            g.FillEllipse(whiteBrush, 540, 105, 10, 10);
            g.FillEllipse(whiteBrush, 60, 225, 10, 10);
            g.FillEllipse(whiteBrush, 540, 345, 10, 10);
            g.FillEllipse(whiteBrush, 50, 395, 30, 30);

            for (int i = 100; i < 580; i += 40)
            {
                g.FillEllipse(whiteBrush, i, 45, 10, 10);
            }

            for (int i = 540; i > 20; i -= 40)
            {
                g.FillEllipse(whiteBrush, i, 165, 10, 10);
                g.FillEllipse(whiteBrush, i, 285, 10, 10);
                g.FillEllipse(whiteBrush, i, 405, 10, 10);
            }

            for (int i = 0; i < 2; i++)
            {
              Foreward();
               Down();
              Backward();
            
               if (i == 0)
               {
                    Down();
                }
            }
            g.Clear(Color.Black);
            for (int i = 0; i < 7000; i += 10)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                SolidBrush randombrush = new SolidBrush(randomColor);
                size += 1;
                g.FillPie(randombrush, 293 - size / 2, 212 - size / 2, size, size, i, 11);
                Thread.Sleep(20);
                if (i % 250 == 0)
                {
                    waka.Stop();
                }
                waka.Play();
            }
            waka.Stop();
            line = 10;
            column = 0;
            
        }
        public void Foreward()
        {
            for (column = 0; column < 500; column += 20)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                SolidBrush randombrush = new SolidBrush(randomColor);
                g.FillPie(randombrush, column, line, 80, 80, 30, 300);
                Thread.Sleep(100);
                g.FillPie(blackBrush, column, line, 80, 80, 30, 300);
                g.FillPie(randombrush, column, line, 80, 80, 30, 360);
                waka.Stop();
                waka.Play();
                Thread.Sleep(100);
                g.FillPie(blackBrush, column, line, 80, 80, 30, 360);
            }
        }
        public void Down()
        {
            for (linecalibrate = line; line-110 < linecalibrate; line += 20)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                SolidBrush randombrush = new SolidBrush(randomColor);
                g.FillPie(randombrush, column, line, 80, 80, 120, 300);
                Thread.Sleep(100);
                g.FillPie(blackBrush, column, line, 80, 80, 120, 300);
                g.FillPie(randombrush, column, line, 80, 80, 120, 360);
                waka.Stop();
                waka.Play();
                Thread.Sleep(100);
                g.FillPie(blackBrush, column, line, 80, 80, 120, 360);
            }
        }
        public void Backward()
        {
            for (column = 500; column > 20; column -= 20)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                SolidBrush randombrush = new SolidBrush(randomColor);
                g.FillPie(randombrush, column, line, 80, 80, 210, 300);
                Thread.Sleep(100);
                g.FillPie(blackBrush, column, line, 80, 80, 210, 300);
                g.FillPie(randombrush, column, line, 80, 80, 210, 360);
                waka.Stop();
                waka.Play();
                Thread.Sleep(100);
                g.FillPie(blackBrush, column, line, 80, 80, 210, 360);
            }
        }
        public void Up()
        {
            for (linecalibrate = line; line - 110 > linecalibrate; line -= 20)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                SolidBrush randombrush = new SolidBrush(randomColor);
                g.FillPie(randombrush, column, line, 80, 80, 120, 300);
                Thread.Sleep(100);
                g.FillPie(blackBrush, column, line, 80, 80, 120, 300);
                g.FillPie(randombrush, column, line, 80, 80, 120, 360);
                waka.Stop();
                waka.Play();
                Thread.Sleep(100);
                g.FillPie(blackBrush, column, line, 80, 80, 120, 360);
            }
        }
    }
}
