using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ks2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kdEksen_Click(object sender, EventArgs e)
        {
            Point origin = new Point(400, 250);
            DrawAxes(origin);
        }
        public void DrawAxes(Point origin)
        {
            Point pt1 = new Point(origin.X - 800, origin.Y);
            Point pt2 = new Point(origin.X + 800, origin.Y);
            Point pt3 = new Point(origin.X, origin.Y - 500);
            Point pt4 = new Point(origin.X, origin.Y + 500);
            Graphics gg = CreateGraphics();
            Pen p = new Pen(Color.FromArgb(0, 100, 0), 3); //x ve y eksenleri rengi ve kalınlığı
            gg.DrawLine(p, pt1, pt2);
            gg.DrawLine(p, pt3, pt4);


        }

        private void kontrolNok_Click(object sender, EventArgs e)
        {
            Pen draw = new Pen(System.Drawing.Color.Red, 4);
            System.Drawing.Graphics elips;
            elips = this.CreateGraphics();
            //Noktalar
            //Noktalarda 1 birimi 80 olarak referans aldım.X değerlerine noktaların  orantısal değerlerini yazdım,y değerlerinde ise aradaki farkı çıkarttım.

            Pen draw1 = new Pen(System.Drawing.Color.Red, 3);
            elips.DrawEllipse(draw, 395, 245, 10, 10);
            Pen draw2 = new Pen(System.Drawing.Color.Red, 3);
            elips.DrawEllipse(draw, 475, 55, 10, 10);
            Pen draw3 = new Pen(System.Drawing.Color.Red, 3);
            elips.DrawEllipse(draw, 675, 185, 10, 10);
            Pen draw4 = new Pen(System.Drawing.Color.Red, 3);
            elips.DrawEllipse(draw, 635, 245, 10, 10);

            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
        }

        private void bezierEgri_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics Graphics;
            Graphics = this.CreateGraphics();
            // Başlangıç
            PointF point1 = new PointF(395, 245);

            // Kontrol noktası
            PointF control1 = new PointF(475, 55);

            // Kontrol noktası
            PointF control2 = new PointF(675, 185);

            // Bitiş
            PointF point2 = new PointF(635, 245);

            Pen pen = new Pen(Color.FromArgb(0, 100, 0), 3); //Bezier Eğrisi rengi ve kalınlığı
            Graphics.DrawBezier(pen, point1, control1, control2, point2);
        }
    }
}