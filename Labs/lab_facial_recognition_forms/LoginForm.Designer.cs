namespace lab_facial_recognition_forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.debug1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.label5);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Controls.Add(this.debug1);
            this.loginPanel.Controls.Add(this.panel2);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.comboBox1);
            this.loginPanel.Controls.Add(this.passwordTextbox);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.userNameTextBox);
            this.loginPanel.Controls.Add(this.panel1);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Location = new System.Drawing.Point(9, 10);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(578, 346);
            this.loginPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(8, 181);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 1);
            this.panel2.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.Red;
            this.loginButton.Location = new System.Drawing.Point(7, 191);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(91, 27);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.ForeColor = System.Drawing.Color.Red;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(7, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "<User Type>";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.Black;
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.ForeColor = System.Drawing.Color.Red;
            this.passwordTextbox.Location = new System.Drawing.Point(8, 164);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.Size = new System.Drawing.Size(75, 13);
            this.passwordTextbox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.Black;
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.ForeColor = System.Drawing.Color.Red;
            this.userNameTextBox.Location = new System.Drawing.Point(8, 117);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(75, 13);
            this.userNameTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(8, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 1);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(2, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGIN";
            // 
            // debug1
            // 
            this.debug1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.debug1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debug1.ForeColor = System.Drawing.Color.Red;
            this.debug1.Location = new System.Drawing.Point(2, 317);
            this.debug1.Margin = new System.Windows.Forms.Padding(2);
            this.debug1.Name = "debug1";
            this.debug1.Size = new System.Drawing.Size(143, 27);
            this.debug1.TabIndex = 11;
            this.debug1.Text = "DEBUGGER TO FORM1";
            this.debug1.UseVisualStyleBackColor = true;
            this.debug1.Click += new System.EventHandler(this.debug1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 251);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(269, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "T.U.R.D.S.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(179, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "(Tiny User Recognition and Designator System)";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(598, 366);
            this.Controls.Add(this.loginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "TURDS";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button debug1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}