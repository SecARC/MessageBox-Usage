using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week07_1
{
    public partial class Form1 : Form
    {
        public MessageBoxButtons buttonType { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Font = new Font("Console", 10, FontStyle.Bold | FontStyle.Italic);
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButtonOK)
                this.buttonType = MessageBoxButtons.OK;
            else if (sender == radioButtonOKCancel)
                this.buttonType = MessageBoxButtons.OKCancel;
            else
                this.buttonType = MessageBoxButtons.YesNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a MessageBox", "Custom MessageBox", this.buttonType);
        }
    }
}
