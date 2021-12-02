namespace AutoServiceStation
{
    partial class AllClientsForm
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
            this.AllClientsView = new System.Windows.Forms.DataGridView();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsCarView = new System.Windows.Forms.DataGridView();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReductClientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsCarView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllClientsView
            // 
            this.AllClientsView.AllowUserToAddRows = false;
            this.AllClientsView.AllowUserToDeleteRows = false;
            this.AllClientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClientsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.SurName,
            this.ClientName,
            this.ClientBirthday,
            this.ClientPhoneNumber});
            this.AllClientsView.Location = new System.Drawing.Point(12, 49);
            this.AllClientsView.Name = "AllClientsView";
            this.AllClientsView.ReadOnly = true;
            this.AllClientsView.Size = new System.Drawing.Size(499, 232);
            this.AllClientsView.TabIndex = 0;
            this.AllClientsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllClientsView_CellContentClick);
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "id";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Visible = false;
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
            // ClientBirthday
            // 
            this.ClientBirthday.HeaderText = "Дата рождения";
            this.ClientBirthday.Name = "ClientBirthday";
            this.ClientBirthday.ReadOnly = true;
            // 
            // ClientPhoneNumber
            // 
            this.ClientPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientPhoneNumber.HeaderText = "Телефон";
            this.ClientPhoneNumber.Name = "ClientPhoneNumber";
            this.ClientPhoneNumber.ReadOnly = true;
            // 
            // ClientsCarView
            // 
            this.ClientsCarView.AllowUserToAddRows = false;
            this.ClientsCarView.AllowUserToDeleteRows = false;
            this.ClientsCarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsCarView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarID,
            this.ModelCar,
            this.RegisterSign});
            this.ClientsCarView.Location = new System.Drawing.Point(517, 49);
            this.ClientsCarView.Name = "ClientsCarView";
            this.ClientsCarView.ReadOnly = true;
            this.ClientsCarView.Size = new System.Drawing.Size(271, 232);
            this.ClientsCarView.TabIndex = 1;
            // 
            // CarID
            // 
            this.CarID.HeaderText = "CarID";
            this.CarID.Name = "CarID";
            this.CarID.ReadOnly = true;
            this.CarID.Visible = false;
            // 
            // ModelCar
            // 
            this.ModelCar.HeaderText = "Марка";
            this.ModelCar.Name = "ModelCar";
            this.ModelCar.ReadOnly = true;
            // 
            // RegisterSign
            // 
            this.RegisterSign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegisterSign.HeaderText = "ГРЗ";
            this.RegisterSign.Name = "RegisterSign";
            this.RegisterSign.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск:";
            // 
            // ReductClientButton
            // 
            this.ReductClientButton.Location = new System.Drawing.Point(636, 304);
            this.ReductClientButton.Name = "ReductClientButton";
            this.ReductClientButton.Size = new System.Drawing.Size(137, 23);
            this.ReductClientButton.TabIndex = 4;
            this.ReductClientButton.Text = "Редактировать";
            this.ReductClientButton.UseVisualStyleBackColor = true;
            this.ReductClientButton.Click += new System.EventHandler(this.ReductClientButton_Click);
            // 
            // AllClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.ReductClientButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClientsCarView);
            this.Controls.Add(this.AllClientsView);
            this.Name = "AllClientsForm";
            this.Text = "Клиенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllClientsForm_FormClosing);
            this.Load += new System.EventHandler(this.AllClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsCarView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllClientsView;
        private System.Windows.Forms.DataGridView ClientsCarView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterSign;
        private System.Windows.Forms.Button ReductClientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhoneNumber;
    }
}