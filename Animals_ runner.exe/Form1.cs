namespace Animals__runner.exe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dog, lion, cow;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int wcow = pictureBox1.Width;
            int wlion = pictureBox2.Width;
            int wdog= pictureBox3.Width;
            int start = label4.Left;
            pictureBox1.Left = pictureBox1.Left + rnd.Next(5,17);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 17);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 17);
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label5.Text = "Inek hal hazirda 1 ci ilerleyir";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label5.Text = "Aslan hal hazirda 1 ci ilerleyir";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label5.Text = "It hal hazirda 1 ci ilerleyir";
            }
            if (wcow + pictureBox1.Left >= start)
            {
                timer1.Enabled = false;
                label5.Text = "Inek galib geldi";
            }
            if (wlion + pictureBox2.Left >= start)
            {
                timer1.Enabled = false;
                label5.Text = "Aslan galib geldi";
            }
            if (wdog + pictureBox3.Left >= start)
            {
                timer1.Enabled = false;
                label5.Text = "It galib geldi";
            }

            if (wdog+pictureBox3.Left>=start)
            {
                timer1.Enabled = false;
            }
            if (wcow + pictureBox1.Left >= start)
            {
                timer1.Enabled = false;
            }

            if (wlion + pictureBox2.Left >= start)
            {
                timer1.Enabled = false;
            }
        }

        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            cow = pictureBox1.Left ;
            lion = pictureBox2.Left;
            dog = pictureBox3.Left;
        }
    }
}