using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace first_frontend
{
    internal class Myform: Form
    {
        public Myform()
        {
            this.Text = "Title";
            this.BackColor = Color.Green;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.DrawString("Never gona give you up\nnever gona let you down", this.Font, Brushes.White, 90, 90);
            g.DrawLine(new Pen(Color.Blue), 10, 10, 80, 80);
            g.DrawRectangle(new Pen(Color.Yellow, 4.0F), 80,80,170,60 );
            Image bild = Image.FromFile("Download.jpg");
            g.DrawImage(bild, 300, 80);
        }
    }

}
