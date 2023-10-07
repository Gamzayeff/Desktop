using FormHomework.Properties;

namespace FormHomework
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.BakuPhoto;
            Label timeLabel = new Label();
            timeLabel.Location = new Point(203, 200);

            timeLabel.Text = DateTime.Now.ToLongTimeString();

            Controls.Add(timeLabel);
        }

        private void LondonButton_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.LondonPhoto;
            Label timeLabel = new Label();
            timeLabel.Location = new Point(473, 200);

            int hour = DateTime.Now.Hour - 2;
            int minute = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;

            Controls.Add(timeLabel);
            
        }

    }
}