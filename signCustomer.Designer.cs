namespace Beauty_shop
{
    partial class signCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mastersList = new System.Windows.Forms.ListBox();
            this.signInCustomer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Записать клиента";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 52);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mastersList
            // 
            this.mastersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersList.FormattingEnabled = true;
            this.mastersList.ItemHeight = 37;
            this.mastersList.Location = new System.Drawing.Point(449, 381);
            this.mastersList.Name = "mastersList";
            this.mastersList.Size = new System.Drawing.Size(303, 41);
            this.mastersList.TabIndex = 24;
            this.mastersList.SelectedIndexChanged += new System.EventHandler(this.masterList_SelectedIndexChanged);
            // 
            // signInCustomer
            // 
            this.signInCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.signInCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.signInCustomer.FlatAppearance.BorderSize = 0;
            this.signInCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signInCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.signInCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signInCustomer.Location = new System.Drawing.Point(561, 453);
            this.signInCustomer.Name = "signInCustomer";
            this.signInCustomer.Size = new System.Drawing.Size(191, 42);
            this.signInCustomer.TabIndex = 23;
            this.signInCustomer.Text = "Записать";
            this.signInCustomer.UseVisualStyleBackColor = false;
            this.signInCustomer.Click += new System.EventHandler(this.signInCustomer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(309, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(509, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "Введите данные о новом пользователе";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(129, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Выберете имя мастера:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Выберете время начала приема:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(208, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Выберете дату:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Введите имя клиента:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerName.Location = new System.Drawing.Point(449, 127);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(303, 44);
            this.customerName.TabIndex = 15;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(29, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(414, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "Выберете время конца приема:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // timeEnd
            // 
            this.timeEnd.CustomFormat = "HH:mm";
            this.timeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeEnd.Location = new System.Drawing.Point(449, 321);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(97, 38);
            this.timeEnd.TabIndex = 29;
            this.timeEnd.Value = new System.DateTime(2020, 7, 11, 0, 0, 0, 0);
            this.timeEnd.ValueChanged += new System.EventHandler(this.timeEnd_ValueChanged);
            // 
            // timeStart
            // 
            this.timeStart.CustomFormat = "HH:mm";
            this.timeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStart.Location = new System.Drawing.Point(449, 264);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(97, 38);
            this.timeStart.TabIndex = 30;
            this.timeStart.Value = new System.DateTime(2020, 7, 11, 0, 0, 0, 0);
            this.timeStart.ValueChanged += new System.EventHandler(this.timeStart_ValueChanged);
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(449, 198);
            this.dateStart.Name = "dateStart";
            this.dateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateStart.Size = new System.Drawing.Size(200, 38);
            this.dateStart.TabIndex = 31;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // signCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(950, 566);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mastersList);
            this.Controls.Add(this.signInCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.panel1);
            this.Name = "signCustomer";
            this.Text = "signCustomer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.signCustomer_FormClosed);
            this.Load += new System.EventHandler(this.signCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox mastersList;
        private System.Windows.Forms.Button signInCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.DateTimePicker dateStart;
    }
}