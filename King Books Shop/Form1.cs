using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace King_Books_Shop
{
    public partial class loading1 : Form
    {
        public loading1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width > -3) ;
        }

        private void loading1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 30;
        }

        private void loadingLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loading1_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
