namespace AutoServiceStation
{
    partial class AllServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllServicesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceNameBox = new System.Windows.Forms.TextBox();
            this.ServicePriceBox = new System.Windows.Forms.TextBox();
            this.ComboButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MoreButton = new System.Windows.Forms.Button();
            this.EqButton = new System.Windows.Forms.Button();
            this.LessButton = new System.Windows.Forms.Button();
            this.AllServicesView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.NewServiceNameBox = new System.Windows.Forms.TextBox();
            this.NewServiceAdd = new System.Windows.Forms.Button();
            this.NewServicePriceBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllServicesView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена:";
            // 
            // ServiceNameBox
            // 
            this.ServiceNameBox.Location = new System.Drawing.Point(71, 10);
            this.ServiceNameBox.Name = "ServiceNameBox";
            this.ServiceNameBox.Size = new System.Drawing.Size(227, 20);
            this.ServiceNameBox.TabIndex = 2;
            this.ServiceNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ServicePriceBox
            // 
            this.ServicePriceBox.Location = new System.Drawing.Point(71, 36);
            this.ServicePriceBox.Name = "ServicePriceBox";
            this.ServicePriceBox.Size = new System.Drawing.Size(227, 20);
            this.ServicePriceBox.TabIndex = 3;
            this.ServicePriceBox.TextChanged += new System.EventHandler(this.ServicePriceBox_TextChanged);
            // 
            // ComboButton
            // 
            this.ComboButton.BackColor = System.Drawing.Color.Red;
            this.ComboButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboButton.Image = ((System.Drawing.Image)(resources.GetObject("ComboButton.Image")));
            this.ComboButton.Location = new System.Drawing.Point(304, 9);
            this.ComboButton.Name = "ComboButton";
            this.ComboButton.Size = new System.Drawing.Size(45, 47);
            this.ComboButton.TabIndex = 4;
            this.ComboButton.UseVisualStyleBackColor = false;
            this.ComboButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Режим:";
            // 
            // MoreButton
            // 
            this.MoreButton.Image = ((System.Drawing.Image)(resources.GetObject("MoreButton.Image")));
            this.MoreButton.Location = new System.Drawing.Point(74, 68);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(24, 23);
            this.MoreButton.TabIndex = 6;
            this.MoreButton.UseVisualStyleBackColor = true;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // EqButton
            // 
            this.EqButton.Image = ((System.Drawing.Image)(resources.GetObject("EqButton.Image")));
            this.EqButton.Location = new System.Drawing.Point(104, 68);
            this.EqButton.Name = "EqButton";
            this.EqButton.Size = new System.Drawing.Size(24, 23);
            this.EqButton.TabIndex = 7;
            this.EqButton.UseVisualStyleBackColor = true;
            this.EqButton.Click += new System.EventHandler(this.EqButton_Click);
            // 
            // LessButton
            // 
            this.LessButton.Image = ((System.Drawing.Image)(resources.GetObject("LessButton.Image")));
            this.LessButton.Location = new System.Drawing.Point(134, 68);
            this.LessButton.Name = "LessButton";
            this.LessButton.Size = new System.Drawing.Size(24, 23);
            this.LessButton.TabIndex = 8;
            this.LessButton.UseVisualStyleBackColor = true;
            this.LessButton.Click += new System.EventHandler(this.LessButton_Click);
            // 
            // AllServicesView
            // 
            this.AllServicesView.AllowUserToAddRows = false;
            this.AllServicesView.AllowUserToDeleteRows = false;
            this.AllServicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllServicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Service,
            this.Price});
            this.AllServicesView.Location = new System.Drawing.Point(12, 97);
            this.AllServicesView.Name = "AllServicesView";
            this.AllServicesView.ReadOnly = true;
            this.AllServicesView.Size = new System.Drawing.Size(337, 219);
            this.AllServicesView.TabIndex = 9;
            this.AllServicesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllServicesView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Service.HeaderText = "Услуга";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Стоимость:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(122, 322);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(52, 17);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "label5";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(337, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Редактировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // NewServiceNameBox
            // 
            this.NewServiceNameBox.Location = new System.Drawing.Point(12, 371);
            this.NewServiceNameBox.Name = "NewServiceNameBox";
            this.NewServiceNameBox.Size = new System.Drawing.Size(178, 20);
            this.NewServiceNameBox.TabIndex = 13;
            // 
            // NewServiceAdd
            // 
            this.NewServiceAdd.Location = new System.Drawing.Point(274, 369);
            this.NewServiceAdd.Name = "NewServiceAdd";
            this.NewServiceAdd.Size = new System.Drawing.Size(75, 23);
            this.NewServiceAdd.TabIndex = 14;
            this.NewServiceAdd.Text = "Добавить";
            this.NewServiceAdd.UseVisualStyleBackColor = true;
            this.NewServiceAdd.Click += new System.EventHandler(this.NewServiceAdd_Click);
            // 
            // NewServicePriceBox
            // 
            this.NewServicePriceBox.Location = new System.Drawing.Point(196, 371);
            this.NewServicePriceBox.Name = "NewServicePriceBox";
            this.NewServicePriceBox.Size = new System.Drawing.Size(72, 20);
            this.NewServicePriceBox.TabIndex = 15;
            // 
            // AllServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 402);
            this.Controls.Add(this.NewServicePriceBox);
            this.Controls.Add(this.NewServiceAdd);
            this.Controls.Add(this.NewServiceNameBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AllServicesView);
            this.Controls.Add(this.LessButton);
            this.Controls.Add(this.EqButton);
            this.Controls.Add(this.MoreButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboButton);
            this.Controls.Add(this.ServicePriceBox);
            this.Controls.Add(this.ServiceNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AllServicesForm";
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.AllServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllServicesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServiceNameBox;
        private System.Windows.Forms.TextBox ServicePriceBox;
        private System.Windows.Forms.Button ComboButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MoreButton;
        private System.Windows.Forms.Button EqButton;
        private System.Windows.Forms.Button LessButton;
        private System.Windows.Forms.DataGridView AllServicesView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox NewServiceNameBox;
        private System.Windows.Forms.Button NewServiceAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.TextBox NewServicePriceBox;
    }
}