using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //
            TextBox tb = new TextBox();
            tb.Left = 0;
            tb.Top = 0;
            tb.Width = 500;
            tb.Text = "Das geht nich";
        }
    }
}
