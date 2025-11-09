namespace _06_ForEachApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = System.Drawing.Color.Red;   
            }
        }
    }
}
