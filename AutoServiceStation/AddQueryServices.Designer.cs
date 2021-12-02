namespace AutoServiceStation
{
    partial class AddQueryServices
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
            this.ChooseServicesView2 = new System.Windows.Forms.DataGridView();
            this.idServiceQueryAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceQueryAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceServiceQueryAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseServicesView1 = new System.Windows.Forms.DataGridView();
            this.idServiceQueryAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceQueryAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceServiceQueryAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQueryServiceButton = new System.Windows.Forms.Button();
            this.PoZayabkelabel = new System.Windows.Forms.Label();
            this.VseUslugilabel = new System.Windows.Forms.Label();
            this.RemoveQueryServiceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllServicesPriceBox = new System.Windows.Forms.TextBox();
            this.SumbitQueryServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseServicesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseServicesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseServicesView2
            // 
            this.ChooseServicesView2.AllowUserToAddRows = false;
            this.ChooseServicesView2.AllowUserToDeleteRows = false;
            this.ChooseServicesView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChooseServicesView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiceQueryAdd,
            this.ServiceQueryAdd,
            this.PriceServiceQueryAdd});
            this.ChooseServicesView2.Location = new System.Drawing.Point(488, 37);
            this.ChooseServicesView2.Name = "ChooseServicesView2";
            this.ChooseServicesView2.ReadOnly = true;
            this.ChooseServicesView2.Size = new System.Drawing.Size(300, 253);
            this.ChooseServicesView2.TabIndex = 1;
            // 
            // idServiceQueryAdd
            // 
            this.idServiceQueryAdd.HeaderText = "Column1";
            this.idServiceQueryAdd.Name = "idServiceQueryAdd";
            this.idServiceQueryAdd.ReadOnly = true;
            // 
            // ServiceQueryAdd
            // 
            this.ServiceQueryAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceQueryAdd.HeaderText = "Услуга";
            this.ServiceQueryAdd.Name = "ServiceQueryAdd";
            this.ServiceQueryAdd.ReadOnly = true;
            // 
            // PriceServiceQueryAdd
            // 
            this.PriceServiceQueryAdd.HeaderText = "Цена";
            this.PriceServiceQueryAdd.Name = "PriceServiceQueryAdd";
            this.PriceServiceQueryAdd.ReadOnly = true;
            // 
            // ChooseServicesView1
            // 
            this.ChooseServicesView1.AllowUserToAddRows = false;
            this.ChooseServicesView1.AllowUserToDeleteRows = false;
            this.ChooseServicesView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChooseServicesView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiceQueryAll,
            this.ServiceQueryAll,
            this.PriceServiceQueryAll});
            this.ChooseServicesView1.Location = new System.Drawing.Point(12, 37);
            this.ChooseServicesView1.Name = "ChooseServicesView1";
            this.ChooseServicesView1.ReadOnly = true;
            this.ChooseServicesView1.Size = new System.Drawing.Size(300, 253);
            this.ChooseServicesView1.TabIndex = 2;
            // 
            // idServiceQueryAll
            // 
            this.idServiceQueryAll.HeaderText = "idService";
            this.idServiceQueryAll.Name = "idServiceQueryAll";
            this.idServiceQueryAll.ReadOnly = true;
            this.idServiceQueryAll.Visible = false;
            // 
            // ServiceQueryAll
            // 
            this.ServiceQueryAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceQueryAll.HeaderText = "Услуга";
            this.ServiceQueryAll.Name = "ServiceQueryAll";
            this.ServiceQueryAll.ReadOnly = true;
            // 
            // PriceServiceQueryAll
            // 
            this.PriceServiceQueryAll.HeaderText = "Цена";
            this.PriceServiceQueryAll.Name = "PriceServiceQueryAll";
            this.PriceServiceQueryAll.ReadOnly = true;
            // 
            // AddQueryServiceButton
            // 
            this.AddQueryServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQueryServiceButton.Location = new System.Drawing.Point(370, 186);
            this.AddQueryServiceButton.Name = "AddQueryServiceButton";
            this.AddQueryServiceButton.Size = new System.Drawing.Size(61, 40);
            this.AddQueryServiceButton.TabIndex = 4;
            this.AddQueryServiceButton.Text = "→";
            this.AddQueryServiceButton.UseVisualStyleBackColor = true;
            this.AddQueryServiceButton.Click += new System.EventHandler(this.AddQueryServiceButton_Click);
            // 
            // PoZayabkelabel
            // 
            this.PoZayabkelabel.AutoSize = true;
            this.PoZayabkelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoZayabkelabel.Location = new System.Drawing.Point(485, 17);
            this.PoZayabkelabel.Name = "PoZayabkelabel";
            this.PoZayabkelabel.Size = new System.Drawing.Size(79, 17);
            this.PoZayabkelabel.TabIndex = 5;
            this.PoZayabkelabel.Text = "По заявке:";
            // 
            // VseUslugilabel
            // 
            this.VseUslugilabel.AutoSize = true;
            this.VseUslugilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VseUslugilabel.Location = new System.Drawing.Point(9, 17);
            this.VseUslugilabel.Name = "VseUslugilabel";
            this.VseUslugilabel.Size = new System.Drawing.Size(82, 17);
            this.VseUslugilabel.TabIndex = 6;
            this.VseUslugilabel.Text = "Все услуги:";
            // 
            // RemoveQueryServiceButton
            // 
            this.RemoveQueryServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveQueryServiceButton.Location = new System.Drawing.Point(371, 140);
            this.RemoveQueryServiceButton.Name = "RemoveQueryServiceButton";
            this.RemoveQueryServiceButton.Size = new System.Drawing.Size(60, 40);
            this.RemoveQueryServiceButton.TabIndex = 7;
            this.RemoveQueryServiceButton.Text = "←";
            this.RemoveQueryServiceButton.UseVisualStyleBackColor = true;
            this.RemoveQueryServiceButton.Click += new System.EventHandler(this.RemoveQueryServiceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(484, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Итог:";
            // 
            // AllServicesPriceBox
            // 
            this.AllServicesPriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AllServicesPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllServicesPriceBox.Location = new System.Drawing.Point(544, 305);
            this.AllServicesPriceBox.Name = "AllServicesPriceBox";
            this.AllServicesPriceBox.Size = new System.Drawing.Size(150, 20);
            this.AllServicesPriceBox.TabIndex = 9;
            // 
            // SumbitQueryServices
            // 
            this.SumbitQueryServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumbitQueryServices.Location = new System.Drawing.Point(704, 305);
            this.SumbitQueryServices.Name = "SumbitQueryServices";
            this.SumbitQueryServices.Size = new System.Drawing.Size(83, 20);
            this.SumbitQueryServices.TabIndex = 10;
            this.SumbitQueryServices.Text = "Готово";
            this.SumbitQueryServices.UseVisualStyleBackColor = true;
            this.SumbitQueryServices.Click += new System.EventHandler(this.SumbitQueryServices_Click);
            // 
            // AddQueryServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.SumbitQueryServices);
            this.Controls.Add(this.AllServicesPriceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveQueryServiceButton);
            this.Controls.Add(this.VseUslugilabel);
            this.Controls.Add(this.PoZayabkelabel);
            this.Controls.Add(this.AddQueryServiceButton);
            this.Controls.Add(this.ChooseServicesView1);
            this.Controls.Add(this.ChooseServicesView2);
            this.Name = "AddQueryServices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQueryServices_FormClosing);
            this.Load += new System.EventHandler(this.AddQueryServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChooseServicesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseServicesView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ChooseServicesView2;
        private System.Windows.Forms.DataGridView ChooseServicesView1;
        private System.Windows.Forms.Button AddQueryServiceButton;
        private System.Windows.Forms.Label PoZayabkelabel;
        private System.Windows.Forms.Label VseUslugilabel;
        private System.Windows.Forms.Button RemoveQueryServiceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AllServicesPriceBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceQueryAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceQueryAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceServiceQueryAll;
        private System.Windows.Forms.Button SumbitQueryServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceQueryAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceQueryAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceServiceQueryAdd;
    }
}