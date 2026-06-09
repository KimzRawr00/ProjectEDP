namespace ProjectEDP
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelFirstName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelLastName = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelPhoneNumber = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.panelFirstName.SuspendLayout();
            this.panelLastName.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelPhoneNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create account";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.Location = new System.Drawing.Point(368, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelFirstName
            // 
            this.panelFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFirstName.Controls.Add(this.txtName);
            this.panelFirstName.Location = new System.Drawing.Point(22, 69);
            this.panelFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.panelFirstName.Name = "panelFirstName";
            this.panelFirstName.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelFirstName.Size = new System.Drawing.Size(368, 37);
            this.panelFirstName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.Location = new System.Drawing.Point(9, 10);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Your Name";
            // 
            // panelLastName
            // 
            this.panelLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLastName.Controls.Add(this.txtPhone);
            this.panelLastName.Location = new System.Drawing.Point(22, 118);
            this.panelLastName.Margin = new System.Windows.Forms.Padding(2);
            this.panelLastName.Name = "panelLastName";
            this.panelLastName.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelLastName.Size = new System.Drawing.Size(368, 37);
            this.panelLastName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhone.Location = new System.Drawing.Point(9, 10);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(348, 20);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.Text = "Your Phone Number";
            // 
            // panelEmail
            // 
            this.panelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmail.Controls.Add(this.txtEmail);
            this.panelEmail.Location = new System.Drawing.Point(22, 167);
            this.panelEmail.Margin = new System.Windows.Forms.Padding(2);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelEmail.Size = new System.Drawing.Size(368, 37);
            this.panelEmail.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(9, 10);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(348, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "Your Email";
            // 
            // panelPassword
            // 
            this.panelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPassword.Controls.Add(this.textBox4);
            this.panelPassword.Location = new System.Drawing.Point(22, 265);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(2);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelPassword.Size = new System.Drawing.Size(368, 37);
            this.panelPassword.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox4.Location = new System.Drawing.Point(9, 10);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(348, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Confirm Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 323);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(207, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "I agree to receive SMS for verification.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelPhoneNumber
            // 
            this.panelPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhoneNumber.Controls.Add(this.txtPassword);
            this.panelPhoneNumber.Location = new System.Drawing.Point(22, 215);
            this.panelPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.panelPhoneNumber.Name = "panelPhoneNumber";
            this.panelPhoneNumber.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelPhoneNumber.Size = new System.Drawing.Size(368, 37);
            this.panelPhoneNumber.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(9, 10);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(348, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Passowrd";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(22, 355);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(368, 37);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Create";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 422);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelPhoneNumber);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panelLastName);
            this.Controls.Add(this.panelFirstName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelFirstName.ResumeLayout(false);
            this.panelFirstName.PerformLayout();
            this.panelLastName.ResumeLayout(false);
            this.panelLastName.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelPhoneNumber.ResumeLayout(false);
            this.panelPhoneNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelFirstName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panelLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelPhoneNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}