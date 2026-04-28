namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int rocYear))
            {
                MessageBox.Show("請輸入有效的民國年份！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int adYear = rocYear + 1911;  // 民國轉西元

            int totalDays = DateTime.IsLeapYear(adYear) ? 366 : 365;  // 該年總天數
            int extraDays = totalDays % 7;                              // 多出幾天

            DayOfWeek firstDay = new DateTime(adYear, 1, 1).DayOfWeek; // 第一天星期幾

            int satCount = 52;
            int sunCount = 52;

            // 只跑多出來的 1~2 天
            for (int i = 0; i < extraDays; i++)
            {
                DayOfWeek d = (DayOfWeek)(((int)firstDay + i) % 7);
                if (d == DayOfWeek.Saturday) satCount++;
                if (d == DayOfWeek.Sunday) sunCount++;
            }

            label1.Text = $"民國 {rocYear} 年有：\n星期六 {satCount} 天\n星期日 {sunCount} 天";
        }
    }
}