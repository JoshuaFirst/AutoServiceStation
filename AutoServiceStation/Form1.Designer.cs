namespace AutoServiceStation
{
    partial class AutoServiceStation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.QueryView = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idЗаявки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddQueryButton = new System.Windows.Forms.Button();
            this.BirthdayDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.MobilePhoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GRZBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CarSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.QueryServicesView = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrvicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FinishQueryButton = new System.Windows.Forms.Button();
            this.ChangeQueryButton = new System.Windows.Forms.Button();
            this.DeleteQueryButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ClientChooseQueyry = new System.Windows.Forms.DataGridView();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ССid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQueryButtonSecond = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маркиАвтоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryServicesView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientChooseQueyry)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.QueryView.Location = new System.Drawing.Point(9, 48);
            this.QueryView.Name = "QueryView";
            this.QueryView.ReadOnly = true;
            this.QueryView.Size = new System.Drawing.Size(835, 197);
            this.QueryView.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заявки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Формирование заказа:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddQueryButton);
            this.groupBox1.Controls.Add(this.BirthdayDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MobilePhoneBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.GRZBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CarSelect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FIOBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // AddQueryButton
            // 
            this.AddQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQueryButton.Location = new System.Drawing.Point(7, 155);
            this.AddQueryButton.Name = "AddQueryButton";
            this.AddQueryButton.Size = new System.Drawing.Size(328, 36);
            this.AddQueryButton.TabIndex = 10;
            this.AddQueryButton.Text = "Добавить";
            this.AddQueryButton.UseVisualStyleBackColor = true;
            this.AddQueryButton.Click += new System.EventHandler(this.AddQueryButton_Click);
            // 
            // BirthdayDate
            // 
            this.BirthdayDate.CustomFormat = "dd.MM.yyyy";
            this.BirthdayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdayDate.Location = new System.Drawing.Point(130, 116);
            this.BirthdayDate.Name = "BirthdayDate";
            this.BirthdayDate.Size = new System.Drawing.Size(205, 20);
            this.BirthdayDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата рождения:";
            // 
            // MobilePhoneBox
            // 
            this.MobilePhoneBox.Location = new System.Drawing.Point(89, 81);
            this.MobilePhoneBox.Name = "MobilePhoneBox";
            this.MobilePhoneBox.Size = new System.Drawing.Size(246, 20);
            this.MobilePhoneBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Телефон:";
            // 
            // GRZBox
            // 
            this.GRZBox.Location = new System.Drawing.Point(235, 50);
            this.GRZBox.Name = "GRZBox";
            this.GRZBox.Size = new System.Drawing.Size(100, 20);
            this.GRZBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(189, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "ГРЗ:";
            // 
            // CarSelect
            // 
            this.CarSelect.FormattingEnabled = true;
            this.CarSelect.Location = new System.Drawing.Point(62, 49);
            this.CarSelect.Name = "CarSelect";
            this.CarSelect.Size = new System.Drawing.Size(121, 21);
            this.CarSelect.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Авто:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ф.И.";
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(62, 19);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(273, 20);
            this.FIOBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PriceBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.QueryServicesView);
            this.groupBox2.Location = new System.Drawing.Point(385, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 197);
            this.groupBox2.TabIndex = 4;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(387, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Услуги:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FinishQueryButton);
            this.groupBox3.Controls.Add(this.ChangeQueryButton);
            this.groupBox3.Controls.Add(this.DeleteQueryButton);
            this.groupBox3.Location = new System.Drawing.Point(703, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 196);
            this.groupBox3.TabIndex = 6;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(700, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Управление заявкой:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 270);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 222);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новый";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Существующий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClientChooseQueyry);
            this.groupBox4.Controls.Add(this.AddQueryButtonSecond);
            this.groupBox4.Location = new System.Drawing.Point(4, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 197);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // ClientChooseQueyry
            // 
            this.ClientChooseQueyry.AllowUserToAddRows = false;
            this.ClientChooseQueyry.AllowUserToDeleteRows = false;
            this.ClientChooseQueyry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientChooseQueyry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClient,
            this.ССid,
            this.F,
            this.ClientName,
            this.CBd,
            this.CCName,
            this.CPn});
            this.ClientChooseQueyry.Location = new System.Drawing.Point(7, 14);
            this.ClientChooseQueyry.Name = "ClientChooseQueyry";
            this.ClientChooseQueyry.ReadOnly = true;
            this.ClientChooseQueyry.Size = new System.Drawing.Size(328, 135);
            this.ClientChooseQueyry.TabIndex = 11;
            // 
            // idClient
            // 
            this.idClient.HeaderText = "idClient";
            this.idClient.Name = "idClient";
            this.idClient.ReadOnly = true;
            this.idClient.Visible = false;
            // 
            // ССid
            // 
            this.ССid.HeaderText = "ССid";
            this.ССid.Name = "ССid";
            this.ССid.ReadOnly = true;
            this.ССid.Visible = false;
            // 
            // F
            // 
            this.F.HeaderText = "Фамилия";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Имя";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // CBd
            // 
            this.CBd.HeaderText = "Дата рождения";
            this.CBd.Name = "CBd";
            this.CBd.ReadOnly = true;
            // 
            // CCName
            // 
            this.CCName.HeaderText = "Автомобиль";
            this.CCName.Name = "CCName";
            this.CCName.ReadOnly = true;
            // 
            // CPn
            // 
            this.CPn.HeaderText = "Телефон";
            this.CPn.Name = "CPn";
            this.CPn.ReadOnly = true;
            // 
            // AddQueryButtonSecond
            // 
            this.AddQueryButtonSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQueryButtonSecond.Location = new System.Drawing.Point(7, 155);
            this.AddQueryButtonSecond.Name = "AddQueryButtonSecond";
            this.AddQueryButtonSecond.Size = new System.Drawing.Size(328, 36);
            this.AddQueryButtonSecond.TabIndex = 10;
            this.AddQueryButtonSecond.Text = "Добавить";
            this.AddQueryButtonSecond.UseVisualStyleBackColor = true;
            this.AddQueryButtonSecond.Click += new System.EventHandler(this.AddQueryButtonSecond_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.автоToolStripMenuItem,
            this.маркиАвтоToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.заявкиToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // автоToolStripMenuItem
            // 
            this.автоToolStripMenuItem.Name = "автоToolStripMenuItem";
            this.автоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.автоToolStripMenuItem.Text = "Авто";
            this.автоToolStripMenuItem.Click += new System.EventHandler(this.автоToolStripMenuItem_Click);
            // 
            // маркиАвтоToolStripMenuItem
            // 
            this.маркиАвтоToolStripMenuItem.Name = "маркиАвтоToolStripMenuItem";
            this.маркиАвтоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.маркиАвтоToolStripMenuItem.Text = "Марки авто";
            this.маркиАвтоToolStripMenuItem.Click += new System.EventHandler(this.маркиАвтоToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            this.заявкиToolStripMenuItem.Click += new System.EventHandler(this.заявкиToolStripMenuItem_Click);
            // 
            // AutoServiceStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(856, 499);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutoServiceStation";
            this.Text = "Станция Технического Обслуживания";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QueryView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryServicesView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientChooseQueyry)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView QueryView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddQueryButton;
        private System.Windows.Forms.DateTimePicker BirthdayDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MobilePhoneBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GRZBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CarSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView QueryServicesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrvicePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button FinishQueryButton;
        private System.Windows.Forms.Button ChangeQueryButton;
        private System.Windows.Forms.Button DeleteQueryButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView ClientChooseQueyry;
        private System.Windows.Forms.Button AddQueryButtonSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ССid;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаявки;
        private System.Windows.Forms.ToolStripMenuItem автоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маркиАвтоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
    }
}

