using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stCont=new StCont();
            dataGridView1.DataSource=bindingSource1;
            bindingSource1.DataSource = stCont;
        }
        StCont stCont;

        private void button_search_Click(object sender, EventArgs e)
        {
            
            
                Student student = new Student()
                {
                    FIO=textBox_s_fio.Text=="" ? (null):(textBox_s_fio.Text),
                    group=textBox_s_group.Text==""?(null):(textBox_s_group.Text),
                    faculty=textBox_s_faculty.Text==""?(null):(textBox_s_faculty.Text),
                    mid_mark = double.TryParse(textBox_s_mid_mark.Text, out double mid_mark) ? (mid_mark) : (0),
                    receipt_date = (DateTime.TryParse(textBox_s_receipt_date.Text, out DateTime dateTime)|textBox_s_receipt_date.Text!="") ? (dateTime) : (DateTime.MinValue),
                    speciality = textBox_s_speciality.Text == "" ? (null) : (textBox_s_faculty.Text)

                };
                bindingSource1.DataSource = stCont.Search(student);
            
        }

        private void button_searchCancel_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = stCont;
            textBox_s_faculty.Text = textBox_s_fio.Text = textBox_s_speciality.Text = textBox_s_group.Text =textBox_s_mid_mark.Text=textBox_s_receipt_date.Text= "";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(double.TryParse(textBox_a_mid_mark.Text,out double mid_mark)&mid_mark>0 & DateTime.TryParse(textBox_a_receipt_date.Text, out DateTime dateTime))
            {
                Student student = new Student()
                {
                    FIO = textBox_a_fio.Text,
                    group = textBox_a_group.Text,
                    faculty = textBox_a_faculty.Text,
                    receipt_date = dateTime,
                    mid_mark = mid_mark,
                    speciality = textBox_a_speciality.Text
                };
                bindingSource1.Add(student);
            
            }
        }

        private void button_delete_selected_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null) 
            bindingSource1.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button_delete_full_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource=stCont;
            bindingSource1.Clear();
        }

       
    }
}
