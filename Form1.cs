using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T9_A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = "29 + 38 = " + (29 + 38);
            Reset();
            lblAnswer1.Visible = true;
            btnAdd.Enabled = false;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            lblAnswer2.Text = "420 - 353 = " + (420 - 353);
            Reset();

            lblAnswer2.Visible = true;
            btnSubtract.Enabled= false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblAnswer3.Text = "3 * 23 = " + (3 * 23);
            Reset();

            lblAnswer3.Visible = true;
            btnMultiply.Enabled = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblAnswer4.Text = "138 / 2 = " + (138 / 2);
            Reset();

            lblAnswer4.Visible = true;
            btnDivide.Enabled = false;
        }

        private void Reset()
        {
            lblAnswer1.Visible = false;
            lblAnswer2.Visible = false;
            lblAnswer3.Visible = false;
            lblAnswer4.Visible = false;
            btnAdd.Enabled = true;
            btnSubtract.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
        }

    }
}
