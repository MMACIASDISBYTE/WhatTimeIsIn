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
        }
    }
}