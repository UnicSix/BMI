namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string inputData = "BMI1";
        public Form1()
        {
            InitializeComponent();
            System.IO.StreamReader file = new System.IO.StreamReader(inputData);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}