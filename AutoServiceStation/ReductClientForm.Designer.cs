namespace AutoServiceStation
{
    partial class ReductClientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ClientSurNameBox = new System.Windows.Forms.TextBox();
            this.ClientNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientBirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientPhoneBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientCar = new System.Windows.Forms.DataGridView();
            this.idCarClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarGRZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangeClientAutoButton = new System.Windows.Forms.Button();
            this.ClientCarGRZBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ModelCarsBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClienFIOChangeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // ClientSurNameBox
            // 
            this.ClientSurNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientSurNameBox.Location = new System.Drawing.Point(115, 27);
            this.ClientSurNameBox.Name = "ClientSurNameBox";
            this.ClientSurNameBox.Size = new System.Drawing.Size(200, 21);
            this.ClientSurNameBox.TabIndex = 2;
            // 
            // ClientNameBox
            // 
            this.ClientNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientNameBox.Location = new System.Drawing.Point(115, 56);
            this.ClientNameBox.Name = "ClientNameBox";
            this.ClientNameBox.Size = new System.Drawing.Size(200, 21);
            this.ClientNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения:";
            // 
            // ClientBirthdayPicker
            // 
            this.ClientBirthdayPicker.CustomFormat = "dd.MM.yyyy";
            this.ClientBirthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ClientBirthdayPicker.Location = new System.Drawing.Point(115, 86);
            this.ClientBirthdayPicker.Name = "ClientBirthdayPicker";
            this.ClientBirthdayPicker.Size = new System.Drawing.Size(200, 20);
            this.ClientBirthdayPicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(46, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон:";
            // 
            // ClientPhoneBox
            // 
            this.ClientPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientPhoneBox.Location = new System.Drawing.Point(115, 115);
            this.ClientPhoneBox.Name = "ClientPhoneBox";
            this.ClientPhoneBox.Size = new System.Drawing.Size(200, 21);
            this.ClientPhoneBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Авто:";
            // 
            // ClientCar
            // 
            this.ClientCar.AllowUserToAddRows = false;
            this.ClientCar.AllowUserToDeleteRows = false;
            this.ClientCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarClient,
            this.CarModel,
            this.CarGRZ});
            this.ClientCar.Location = new System.Drawing.Point(18, 23);
            this.ClientCar.Name = "ClientCar";
            this.ClientCar.ReadOnly = true;
            this.ClientCar.Size = new System.Drawing.Size(297, 127);
            this.ClientCar.TabIndex = 9;
            // 
            // idCarClient
            // 
            this.idCarClient.HeaderText = "id";
            this.idCarClient.Name = "idCarClient";
            this.idCarClient.ReadOnly = true;
            this.idCarClient.Visible = false;
            // 
            // CarModel
            // 
            this.CarModel.HeaderText = "Марка";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // CarGRZ
            // 
            this.CarGRZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarGRZ.HeaderText = "ГРЗ";
            this.CarGRZ.Name = "CarGRZ";
            this.CarGRZ.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Изменить авто:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangeClientAutoButton);
            this.groupBox1.Controls.Add(this.ClientCarGRZBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ModelCarsBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(18, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // ChangeClientAutoButton
            // 
            this.ChangeClientAutoButton.Location = new System.Drawing.Point(60, 69);
            this.ChangeClientAutoButton.Name = "ChangeClientAutoButton";
            this.ChangeClientAutoButton.Size = new System.Drawing.Size(121, 23);
            this.ChangeClientAutoButton.TabIndex = 12;
            this.ChangeClientAutoButton.Text = "Изменить авто";
            this.ChangeClientAutoButton.UseVisualStyleBackColor = true;
            this.ChangeClientAutoButton.Click += new System.EventHandler(this.ChangeClientAutoButton_Click);
            // 
            // ClientCarGRZBox
            // 
            this.ClientCarGRZBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientCarGRZBox.Location = new System.Drawing.Point(60, 42);
            this.ClientCarGRZBox.Name = "ClientCarGRZBox";
            this.ClientCarGRZBox.Size = new System.Drawing.Size(121, 21);
            this.ClientCarGRZBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(21, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "ГРЗ:";
            // 
            // ModelCarsBox
            // 
            this.ModelCarsBox.FormattingEnabled = true;
            this.ModelCarsBox.Location = new System.Drawing.Point(60, 15);
            this.ModelCarsBox.Name = "ModelCarsBox";
            this.ModelCarsBox.Size = new System.Drawing.Size(121, 21);
            this.ModelCarsBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Марка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClienFIOChangeButton);
            this.groupBox2.Controls.Add(this.ClientSurNameBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ClientNameBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ClientPhoneBox);
            this.groupBox2.Controls.Add(this.ClientBirthdayPicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(44, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 172);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // ClienFIOChangeButton
            // 
            this.ClienFIOChangeButton.Location = new System.Drawing.Point(115, 143);
            this.ClienFIOChangeButton.Name = "ClienFIOChangeButton";
            this.ClienFIOChangeButton.Size = new System.Drawing.Size(200, 23);
            this.ClienFIOChangeButton.TabIndex = 14;
            this.ClienFIOChangeButton.Text = "Изменить данные клиента";
            this.ClienFIOChangeButton.UseVisualStyleBackColor = true;
            this.ClienFIOChangeButton.Click += new System.EventHandler(this.ClienFIOChangeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(41, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Клиент:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClientCar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(44, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 279);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // ReductClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 516);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Name = "ReductClientForm";
            this.Text = "Информация о клиенте";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReductClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ReductClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientSurNameBox;
        private System.Windows.Forms.TextBox ClientNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ClientBirthdayPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientPhoneBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ClientCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ChangeClientAutoButton;
        private System.Windows.Forms.TextBox ClientCarGRZBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ModelCarsBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClienFIOChangeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarGRZ;
    }
}