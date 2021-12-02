namespace AutoServiceStation
{
    partial class AllModelCarsForm
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
            this.AllCarModelsView = new System.Windows.Forms.DataGridView();
            this.ModelCarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.NewModelCarBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarModelsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AllCarModelsView
            // 
            this.AllCarModelsView.AllowUserToAddRows = false;
            this.AllCarModelsView.AllowUserToDeleteRows = false;
            this.AllCarModelsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCarModelsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelCarName});
            this.AllCarModelsView.Location = new System.Drawing.Point(93, 45);
            this.AllCarModelsView.Name = "AllCarModelsView";
            this.AllCarModelsView.ReadOnly = true;
            this.AllCarModelsView.Size = new System.Drawing.Size(162, 260);
            this.AllCarModelsView.TabIndex = 2;
            // 
            // ModelCarName
            // 
            this.ModelCarName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModelCarName.HeaderText = "Марки авто";
            this.ModelCarName.Name = "ModelCarName";
            this.ModelCarName.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewModelCarBox
            // 
            this.NewModelCarBox.Location = new System.Drawing.Point(12, 343);
            this.NewModelCarBox.Name = "NewModelCarBox";
            this.NewModelCarBox.Size = new System.Drawing.Size(161, 20);
            this.NewModelCarBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Новая марка:";
            // 
            // AllModelCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewModelCarBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllCarModelsView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AllModelCarsForm";
            this.Text = "Марки авто";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllModelCarsForm_FormClosing);
            this.Load += new System.EventHandler(this.AllModelCarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllCarModelsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView AllCarModelsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelCarName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NewModelCarBox;
        private System.Windows.Forms.Label label2;
    }
}