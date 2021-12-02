namespace AutoServiceStation
{
    partial class NewOldCarOwner
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
            this.button1 = new System.Windows.Forms.Button();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllClientsView
            // 
            this.AllClientsView.AllowUserToAddRows = false;
            this.AllClientsView.AllowUserToDeleteRows = false;
            this.AllClientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClientsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurName,
            this.ClientName,
            this.ClientBirthday,
            this.ClientPhoneNumber});
            this.AllClientsView.Location = new System.Drawing.Point(12, 12);
            this.AllClientsView.Name = "AllClientsView";
            this.AllClientsView.ReadOnly = true;
            this.AllClientsView.Size = new System.Drawing.Size(499, 232);
            this.AllClientsView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // NewOldCarOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllClientsView);
            this.Name = "NewOldCarOwner";
            this.Text = "Выбор нового владельца";
            this.Load += new System.EventHandler(this.NewOldCarOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllClientsView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhoneNumber;
    }
}