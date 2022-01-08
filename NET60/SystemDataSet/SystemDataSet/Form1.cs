namespace SystemDataSet
{
    public partial class Form1 : Form
    {
        public _Data _data = new _Data("Test_Data");
        public Form1()
        {
            InitializeComponent();
            DataSet_TextBox.Text = _data.GetString();
            DataTable_ComboBox.Items.AddRange(_data.GetDataTable());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WriteXml_button_Click(object sender, EventArgs e)
        {
            _data.dataset.WriteXml(DataSet_TextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataTable_ComboBox.SelectedIndex >= 0)
            {
                _data.dataset.Tables[DataTable_ComboBox.SelectedIndex].WriteXml(DataTable_ComboBox.SelectedItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataTable_ComboBox.SelectedIndex >= 0)
            {
                dataGridView1.DataSource = _data.dataset.Tables[DataTable_ComboBox.SelectedIndex];
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}