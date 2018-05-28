using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {

            lbtitle.Left += i;
            if (lbtitle.Left >= this.Width - lbtitle.Width || lbtitle.Left <= 0)
                i = -i;

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
