using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button myButton = new Button() { Height = 100, Width = 100, Top = 100, Left = 100, Visible = true, Text = "Test", BackColor = Color.HotPink };
            Controls.Add(myButton);
            
        }
    }
}
