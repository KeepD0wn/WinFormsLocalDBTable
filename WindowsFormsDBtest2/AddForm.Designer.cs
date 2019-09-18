namespace WindowsFormsDBtest2
{
    partial class AddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dbPhone = new System.Windows.Forms.Label();
            this.dbCity = new System.Windows.Forms.Label();
            this.dbName = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbCity);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.dbPhone);
            this.groupBox1.Controls.Add(this.dbCity);
            this.groupBox1.Controls.Add(this.dbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(98, 114);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(189, 20);
            this.tbPhone.TabIndex = 5;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(98, 72);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(189, 20);
            this.tbCity.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(98, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(189, 20);
            this.tbName.TabIndex = 3;
            // 
            // dbPhone
            // 
            this.dbPhone.AutoSize = true;
            this.dbPhone.Location = new System.Drawing.Point(28, 114);
            this.dbPhone.Name = "dbPhone";
            this.dbPhone.Size = new System.Drawing.Size(52, 13);
            this.dbPhone.TabIndex = 2;
            this.dbPhone.Text = "Телефон";
            // 
            // dbCity
            // 
            this.dbCity.AutoSize = true;
            this.dbCity.Location = new System.Drawing.Point(28, 72);
            this.dbCity.Name = "dbCity";
            this.dbCity.Size = new System.Drawing.Size(37, 13);
            this.dbCity.TabIndex = 1;
            this.dbCity.Text = "Город";
            // 
            // dbName
            // 
            this.dbName.AutoSize = true;
            this.dbName.Location = new System.Drawing.Point(28, 38);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(29, 13);
            this.dbName.TabIndex = 0;
            this.dbName.Text = "Имя";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(43, 330);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(200, 45);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "Добавить";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(341, 329);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(175, 46);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dbName;
        private System.Windows.Forms.Label dbPhone;
        private System.Windows.Forms.Label dbCity;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbName;
    }
}