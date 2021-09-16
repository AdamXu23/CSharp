using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;

namespace OPC_UA_Sever_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Timer;
        private void Cycle_Time_Tick(object sender, EventArgs e)
        {
            PC_TIME.Text = Timer.ToString();
            Timer = Timer + 1;
        }
    }
}
