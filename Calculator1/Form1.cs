using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            var fonten = new Font("Verdana", 25, FontStyle.Regular);
            var plus = new Button() { Text = "+", Top = 205, Left = 20, Width = 50, Height = 50 };
            var minus = new Button() { Text = "-", Top = 205, Left = 80, Width = 50, Height = 50 };
            var divide = new Button() { Text = "/", Top = 205, Left = 140, Width = 50, Height = 50 };
            var multiply = new Button() { Text = "*", Top = 205, Left = 200, Width = 50, Height = 50 };
            var firstInput = new TextBox() { Top = 10, Left = 5, Width = 270, Height = 80 };
            var secondInput = new TextBox() { Top = 70, Left = 5, Width = 270, Height = 40 };
            TextBox theAnswer = new TextBox() { Top = 155, Left = 5, Width = 270, Height = 40 };
            var myLabel = new Label() { Text = "=", Top = 115, Left = 120, Height = 30 };
            plus.Font = fonten;
            minus.Font = fonten;
            divide.Font = fonten;
            multiply.Font = fonten;
            firstInput.Font = fonten;
            secondInput.Font = fonten;
            myLabel.Font = fonten;
            theAnswer.Font = fonten;
            Controls.Add(firstInput);
            Controls.Add(secondInput);
            Controls.Add(theAnswer);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(myLabel);
            plus.Click += new System.EventHandler(this.myPlusClick(theAnswer);*/
        }

        private void myPlusClick(object sender, EventArgs e)
        {
            
        }

        private void buttonClickEvent(object sender, EventArgs e)
        {
            Button input = (Button)sender;

        }
    }
}
