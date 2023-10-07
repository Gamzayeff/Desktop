namespace FormHomework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Random x = new Random();
            Random y = new Random();
            

            label1.Location = new Point(x.Next(0,ClientSize.Width-79), y.Next(0,ClientSize.Height-20));
        }
    }
}