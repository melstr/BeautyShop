namespace Beauty_shop
{
    partial class masterForm
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
            this.signOut = new System.Windows.Forms.LinkLabel();
            this.customersData = new System.Windows.Forms.Button();
            this.signUpCustomer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель мастера";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 52);
            this.panel1.TabIndex = 2;
            // 
            // signOut
            // 
            this.signOut.ActiveLinkColor = System.Drawing.Color.Black;
            this.signOut.AutoSize = true;
            this.signOut.BackColor = System.Drawing.Color.Transparent;
            this.signOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOut.DisabledLinkColor = System.Drawing.Color.Black;
            this.signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signOut.LinkColor = System.Drawing.Color.Black;
            this.signOut.Location = new System.Drawing.Point(342, 474);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(203, 26);
            this.signOut.TabIndex = 14;
            this.signOut.TabStop = true;
            this.signOut.Text = "Выйти из аккаунта";
            this.signOut.VisitedLinkColor = System.Drawing.Color.Black;
            this.signOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signOut_LinkClicked);
            // 
            // customersData
            // 
            this.customersData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.customersData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customersData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.customersData.FlatAppearance.BorderSize = 0;
            this.customersData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customersData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customersData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customersData.Location = new System.Drawing.Point(286, 227);
            this.customersData.Name = "customersData";
            this.customersData.Size = new System.Drawing.Size(316, 75);
            this.customersData.TabIndex = 13;
            this.customersData.Text = "Просмотреть/завершить записи";
            this.customersData.UseVisualStyleBackColor = false;
            this.customersData.Click += new System.EventHandler(this.customersData_Click);
            // 
            // signUpCustomer
            // 
            this.signUpCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.signUpCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.signUpCustomer.FlatAppearance.BorderSize = 0;
            this.signUpCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signUpCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.signUpCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signUpCustomer.Location = new System.Drawing.Point(316, 103);
            this.signUpCustomer.Name = "signUpCustomer";
            this.signUpCustomer.Size = new System.Drawing.Size(246, 75);
            this.signUpCustomer.TabIndex = 12;
            this.signUpCustomer.Text = "Записать на прием";
            this.signUpCustomer.UseVisualStyleBackColor = false;
            this.signUpCustomer.Click += new System.EventHandler(this.signUpCustomer_Click);
            // 
            // masterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.customersData);
            this.Controls.Add(this.signUpCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "masterForm";
            this.Text = "masterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.masterForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel signOut;
        private System.Windows.Forms.Button customersData;
        private System.Windows.Forms.Button signUpCustomer;
    }
}