namespace DB_MANAGER
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnDetach = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblDbName = new System.Windows.Forms.Label();
            this.txtCpassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCpassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pnlButtons);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.pnlLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 129);
            this.panel1.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnSetup);
            this.pnlButtons.Controls.Add(this.btnDetach);
            this.pnlButtons.Controls.Add(this.btnAttach);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 83);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(553, 46);
            this.pnlButtons.TabIndex = 3;
            this.pnlButtons.Visible = false;
            // 
            // btnSetup
            // 
            this.btnSetup.Enabled = false;
            this.btnSetup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnSetup.Image")));
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(418, 3);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSetup.Size = new System.Drawing.Size(125, 40);
            this.btnSetup.TabIndex = 7;
            this.btnSetup.Text = "SETUP";
            this.btnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetup.UseMnemonic = false;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnDetach
            // 
            this.btnDetach.Enabled = false;
            this.btnDetach.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetach.Image = ((System.Drawing.Image)(resources.GetObject("btnDetach.Image")));
            this.btnDetach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetach.Location = new System.Drawing.Point(211, 3);
            this.btnDetach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnDetach.Size = new System.Drawing.Size(142, 40);
            this.btnDetach.TabIndex = 6;
            this.btnDetach.Text = "DETACH";
            this.btnDetach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetach.UseVisualStyleBackColor = true;
            this.btnDetach.Click += new System.EventHandler(this.btnDetach_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAttach.Enabled = false;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttach.Location = new System.Drawing.Point(8, 3);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAttach.Size = new System.Drawing.Size(141, 40);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.Text = "ATTACH";
            this.btnAttach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(5, 86);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(46, 18);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "label1";
            this.lblInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLogin.Controls.Add(this.txtServer);
            this.pnlLogin.Controls.Add(this.lblServer);
            this.pnlLogin.Controls.Add(this.lblInfo2);
            this.pnlLogin.Controls.Add(this.txtDbName);
            this.pnlLogin.Controls.Add(this.btnRegister);
            this.pnlLogin.Controls.Add(this.lblDbName);
            this.pnlLogin.Controls.Add(this.txtCpassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblCpassword);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(553, 83);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(7, 47);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(44, 16);
            this.lblInfo2.TabIndex = 7;
            this.lblInfo2.Text = "label1";
            this.lblInfo2.Visible = false;
            // 
            // txtDbName
            // 
            this.txtDbName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDbName.Location = new System.Drawing.Point(316, 46);
            this.txtDbName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(139, 27);
            this.txtDbName.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(463, 9);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(83, 27);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbName.Location = new System.Drawing.Point(239, 48);
            this.lblDbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(74, 20);
            this.lblDbName.TabIndex = 5;
            this.lblDbName.Text = "DB Name";
            // 
            // txtCpassword
            // 
            this.txtCpassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpassword.Location = new System.Drawing.Point(140, 46);
            this.txtCpassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCpassword.MaxLength = 8;
            this.txtCpassword.Name = "txtCpassword";
            this.txtCpassword.PasswordChar = '*';
            this.txtCpassword.Size = new System.Drawing.Size(99, 27);
            this.txtCpassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(140, 8);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(99, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // lblCpassword
            // 
            this.lblCpassword.AutoSize = true;
            this.lblCpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpassword.Location = new System.Drawing.Point(4, 46);
            this.lblCpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpassword.Name = "lblCpassword";
            this.lblCpassword.Size = new System.Drawing.Size(132, 20);
            this.lblCpassword.TabIndex = 1;
            this.lblCpassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(4, 10);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(243, 11);
            this.lblServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(61, 20);
            this.lblServer.TabIndex = 8;
            this.lblServer.Text = "SERVER";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(316, 10);
            this.txtServer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(139, 27);
            this.txtServer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 129);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB MANAGER 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCpassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtCpassword;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnDetach;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
    }
}

