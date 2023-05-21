using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robot_degilim
{
    public partial class Form1 : Form
    {

        TrackBar yan = new TrackBar();
        TrackBar yukarı = new TrackBar();
        int b = 0;
        int a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox2.Location = new Point(1, 0);



            yan.Location = new Point(92, 290);
            yan.Maximum = 351;
            yan.Minimum = 0;
            yan.Size = new Size(389, 35);
            yan.ValueChanged += Yan_ValueChanged;
            yan.TickStyle = TickStyle.TopLeft;

            yukarı.RightToLeft = RightToLeft.Yes;
            yukarı.Location = new Point(520, 10);
            yukarı.Maximum = 201;
            yukarı.Minimum = 0;
            yukarı.Orientation = Orientation.Vertical;
            yukarı.Size = new Size(150, 300);
            yukarı.ValueChanged += Yukarı_ValueChanged;
            yukarı.TickStyle = TickStyle.TopLeft;
            yukarı.Value = 201;
            
            



            this.Controls.Add(yukarı);
            this.Controls.Add(yan);
        }

        private void Yukarı_ValueChanged(object sender, EventArgs e)
        {
            int c =201- yukarı.Value;
            if (b < yukarı.Value)
            {
                pictureBox2.Location = new Point(yan.Value,c);
            }
            else
            {
                pictureBox2.Location = new Point(yan.Value,c);
            }
            b = yukarı.Value;
        }

        private void Yan_ValueChanged(object sender, EventArgs e)
        {
            int c = 201 - yukarı.Value;
            if (a < yan.Value)
            {
                pictureBox2.Location = new Point(yan.Value, c);
            }
            else
            {
                pictureBox2.Location = new Point(yan.Value, c);
            }
            a = yan.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = pictureBox2.Location.X;
            int b = pictureBox2.Location.Y;
            if (a == 244 && b == 78)
            {
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
        }

    }
}
