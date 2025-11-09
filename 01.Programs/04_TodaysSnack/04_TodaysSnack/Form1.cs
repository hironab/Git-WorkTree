namespace _04_TodaysSnack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("使える金額を入力しよう！");
            }
            else
            {
                int pocket = Convert.ToInt32(textBox1.Text);
                string caption = "どちらか選ぼう！";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result1;
                DialogResult result2;

                string message1 = "甘いのにする？";
                string message2 = "カロリーは気になる？";

                if(pocket < 300)
                {
                    label2.Text = "カリカリシュークリーム一択だ！";
                } else
                {
                    result1 = MessageBox.Show(message1, caption, buttons);
                    result2 = MessageBox.Show(message2, caption, buttons);

                    if (result1 == DialogResult.Yes & result2 == DialogResult.Yes)
                    {
                        label2.Text = "ぷろぷるコーヒーゼリーにしよう！";
                    }
                    else if(result1== DialogResult.Yes & result2 == DialogResult.No) 
                    {
                        label2.Text = "濃厚キャラメルチーズタルトにしましょう！";
                    }else if(result1== DialogResult.No &result2 == DialogResult.Yes)
                    {
                        label2.Text = "プロティンゼリーだね！";
                    }
                    else
                    {
                        label2.Text = "ビターカカオエクレアにしましょう！";
                    }
                }
            }
        }
    }
}
