using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (c.Size.Height > 700)
                c.Size = new Size(c.Size.Width,700);
            else if (c.Size.Height < 300)
                c.Size = new Size(c.Size.Width, 300);
            else if (c.Size.Width > 500)
                c.Size = new Size(500, c.Size.Height);
            else if (c.Size.Width < 300)
                c.Size = new Size(300, c.Size.Height);
        }
    }
}
