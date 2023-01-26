
using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _12._2
{
    internal class myForm : Form
    {
        private string[] split;
        public myForm()
        {
            Console.WriteLine("Welche datei wollen sie auslesen? (z.b.: AveMaria.txt)");
            string path = Console.ReadLine();
            string Text = System.IO.File.ReadAllText(path);
            this.split = Text.Split(new[] { '\r', '\n' });

            this.Text = "Mega cooles auslesen";
            //this.WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;
            Size bereich = new Size(200,Font.Height * this.split.Length);
            this.AutoScrollMinSize = bereich;
            this.ResizeRedraw = true;
            this.BackColor = Color.Purple;
    }

        
        protected override void OnPaint(PaintEventArgs e)
        {



            Graphics g = e.Graphics;
            int abstand = Font.Height;

            for (int i= 0; i <this.split.Length; i++)
            {
                g.DrawString(this.split[i], this.Font, Brushes.Turquoise, 0, AutoScrollPosition.Y + i * abstand);
            }
            
           
        }

    }

        
    }

