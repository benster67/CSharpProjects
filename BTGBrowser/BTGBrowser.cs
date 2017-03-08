using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTGBrowser
{
    public partial class BTGBrowser : Form
    {
        public BTGBrowser()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BTGBrowser v1.0 by Ben Piecora");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
