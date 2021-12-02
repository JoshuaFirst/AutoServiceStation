namespace AutoServiceStation
{
    partial class AllAutoForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AllModelCarsView = new System.Windows.Forms.DataGridView();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllCarOwners = new System.Windows.Forms.DataGridView();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllModelCarsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AllModelCarsView
            // 
            this.AllModelCarsView.AllowUserToAddRows = false;
            this.AllModelCarsView.AllowUserToDeleteRows = false;
            this.AllModelCarsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllModelCarsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarID,
            this.ModelCar,
            this.GRZ});
            this.AllModelCarsView.Location = new System.Drawing.Point(15, 46);
            this.AllModelCarsView.Name = "AllModelCarsView";
            this.AllModelCarsView.ReadOnly = true;
            this.AllModelCarsView.Size = new System.Drawing.Size(257, 150);
            this.AllModelCarsView.TabIndex = 2;
            this.AllModelCarsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllModelCarsView_CellContentClick);
            // 
            // CarID
            // 
            this.CarID.HeaderText = "id";
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
            // GRZ
            // 
            this.GRZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRZ.HeaderText = "ГРЗ";
            this.GRZ.Name = "GRZ";
            this.GRZ.ReadOnly = true;
            // 
            // AllCarOwners
            // 
            this.AllCarOwners.AllowUserToAddRows = false;
            this.AllCarOwners.AllowUserToDeleteRows = false;
            this.AllCarOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCarOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurName,
            this.ClientName,
            this.Birthday,
            this.Phone});
            this.AllCarOwners.Location = new System.Drawing.Point(278, 46);
            this.AllCarOwners.Name = "AllCarOwners";
            this.AllCarOwners.ReadOnly = true;
            this.AllCarOwners.Size = new System.Drawing.Size(464, 150);
            this.AllCarOwners.TabIndex = 3;
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
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить владельца";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllCarOwners);
            this.Controls.Add(this.AllModelCarsView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AllAutoForm";
            this.Text = "Реестр авто";
            this.Load += new System.EventHandler(this.AllAutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllModelCarsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView AllModelCarsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRZ;
        private System.Windows.Forms.DataGridView AllCarOwners;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Button button1;
    }
}