namespace MyVacation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sum_price = new System.Windows.Forms.Button();
            this.Gid = new System.Windows.Forms.CheckBox();
            this.winter = new System.Windows.Forms.RadioButton();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.summer = new System.Windows.Forms.RadioButton();
            this.Country = new System.Windows.Forms.ComboBox();
            this.days = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sum_price
            // 
            this.Sum_price.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum_price.Location = new System.Drawing.Point(415, 298);
            this.Sum_price.Name = "Sum_price";
            this.Sum_price.Size = new System.Drawing.Size(169, 37);
            this.Sum_price.TabIndex = 20;
            this.Sum_price.Text = "Розрахувати";
            this.Sum_price.UseVisualStyleBackColor = true;
            this.Sum_price.Click += new System.EventHandler(this.Sum_price_Click);
            // 
            // Gid
            // 
            this.Gid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Gid.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gid.Location = new System.Drawing.Point(482, 146);
            this.Gid.Name = "Gid";
            this.Gid.Size = new System.Drawing.Size(89, 30);
            this.Gid.TabIndex = 19;
            this.Gid.Text = "Гід";
            this.Gid.UseVisualStyleBackColor = false;
            // 
            // winter
            // 
            this.winter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.winter.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winter.Location = new System.Drawing.Point(482, 110);
            this.winter.Name = "winter";
            this.winter.Size = new System.Drawing.Size(89, 30);
            this.winter.TabIndex = 18;
            this.winter.TabStop = true;
            this.winter.Text = "Зима";
            this.winter.UseVisualStyleBackColor = false;
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalPrice.ForeColor = System.Drawing.Color.Red;
            this.TotalPrice.Location = new System.Drawing.Point(118, 309);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(105, 26);
            this.TotalPrice.TabIndex = 17;
            this.TotalPrice.Text = "none";
            this.TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(41, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Сума :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(476, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сезон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Оберіть країну";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(234, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Відпочинок";
            // 
            // summer
            // 
            this.summer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.summer.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summer.Location = new System.Drawing.Point(482, 74);
            this.summer.Name = "summer";
            this.summer.Size = new System.Drawing.Size(89, 30);
            this.summer.TabIndex = 12;
            this.summer.TabStop = true;
            this.summer.Text = "Літо";
            this.summer.UseVisualStyleBackColor = false;
            // 
            // Country
            // 
            this.Country.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "Болгарія",
            "Німеччина",
            "Польща"});
            this.Country.Location = new System.Drawing.Point(68, 211);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(170, 34);
            this.Country.TabIndex = 11;
            // 
            // days
            // 
            this.days.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days.Location = new System.Drawing.Point(68, 121);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(170, 34);
            this.days.TabIndex = 21;
            this.days.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.days_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 35);
            this.label4.TabIndex = 22;
            this.label4.Text = "Введіть кількість днів";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 362);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.days);
            this.Controls.Add(this.Sum_price);
            this.Controls.Add(this.Gid);
            this.Controls.Add(this.winter);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summer);
            this.Controls.Add(this.Country);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sum_price;
        private System.Windows.Forms.CheckBox Gid;
        private System.Windows.Forms.RadioButton winter;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton summer;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.Label label4;
    }
}

