namespace whatTimeIsIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime1.Text = DateTime.Now.ToString("HH:mm");
            lblSecond1.Text = DateTime.Now.ToString("ss");
            lblDate1.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay1.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var easternDate = TimeZoneInfo.ConvertTime(DateTime.Now, inTimeZone);

            lblTime2.Text = easternDate.ToString("HH:mm");
            lblSecond2.Text = easternDate.ToString("ss");
            lblDate2.Text = easternDate.ToString("MMM dd yyyy");
            lblDay2.Text = easternDate.ToString("dddd");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            var easternDate = TimeZoneInfo.ConvertTime(DateTime.Now, inTimeZone);

            lblTime3.Text = easternDate.ToString("HH:mm");
            lblSecond3.Text = easternDate.ToString("ss");
            lblDate3.Text = easternDate.ToString("MMM dd yyyy");
            lblDay3.Text = easternDate.ToString("dddd");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            var easternDate = TimeZoneInfo.ConvertTime(DateTime.Now, inTimeZone);

            lblTime4.Text = easternDate.ToString("HH:mm");
            lblSecond4.Text = easternDate.ToString("ss");
            lblDate4.Text = easternDate.ToString("MMM dd yyyy");
            lblDay4.Text = easternDate.ToString("dddd");
        }
    }
}