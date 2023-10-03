using System;
using System.Reflection;
using Task_3.Properties;

namespace Task_3
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timerBaku = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerLondon = new System.Windows.Forms.Timer();

        Label lab = new();
        public Form1()
        {

            InitializeComponent();
            lab.Location = new Point(350, 70);
            lab.Size = new(100, 25);
            Controls.Add(lab);
            button1_Click(default, default);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerLondon.Stop();
            this.BackgroundImage = Resources.AdobeStock_231148604_Preview;
            timerBaku.Interval = 1000;
            timerBaku.Tick += (s, e) => lab.Text = DateTime.Now.ToString($"HH:mm:ss");
            timerBaku.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerBaku.Stop();
            timerLondon.Start();
            this.BackgroundImage = Resources.AdobeStock_132796360_Preview;
            timerLondon.Interval = 1000;
            string temp = DateTime.Now.ToString("HH");
            timerLondon.Tick += (s, e) => lab.Text = DateTime.Now.ToString($"{Convert.ToInt32(temp) + 4}:mm:ss");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}