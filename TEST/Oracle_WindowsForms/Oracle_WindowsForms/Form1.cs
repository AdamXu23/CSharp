using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //string connString = "Data Source=DESKTOP-ORACLE:1521/orcl;PERSIST SECURITY INFO=True;USER ID=SYS as SYSDBA;password=XSZ19930323"
        string connString;
        private void button1_Click(object sender, EventArgs e)
        {
            Event_label.Text = "Linking";
            if (Password_textBox.Text.Length == 0)
            {
                connString = "Data Source=DESKTOP-ORACLE:1521/orcl;USER ID=C##" + USER_ID_textBox.Text + ";password=XSZ19930323";
            }
            else
            {
                connString = "Data Source=DESKTOP-ORACLE:1521/orcl;USER ID=C##" + USER_ID_textBox.Text + ";password=" + Password_textBox.Text;
            }
            OracleConnection conn = new OracleConnection(connString);
            try
            {
                conn.Open();
                Event_label.Text = "OracleConnection is already connected";
            }
            catch (Exception ex)
            {
                Event_label.Text = ex.Message.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void INSERT_button_Click(object sender, EventArgs e)
        {
            //OracleParameter FACTORY = new OracleParameter();
            //FACTORY.OracleDbType = OracleDbType.Varchar2;
            //FACTORY.Value = FACTORY_ComboBox.Text;

            //OracleParameter JOB_NUMBER = new OracleParameter();
            //JOB_NUMBER.OracleDbType = OracleDbType.Varchar2;
            //JOB_NUMBER.Value = JOB_NUMBER_textBox.Text;

            //OracleParameter SERIAL_NUMBER = new OracleParameter();
            //SERIAL_NUMBER.OracleDbType = OracleDbType.Varchar2;
            //SERIAL_NUMBER.Value = SERIAL_NUMBER_textBox.Text;

            //OracleCommand cmd = new OracleCommand();
            //INSERT INTO "C##ADAMXU"."OHC_ELECTRIC_CONTROL_BOX"(JOB_NUMBER, FACTORY, SERIAL_NUMBER, DAY) VALUES('P202303001', 'F16', 'S12342345', TO_DATE('2020-09-01 15:12:12', 'YYYY-MM-DD HH24:MI:SS'))
            //cmd.CommandText = "INSERT INTO \"C##" + USER_ID_textBox.Text + "\".\"OHC_ELECTRIC_CONTROL_BOX\"(JOB_NUMBER, FACTORY, SERIAL_NUMBER, DAY) values (:1, :2, :3)";
            //cmd.ArrayBindCount = foos.Length;
            //cmd.Parameters.Add(FACTORY);
            //cmd.Parameters.Add(JOB_NUMBER);
            //cmd.Parameters.Add(SERIAL_NUMBER);
            //cmd.ExecuteNonQuery();

        }
    }
}
