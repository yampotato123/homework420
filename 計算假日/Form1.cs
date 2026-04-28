namespace 計算假日
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int year))
            {
                MessageBox.Show("請輸入西元年", "錯誤", MessageBoxButtons.OK);
                return;
            }
            int rocyear = year + 1911;
            //民國年
            int satdays = 0;
            int sundays = 0;
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);

            for (DateTime dt = start; dt <= end; dt = dt.AddDays(1))
            {
                if (dt.DayOfWeek == DayOfWeek.Saturday)
                    satdays++;
                else if (dt.DayOfWeek == DayOfWeek.Sunday)
                    sundays++;
            }
            label1.Text = $"{year}年的星期六有{satdays} 天，星期日有 {sundays} 天";
        }                //改民國(rocyear)
           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
