using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace INITEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 
        [DllImport("kernel32")] 
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath); 
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        #endregion
        public void IniWriteValue(string section, string key, string iValue)
        {
            WritePrivateProfileString(section, key, iValue, System.Environment.CurrentDirectory + "\\INITest.ini");
        }
        public string IniReadValue(string section, string key)
        { 
        StringBuilder temp = new StringBuilder(255); 
        int i = GetPrivateProfileString(section, key, "", temp, 255, System.Environment.CurrentDirectory + "\\INITest.ini"); 
        return temp.ToString();
    }
    private void button1_Click(object sender, EventArgs e) 
        {
           IniWriteValue(textBox_section.Text , textBox_key.Text, textBox_Value.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            label_Value.Text = IniReadValue(textBox_section.Text, textBox_key.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = System.Environment.CurrentDirectory;
            label2.Text = System.Windows.Forms.Application.StartupPath;
        }
    }
}
