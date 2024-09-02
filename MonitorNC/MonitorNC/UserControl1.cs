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
    public partial class UserControl1 : UserControl
    {
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void setConnectStatusLabelText(string connectStatusLabelText)
        {
            connect_status_label.Text = connectStatusLabelText;
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            m_OpcTool.getConnectted();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
