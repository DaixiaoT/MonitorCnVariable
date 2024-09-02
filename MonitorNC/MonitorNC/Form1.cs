using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorNC
{
    public partial class Form1 : Form
    {
        UserControl1 UserControl1;
        UserControl2 UserControl2;
        public Form1()
        {
            UserControl1 = new UserControl1();
            UserControl2 = new UserControl2();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nC变量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(UserControl1);
        }

        private void pLC变量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(UserControl2);
        }
    }
}
