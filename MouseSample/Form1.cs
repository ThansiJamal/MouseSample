using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMouse_MouseEnter(object sender, EventArgs e)
        {
            btnMouse.BackColor = Color.Red;
        }

        private void btnMouse_MouseLeave(object sender, EventArgs e)
        {
            btnMouse.BackColor = Color.Yellow;
        }

        private void btnMouse_MouseUp(object sender, MouseEventArgs e)
        {
            btnMouse.BackColor = Color.Blue;
        }

        private void btnMouse_MouseDown(object sender, MouseEventArgs e)
        {
            btnMouse.BackColor = Color.Pink;
        }
    }
}
