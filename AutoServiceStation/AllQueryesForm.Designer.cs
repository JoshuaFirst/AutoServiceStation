namespace AutoServiceStation
{
    partial class AllQueryesForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FinishQueryButton = new System.Windows.Forms.Button();
            this.ChangeQueryButton = new System.Windows.Forms.Button();
            this.DeleteQueryButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.QueryServicesView = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrvicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QueryView = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idЗаявки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MobilePhoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GRZBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CarSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DoneBox = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryServicesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(706, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Управление заявкой:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FinishQueryButton);
            this.groupBox3.Controls.Add(this.ChangeQueryButton);
            this.groupBox3.Controls.Add(this.DeleteQueryButton);
            this.groupBox3.Location = new System.Drawing.Point(709, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 196);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // FinishQueryButton
            // 
            this.FinishQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishQueryButton.Location = new System.Drawing.Point(10, 126);
            this.FinishQueryButton.Name = "FinishQueryButton";
            this.FinishQueryButton.Size = new System.Drawing.Size(123, 57);
            this.FinishQueryButton.TabIndex = 2;
            this.FinishQueryButton.Text = "Выполнить";
            this.FinishQueryButton.UseVisualStyleBackColor = true;
            this.FinishQueryButton.Click += new System.EventHandler(this.FinishQueryButton_Click);
            // 
            // ChangeQueryButton
            // 
            this.ChangeQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeQueryButton.Location = new System.Drawing.Point(10, 67);
            this.ChangeQueryButton.Name = "ChangeQueryButton";
            this.ChangeQueryButton.Size = new System.Drawing.Size(123, 50);
            this.ChangeQueryButton.TabIndex = 1;
            this.ChangeQueryButton.Text = "Редактировать";
            this.ChangeQueryButton.UseVisualStyleBackColor = true;
            this.ChangeQueryButton.Click += new System.EventHandler(this.ChangeQueryButton_Click);
            // 
            // DeleteQueryButton
            // 
            this.DeleteQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteQueryButton.Location = new System.Drawing.Point(10, 23);
            this.DeleteQueryButton.Name = "DeleteQueryButton";
            this.DeleteQueryButton.Size = new System.Drawing.Size(123, 38);
            this.DeleteQueryButton.TabIndex = 0;
            this.DeleteQueryButton.Text = "Удалить";
            this.DeleteQueryButton.UseVisualStyleBackColor = true;
            this.DeleteQueryButton.Click += new System.EventHandler(this.DeleteQueryButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(393, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Услуги:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PriceBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.QueryServicesView);
            this.groupBox2.Location = new System.Drawing.Point(391, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 197);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // PriceBox
            // 
            this.PriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceBox.Location = new System.Drawing.Point(147, 163);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(145, 20);
            this.PriceBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(87, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Итог:";
            // 
            // QueryServicesView
            // 
            this.QueryServicesView.AllowUserToAddRows = false;
            this.QueryServicesView.AllowUserToDeleteRows = false;
            this.QueryServicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryServicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.SrvicePrice});
            this.QueryServicesView.Location = new System.Drawing.Point(5, 16);
            this.QueryServicesView.Name = "QueryServicesView";
            this.QueryServicesView.ReadOnly = true;
            this.QueryServicesView.Size = new System.Drawing.Size(292, 138);
            this.QueryServicesView.TabIndex = 0;
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Service.HeaderText = "Услуга";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            // 
            // SrvicePrice
            // 
            this.SrvicePrice.HeaderText = "Цена";
            this.SrvicePrice.Name = "SrvicePrice";
            this.SrvicePrice.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Поиск:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Заявки:";
            // 
            // QueryView
            // 
            this.QueryView.AllowUserToAddRows = false;
            this.QueryView.AllowUserToDeleteRows = false;
            this.QueryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Car,
            this.Birthday,
            this.DateBegin,
            this.Price,
            this.State,
            this.idЗаявки});
            this.QueryView.Location = new System.Drawing.Point(15, 29);
            this.QueryView.Name = "QueryView";
            this.QueryView.ReadOnly = true;
            this.QueryView.Size = new System.Drawing.Size(835, 197);
            this.QueryView.TabIndex = 9;
            this.QueryView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QueryView_CellContentClick);
            // 
            // Client
            // 
            this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client.HeaderText = "Клиент";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Car
            // 
            this.Car.HeaderText = "Авто";
            this.Car.Name = "Car";
            this.Car.ReadOnly = true;
            this.Car.Width = 127;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.MaxInputLength = 10;
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 128;
            // 
            // DateBegin
            // 
            this.DateBegin.HeaderText = "Принято";
            this.DateBegin.Name = "DateBegin";
            this.DateBegin.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Итог";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 127;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.State.HeaderText = "Состояние";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // idЗаявки
            // 
            this.idЗаявки.HeaderText = "idЗаявки";
            this.idЗаявки.Name = "idЗаявки";
            this.idЗаявки.ReadOnly = true;
            this.idЗаявки.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DoneBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.MobilePhoneBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.GRZBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CarSelect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FIOBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 197);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(195, 104);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(151, 36);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Очистить поиск";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MobilePhoneBox
            // 
            this.MobilePhoneBox.Location = new System.Drawing.Point(92, 78);
            this.MobilePhoneBox.Name = "MobilePhoneBox";
            this.MobilePhoneBox.Size = new System.Drawing.Size(246, 20);
            this.MobilePhoneBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Телефон:";
            // 
            // GRZBox
            // 
            this.GRZBox.Location = new System.Drawing.Point(238, 47);
            this.GRZBox.Name = "GRZBox";
            this.GRZBox.Size = new System.Drawing.Size(100, 20);
            this.GRZBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(192, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "ГРЗ:";
            // 
            // CarSelect
            // 
            this.CarSelect.FormattingEnabled = true;
            this.CarSelect.Location = new System.Drawing.Point(65, 46);
            this.CarSelect.Name = "CarSelect";
            this.CarSelect.Size = new System.Drawing.Size(121, 21);
            this.CarSelect.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Авто:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ф.И.";
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(65, 16);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(273, 20);
            this.FIOBox.TabIndex = 11;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(195, 146);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(151, 36);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Состояние:";
            // 
            // DoneBox
            // 
            this.DoneBox.AutoSize = true;
            this.DoneBox.Location = new System.Drawing.Point(92, 157);
            this.DoneBox.Name = "DoneBox";
            this.DoneBox.Size = new System.Drawing.Size(83, 17);
            this.DoneBox.TabIndex = 3;
            this.DoneBox.Text = "Выполнено";
            this.DoneBox.UseVisualStyleBackColor = true;
            // 
            // AllQueryesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryView);
            this.Name = "AllQueryesForm";
            this.Text = "Все заявки";
            this.Load += new System.EventHandler(this.AllQueryesForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryServicesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button FinishQueryButton;
        private System.Windows.Forms.Button ChangeQueryButton;
        private System.Windows.Forms.Button DeleteQueryButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView QueryServicesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrvicePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView QueryView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаявки;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox MobilePhoneBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GRZBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CarSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.CheckBox DoneBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchButton;
    }
}