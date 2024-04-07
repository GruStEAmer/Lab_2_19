using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_19
{
    public partial class UserControl1 : UserControl
    {
        int counter = 0;
        Size size_h = new Size(165,55);
        Point Loctb = new Point(82,88);

        int sz = 0;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTextBox tb = new MyTextBox();
            tb.Name = "tb" + counter.ToString();
            tb.Size = new Size(165,30);
            tb.Location = new Point(330, 50);
            tb.BackColor = Color.LightSkyBlue;
            tb.MouseUp += OnMouseUp;
            counter++;
            Controls.Add(tb);
            tb.BringToFront();

        }
        /*
        */
        private void OnMouseUp(object sender,MouseEventArgs mevent)
        {
            
            MyTextBox tb = (MyTextBox)sender;
            tb.IsDragMode = false;
            if ((textBox2.Location.X <= tb.Location.X && tb.Location.X <= textBox2.Location.X + textBox2.Size.Width) &&
                (textBox2.Location.Y <= tb.Location.Y && tb.Location.Y <= textBox2.Location.Y + textBox2.Size.Height)
            )
            {
                if (tb.point)
                {
                    size_h.Height += 35;
                    textBox2.Size = size_h;

                    tb.Location = Loctb;
                    Loctb.Y += 35;
                    tb.BringToFront();

                    tb.point = false;
                    sz++;
                }
            }
            else if(sz >= 0 && tb.point == false)
            {
                size_h.Height -= 35;
                textBox2.Size = size_h;

                tb.Location = Loctb;
                Loctb.Y -= 35;
                tb.BringToFront();

                tb.point = true;
                sz--;
            }

            base.OnMouseUp(mevent);
        }

    }
}
