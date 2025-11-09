namespace _01_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price, quantity, subtotal, tax, total;

            const double TAX_RATE = 0.1;
            
            price = Convert.ToInt32(textBox1.Text);
            quantity = Convert.ToInt32(textBox2.Text);
            subtotal = price * quantity;

            tax = (int)(subtotal * TAX_RATE);

            total = subtotal + tax;

            //label6.Text=Convert.ToString(subtotal);
            //label7.Text=Convert.ToString(tax);
            //label8.Text=Convert.ToString(total);
            label6.Text = String.Format("{0:#,##0}‰~", subtotal);
            label7.Text = String.Format("{0:#,##0}‰~", tax);
            label8.Text = String.Format("{0:#,3#0}‰~", total);


        }

    }
}
