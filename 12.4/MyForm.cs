
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _12._4
{
    internal class MyForm :Form
    {
        private string[] split;
        public MyForm()
        {
            Console.WriteLine("Welches Profil wollen sie Ansehen?");
            string path = Console.ReadLine();
            string Text = System.IO.File.ReadAllText(path);
            this.split = Text.Split(new[] { '\r', '\n' });

            this.Text = "Mega cooles auslesen";
            //this.WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;
            Size bereich = new Size(200, Font.Height * this.split.Length);
            this.AutoScrollMinSize = bereich;
            this.ResizeRedraw = true;
            this.BackColor = Color.Purple;

        }
        protected override void OnPaint(PaintEventArgs e)
        {



            Graphics g = e.Graphics;
            int abstand = Font.Height;

            for (int i = 0; i < this.split.Length -1; i++)
            {
                g.DrawString(this.split[i], this.Font, Brushes.Turquoise, 0, AutoScrollPosition.Y + i * abstand);
            }
            string bildpath = split[8];
            Image bild = Image.FromFile(bildpath);
            g.DrawImage(bild, 10, 90);

        }
    }
}
