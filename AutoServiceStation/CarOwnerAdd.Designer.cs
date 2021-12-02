namespace AutoServiceStation
{
    partial class CarOwnerAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelCarBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GRZBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CarOwnersView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SurNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarOwnersView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автомобиль:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.GRZBox);
            this.groupBox1.Controls.Add(this.ModelCarBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Марка:";
            // 
            // ModelCarBox
            // 
            this.ModelCarBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ModelCarBox.Location = new System.Drawing.Point(60, 15);
            this.ModelCarBox.Name = "ModelCarBox";
            this.ModelCarBox.Size = new System.Drawing.Size(107, 20);
            this.ModelCarBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ГРЗ:";
            // 
            // GRZBox
            // 
            this.GRZBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GRZBox.Location = new System.Drawing.Point(60, 41);
            this.GRZBox.Name = "GRZBox";
            this.GRZBox.Size = new System.Drawing.Size(107, 20);
            this.GRZBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить существующего";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarOwnersView
            // 
            this.CarOwnersView.AllowUserToAddRows = false;
            this.CarOwnersView.AllowUserToDeleteRows = false;
            this.CarOwnersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarOwnersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurName,
            this.ClientName,
            this.Birthday,
            this.Phone});
            this.CarOwnersView.Location = new System.Drawing.Point(214, 55);
            this.CarOwnersView.Name = "CarOwnersView";
            this.CarOwnersView.ReadOnly = true;
            this.CarOwnersView.Size = new System.Drawing.Size(421, 100);
            this.CarOwnersView.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Новый владелец:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.PhoneBox);
            this.groupBox2.Controls.Add(this.BirthdayPicker);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NameBox);
            this.groupBox2.Controls.Add(this.SurNameBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 105);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Фамилия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(36, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Имя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(267, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Телефон:";
            // 
            // SurNameBox
            // 
            this.SurNameBox.Location = new System.Drawing.Point(77, 15);
            this.SurNameBox.Name = "SurNameBox";
            this.SurNameBox.Size = new System.Drawing.Size(129, 20);
            this.SurNameBox.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(77, 44);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(129, 20);
            this.NameBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(229, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дата рождения:";
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.CustomFormat = "dd.MM.yyyy";
            this.BirthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdayPicker.Location = new System.Drawing.Point(336, 15);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(147, 20);
            this.BirthdayPicker.TabIndex = 8;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(336, 44);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(147, 20);
            this.PhoneBox.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить нового";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SurName
            // 
            this.SurName.HeaderText = "Фамилия";
            this.SurName.Name = "SurName";
            this.SurName.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Имя";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // CarOwnerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CarOwnersView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CarOwnerAdd";
            this.Text = "Владельцы авто";
            this.Load += new System.EventHandler(this.CarOwnerAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarOwnersView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GRZBox;
        private System.Windows.Forms.TextBox ModelCarBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CarOwnersView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}