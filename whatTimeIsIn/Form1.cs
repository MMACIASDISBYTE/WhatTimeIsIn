namespace whatTimeIsIn
{
    public partial class Form1 : Form
    {
        private TimeZoneService _timeZoneService;
        public Form1()
        {
            InitializeComponent();
            _timeZoneService = new TimeZoneService();
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
            var locaDate = _timeZoneService.GetCurrentDateByTimeZone("Eastern Standard Time");

            lblTime2.Text = locaDate.ToString("HH:mm");
            lblSecond2.Text = locaDate.ToString("ss");
            lblDate2.Text = locaDate.ToString("MMM dd yyyy");
            lblDay2.Text = locaDate.ToString("dddd");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var locaDate = _timeZoneService.GetCurrentDateByTimeZone("China Standard Time");

            lblTime3.Text = locaDate.ToString("HH:mm");
            lblSecond3.Text = locaDate.ToString("ss");
            lblDate3.Text = locaDate.ToString("MMM dd yyyy");
            lblDay3.Text = locaDate.ToString("dddd");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var locaDate = _timeZoneService.GetCurrentDateByTimeZone("Tokyo Standard Time");

            lblTime4.Text = locaDate.ToString("HH:mm");
            lblSecond4.Text = locaDate.ToString("ss");
            lblDate4.Text = locaDate.ToString("MMM dd yyyy");
            lblDay4.Text = locaDate.ToString("dddd");
        }
    }
}