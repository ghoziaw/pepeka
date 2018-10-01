namespace database
{
    partial class LoginRegis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegis));
            this.loginBtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwrd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.regCancelBtn = new System.Windows.Forms.Button();
            this.regPasswrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regRegBtn = new System.Windows.Forms.Button();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.regName = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(167, 88);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(3, 23);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(239, 20);
            this.username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwrd
            // 
            this.passwrd.Location = new System.Drawing.Point(3, 62);
            this.passwrd.Name = "passwrd";
            this.passwrd.Size = new System.Drawing.Size(239, 20);
            this.passwrd.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.regisBtn);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.passwrd);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 183);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.regCancelBtn);
            this.panel2.Controls.Add(this.regPasswrd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.regRegBtn);
            this.panel2.Controls.Add(this.regUsername);
            this.panel2.Controls.Add(this.regName);
            this.panel2.Controls.Add(this.lab);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 180);
            this.panel2.TabIndex = 7;
            // 
            // regCancelBtn
            // 
            this.regCancelBtn.Location = new System.Drawing.Point(167, 154);
            this.regCancelBtn.Name = "regCancelBtn";
            this.regCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.regCancelBtn.TabIndex = 8;
            this.regCancelBtn.Text = "Cancel";
            this.regCancelBtn.UseVisualStyleBackColor = true;
            this.regCancelBtn.Click += new System.EventHandler(this.regCancelBtn_Click);
            // 
            // regPasswrd
            // 
            this.regPasswrd.Location = new System.Drawing.Point(3, 99);
            this.regPasswrd.Name = "regPasswrd";
            this.regPasswrd.Size = new System.Drawing.Size(239, 20);
            this.regPasswrd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // regRegBtn
            // 
            this.regRegBtn.Location = new System.Drawing.Point(167, 125);
            this.regRegBtn.Name = "regRegBtn";
            this.regRegBtn.Size = new System.Drawing.Size(75, 23);
            this.regRegBtn.TabIndex = 5;
            this.regRegBtn.Text = "Register";
            this.regRegBtn.UseVisualStyleBackColor = true;
            this.regRegBtn.Click += new System.EventHandler(this.regRegBtn_Click);
            // 
            // regUsername
            // 
            this.regUsername.Location = new System.Drawing.Point(3, 62);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(239, 20);
            this.regUsername.TabIndex = 4;
            // 
            // regName
            // 
            this.regName.Location = new System.Drawing.Point(3, 23);
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(239, 20);
            this.regName.TabIndex = 1;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(7, 46);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(55, 13);
            this.lab.TabIndex = 3;
            this.lab.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New admin?";
            // 
            // regisBtn
            // 
            this.regisBtn.Location = new System.Drawing.Point(167, 117);
            this.regisBtn.Name = "regisBtn";
            this.regisBtn.Size = new System.Drawing.Size(75, 23);
            this.regisBtn.TabIndex = 5;
            this.regisBtn.Text = "Register";
            this.regisBtn.UseVisualStyleBackColor = true;
            this.regisBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.regisBtn_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwrd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button regisBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox regPasswrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button regRegBtn;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.TextBox regName;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button regCancelBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

