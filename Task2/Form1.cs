using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            list = new List<double>();
        }
        List<double> list;
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); list.Clear();

            Random rnd = new Random();
            for(int i = 0; i < 15; i++)
            {
                list.Add(-10 + (rnd.NextDouble() * (10 +10)));
            }
            
            foreach(int i in list)
            {
                listView1.Items.Add(i.ToString()); 
            }

            textBox1.Text=Functions.midvalue(list).ToString();
        }
    }
}
