using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGraphics
{
    public partial class MainForm : Form
    {
        private int _angle = 0;
        private Timer _timer = new Timer();


        public MainForm()
        {
            InitializeComponent();
            _timer.Interval = 50;
            _timer.Tick += Timer_Tick;
            _timer.Start();

            DoubleBuffered = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.LightBlue);

            g.DrawRectangle(pen, 50, 150, 200, 150); // House body
            g.DrawRectangle(pen, 100, 200, 50, 100); // Door
            g.DrawRectangle(pen, 160, 180, 40, 40);  // Window
            g.FillRectangle(brush, 160, 180, 40, 40); // Fill window
            g.DrawPolygon(pen, new Point[] { new Point(50, 150), new Point(150, 100), new Point(250, 150) }); // Roof
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load image from file
            string imageFile = Path.GetFullPath("image.jpg");
            Bitmap bmp = new Bitmap(imageFile);

            //Display to PictureBox 1
            pictureBox1.Image = bmp.Clone() as Bitmap;

            //Add Water mark
            Graphics g = Graphics.FromImage(bmp);
            g.DrawString("Watermark", new Font("Arial", 20), Brushes.White, new PointF(10, 10));

            //Display to PictureBox 2 and save to file.
            pictureBox2.Image = bmp;
            bmp.Save("watermarked_image.jpg");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _angle = (_angle + 5) % 360;
            panel2.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _timer.Stop();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            _timer.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.SuspendLayout();
            Graphics g = e.Graphics;
            g.TranslateTransform(panel2.Width / 2, panel2.Height / 2);
            g.RotateTransform(_angle);
            g.FillRectangle(Brushes.Blue, 25, 25, 50, 50);
            panel2.ResumeLayout();
        }

        private void BtDoubleBufferON_Click(object sender, EventArgs e)
        {
            panel2.SetDoubleBuffering(true);
        }

        private void BtDoubleBufferOFF_Click(object sender, EventArgs e)
        {
            panel2.SetDoubleBuffering(false);
        }
    }

    public static class Extensions
    {
        public static void SetDoubleBuffering(this Control control, bool enable)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            property.SetValue(control, enable, null);
        }
    }
}
