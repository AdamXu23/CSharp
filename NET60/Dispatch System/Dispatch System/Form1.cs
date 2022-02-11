namespace Dispatch_System
{
    public partial class Form1 : Form
    {
        public Dispatch_System_Configure dispatch_System_Configure ;
        public Form1()
        {
            InitializeComponent();
            dispatch_System_Configure = new Dispatch_System_Configure();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dispatch_System_Configure.Save();
        }
    }
}