namespace Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button_add = new Button();
            textBox_a_faculty = new TextBox();
            textBox_a_mid_mark = new TextBox();
            textBox_a_receipt_date = new TextBox();
            textBox_a_speciality = new TextBox();
            textBox_a_group = new TextBox();
            textBox_a_fio = new TextBox();
            groupBox2 = new GroupBox();
            button_delete_selected = new Button();
            button_delete_full = new Button();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_searchCancel = new Button();
            button_search = new Button();
            textBox_s_faculty = new TextBox();
            textBox_s_mid_mark = new TextBox();
            textBox_s_receipt_date = new TextBox();
            textBox_s_speciality = new TextBox();
            textBox_s_group = new TextBox();
            textBox_s_fio = new TextBox();
            bindingSource1 = new BindingSource(components);
            FIO = new DataGridViewTextBoxColumn();
            group = new DataGridViewTextBoxColumn();
            speciality = new DataGridViewTextBoxColumn();
            receipt_date = new DataGridViewTextBoxColumn();
            mid_mark = new DataGridViewTextBoxColumn();
            faculty = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FIO, group, speciality, receipt_date, mid_mark, faculty });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(937, 658);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button_add);
            groupBox1.Controls.Add(textBox_a_faculty);
            groupBox1.Controls.Add(textBox_a_mid_mark);
            groupBox1.Controls.Add(textBox_a_receipt_date);
            groupBox1.Controls.Add(textBox_a_speciality);
            groupBox1.Controls.Add(textBox_a_group);
            groupBox1.Controls.Add(textBox_a_fio);
            groupBox1.Location = new Point(955, 392);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 357);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 269);
            label12.Name = "label12";
            label12.Size = new Size(78, 20);
            label12.TabIndex = 12;
            label12.Text = "Факультет";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 228);
            label11.Name = "label11";
            label11.Size = new Size(122, 20);
            label11.TabIndex = 11;
            label11.Text = "Средняя оценка";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 181);
            label10.Name = "label10";
            label10.Size = new Size(134, 20);
            label10.TabIndex = 10;
            label10.Text = "Дата поступления";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 130);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 9;
            label9.Text = "Специальность";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 76);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 8;
            label8.Text = "Группа";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 34);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 7;
            label7.Text = "ФИО";
            // 
            // button_add
            // 
            button_add.Location = new Point(107, 320);
            button_add.Name = "button_add";
            button_add.Size = new Size(197, 29);
            button_add.TabIndex = 6;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // textBox_a_faculty
            // 
            textBox_a_faculty.Location = new Point(142, 266);
            textBox_a_faculty.Name = "textBox_a_faculty";
            textBox_a_faculty.Size = new Size(204, 27);
            textBox_a_faculty.TabIndex = 5;
            // 
            // textBox_a_mid_mark
            // 
            textBox_a_mid_mark.Location = new Point(142, 225);
            textBox_a_mid_mark.Name = "textBox_a_mid_mark";
            textBox_a_mid_mark.Size = new Size(204, 27);
            textBox_a_mid_mark.TabIndex = 4;
            // 
            // textBox_a_receipt_date
            // 
            textBox_a_receipt_date.Location = new Point(142, 178);
            textBox_a_receipt_date.Name = "textBox_a_receipt_date";
            textBox_a_receipt_date.Size = new Size(204, 27);
            textBox_a_receipt_date.TabIndex = 3;
            // 
            // textBox_a_speciality
            // 
            textBox_a_speciality.Location = new Point(142, 127);
            textBox_a_speciality.Name = "textBox_a_speciality";
            textBox_a_speciality.Size = new Size(204, 27);
            textBox_a_speciality.TabIndex = 2;
            // 
            // textBox_a_group
            // 
            textBox_a_group.Location = new Point(142, 73);
            textBox_a_group.Name = "textBox_a_group";
            textBox_a_group.Size = new Size(204, 27);
            textBox_a_group.TabIndex = 1;
            // 
            // textBox_a_fio
            // 
            textBox_a_fio.Location = new Point(142, 31);
            textBox_a_fio.Name = "textBox_a_fio";
            textBox_a_fio.Size = new Size(204, 27);
            textBox_a_fio.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_delete_selected);
            groupBox2.Controls.Add(button_delete_full);
            groupBox2.Location = new Point(119, 676);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(538, 65);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Удаление";
            // 
            // button_delete_selected
            // 
            button_delete_selected.Location = new Point(6, 26);
            button_delete_selected.Name = "button_delete_selected";
            button_delete_selected.Size = new Size(230, 29);
            button_delete_selected.TabIndex = 1;
            button_delete_selected.Text = "Удалить выбранный элемент";
            button_delete_selected.UseVisualStyleBackColor = true;
            button_delete_selected.Click += button_delete_selected_Click;
            // 
            // button_delete_full
            // 
            button_delete_full.Location = new Point(302, 26);
            button_delete_full.Name = "button_delete_full";
            button_delete_full.Size = new Size(230, 29);
            button_delete_full.TabIndex = 0;
            button_delete_full.Text = "Очистить список";
            button_delete_full.UseVisualStyleBackColor = true;
            button_delete_full.Click += button_delete_full_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(button_searchCancel);
            groupBox3.Controls.Add(button_search);
            groupBox3.Controls.Add(textBox_s_faculty);
            groupBox3.Controls.Add(textBox_s_mid_mark);
            groupBox3.Controls.Add(textBox_s_receipt_date);
            groupBox3.Controls.Add(textBox_s_speciality);
            groupBox3.Controls.Add(textBox_s_group);
            groupBox3.Controls.Add(textBox_s_fio);
            groupBox3.Location = new Point(955, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(381, 374);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Поиск";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 272);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 13;
            label6.Text = "Факультет";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 224);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 12;
            label5.Text = "Средняя оценка";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 175);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 11;
            label4.Text = "Дата поступления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 126);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 10;
            label3.Text = "Специальность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 9;
            label2.Text = "Группа";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 8;
            label1.Text = "ФИО";
            // 
            // button_searchCancel
            // 
            button_searchCancel.Location = new Point(189, 325);
            button_searchCancel.Name = "button_searchCancel";
            button_searchCancel.Size = new Size(125, 29);
            button_searchCancel.TabIndex = 7;
            button_searchCancel.Text = "Отмена поиска";
            button_searchCancel.UseVisualStyleBackColor = true;
            button_searchCancel.Click += button_searchCancel_Click;
            // 
            // button_search
            // 
            button_search.Location = new Point(49, 325);
            button_search.Name = "button_search";
            button_search.Size = new Size(94, 29);
            button_search.TabIndex = 6;
            button_search.Text = "Искать";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // textBox_s_faculty
            // 
            textBox_s_faculty.Location = new Point(146, 269);
            textBox_s_faculty.Name = "textBox_s_faculty";
            textBox_s_faculty.Size = new Size(200, 27);
            textBox_s_faculty.TabIndex = 5;
            // 
            // textBox_s_mid_mark
            // 
            textBox_s_mid_mark.Location = new Point(146, 221);
            textBox_s_mid_mark.Name = "textBox_s_mid_mark";
            textBox_s_mid_mark.Size = new Size(200, 27);
            textBox_s_mid_mark.TabIndex = 4;
            // 
            // textBox_s_receipt_date
            // 
            textBox_s_receipt_date.Location = new Point(146, 172);
            textBox_s_receipt_date.Name = "textBox_s_receipt_date";
            textBox_s_receipt_date.Size = new Size(200, 27);
            textBox_s_receipt_date.TabIndex = 3;
            // 
            // textBox_s_speciality
            // 
            textBox_s_speciality.Location = new Point(146, 123);
            textBox_s_speciality.Name = "textBox_s_speciality";
            textBox_s_speciality.Size = new Size(200, 27);
            textBox_s_speciality.TabIndex = 2;
            // 
            // textBox_s_group
            // 
            textBox_s_group.Location = new Point(142, 71);
            textBox_s_group.Name = "textBox_s_group";
            textBox_s_group.Size = new Size(204, 27);
            textBox_s_group.TabIndex = 1;
            // 
            // textBox_s_fio
            // 
            textBox_s_fio.Location = new Point(142, 20);
            textBox_s_fio.Name = "textBox_s_fio";
            textBox_s_fio.Size = new Size(204, 27);
            textBox_s_fio.TabIndex = 0;
            // 
            // FIO
            // 
            FIO.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FIO.DataPropertyName = "FIO";
            FIO.Frozen = true;
            FIO.HeaderText = "Ф.И.О.";
            FIO.MinimumWidth = 6;
            FIO.Name = "FIO";
            FIO.ReadOnly = true;
            FIO.Width = 80;
            // 
            // group
            // 
            group.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            group.DataPropertyName = "group";
            group.Frozen = true;
            group.HeaderText = "Группа";
            group.MinimumWidth = 6;
            group.Name = "group";
            group.ReadOnly = true;
            group.Width = 87;
            // 
            // speciality
            // 
            speciality.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            speciality.DataPropertyName = "speciality";
            speciality.Frozen = true;
            speciality.HeaderText = "Специальность";
            speciality.MinimumWidth = 6;
            speciality.Name = "speciality";
            speciality.ReadOnly = true;
            speciality.Width = 145;
            // 
            // receipt_date
            // 
            receipt_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            receipt_date.DataPropertyName = "receipt_date";
            receipt_date.Frozen = true;
            receipt_date.HeaderText = "Дата поступления";
            receipt_date.MinimumWidth = 6;
            receipt_date.Name = "receipt_date";
            receipt_date.ReadOnly = true;
            receipt_date.Width = 149;
            // 
            // mid_mark
            // 
            mid_mark.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mid_mark.DataPropertyName = "mid_mark";
            mid_mark.HeaderText = "Средняя оценка";
            mid_mark.MinimumWidth = 6;
            mid_mark.Name = "mid_mark";
            mid_mark.ReadOnly = true;
            mid_mark.Width = 80;
            // 
            // faculty
            // 
            faculty.DataPropertyName = "faculty";
            faculty.HeaderText = "Факультет";
            faculty.MinimumWidth = 6;
            faculty.Name = "faculty";
            faculty.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 753);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button_add;
        private TextBox textBox_a_faculty;
        private TextBox textBox_a_mid_mark;
        private TextBox textBox_a_receipt_date;
        private TextBox textBox_a_speciality;
        private TextBox textBox_a_group;
        private TextBox textBox_a_fio;
        private Button button_delete_selected;
        private Button button_delete_full;
        private GroupBox groupBox3;
        private Button button_searchCancel;
        private Button button_search;
        private TextBox textBox_s_faculty;
        private TextBox textBox_s_mid_mark;
        private TextBox textBox_s_receipt_date;
        private TextBox textBox_s_speciality;
        private TextBox textBox_s_group;
        private TextBox textBox_s_fio;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewTextBoxColumn group;
        private DataGridViewTextBoxColumn speciality;
        private DataGridViewTextBoxColumn receipt_date;
        private DataGridViewTextBoxColumn mid_mark;
        private DataGridViewTextBoxColumn faculty;
    }
}
