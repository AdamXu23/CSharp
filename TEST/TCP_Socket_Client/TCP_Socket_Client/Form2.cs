using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCP_Socket_Client
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if ((UserName.Text == "AVEX") & (Password.Text == "AVEXadmin"))
            {
                Form1 Window = new Form1();
                Window.ShowDialog();
                this.Close();
            }
        }
    }
}
