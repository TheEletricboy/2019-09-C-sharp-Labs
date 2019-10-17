namespace lab_facial_recognition_forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.start = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentUserListBox = new System.Windows.Forms.ListBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.displayDataButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textboxDelete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.exportToExcel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(91, 80);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(334, 226);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            this.cameraBox.Click += new System.EventHandler(this.cameraBox_Click);
            // 
            // start
            // 
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.Color.Red;
            this.start.Location = new System.Drawing.Point(59, 318);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(109, 45);
            this.start.TabIndex = 3;
            this.start.Text = "Start Detection and Recognition";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.Red;
            this.saveButton.Location = new System.Drawing.Point(536, 142);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 29);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Face";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.Black;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textName.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.ForeColor = System.Drawing.Color.Red;
            this.textName.Location = new System.Drawing.Point(535, 104);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(108, 14);
            this.textName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(532, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // userButton
            // 
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.ForeColor = System.Drawing.Color.Red;
            this.userButton.Location = new System.Drawing.Point(536, 176);
            this.userButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(109, 46);
            this.userButton.TabIndex = 8;
            this.userButton.Text = "userButton";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(53, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "T.U.R.D.S.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(525, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "REGISTER NEW FACE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(523, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "CONTROLS.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(225, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "(Tiny User Recognition and Designator System)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(533, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Current User in frame: ";
            // 
            // currentUserListBox
            // 
            this.currentUserListBox.BackColor = System.Drawing.Color.Black;
            this.currentUserListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUserListBox.ForeColor = System.Drawing.Color.Red;
            this.currentUserListBox.FormattingEnabled = true;
            this.currentUserListBox.Location = new System.Drawing.Point(535, 275);
            this.currentUserListBox.Name = "currentUserListBox";
            this.currentUserListBox.Size = new System.Drawing.Size(206, 104);
            this.currentUserListBox.TabIndex = 14;
            this.currentUserListBox.SelectedIndexChanged += new System.EventHandler(this.currentUserListBox_SelectedIndexChanged);
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.ForestGreen;
            this.logInButton.FlatAppearance.BorderSize = 0;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Location = new System.Drawing.Point(529, 589);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(109, 54);
            this.logInButton.TabIndex = 15;
            this.logInButton.Text = "LOG INTO BUILDING";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(523, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 39);
            this.label8.TabIndex = 16;
            this.label8.Text = "LOGIN";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(53, 401);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.Size = new System.Drawing.Size(405, 203);
            this.dgv1.TabIndex = 17;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // displayDataButton
            // 
            this.displayDataButton.BackColor = System.Drawing.Color.Turquoise;
            this.displayDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayDataButton.Location = new System.Drawing.Point(349, 611);
            this.displayDataButton.Name = "displayDataButton";
            this.displayDataButton.Size = new System.Drawing.Size(109, 32);
            this.displayDataButton.TabIndex = 18;
            this.displayDataButton.Text = "Display  All Data";
            this.displayDataButton.UseVisualStyleBackColor = false;
            this.displayDataButton.Click += new System.EventHandler(this.displayDataButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(52, 655);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 26);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // textboxDelete
            // 
            this.textboxDelete.BackColor = System.Drawing.Color.Black;
            this.textboxDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxDelete.ForeColor = System.Drawing.Color.Red;
            this.textboxDelete.Location = new System.Drawing.Point(53, 630);
            this.textboxDelete.Name = "textboxDelete";
            this.textboxDelete.Size = new System.Drawing.Size(168, 13);
            this.textboxDelete.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(50, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Delete User Log-on (Username)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(59, 312);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 1);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(529, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 302);
            this.panel2.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(529, 385);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 1);
            this.panel4.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(747, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 302);
            this.panel3.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(529, 83);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 1);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(535, 124);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(107, 1);
            this.panel6.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Location = new System.Drawing.Point(53, 649);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(154, 1);
            this.panel7.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Location = new System.Drawing.Point(529, 45);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(219, 1);
            this.panel8.TabIndex = 24;
            // 
            // exportToExcel
            // 
            this.exportToExcel.BackColor = System.Drawing.Color.Chartreuse;
            this.exportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportToExcel.Location = new System.Drawing.Point(529, 390);
            this.exportToExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.Size = new System.Drawing.Size(72, 36);
            this.exportToExcel.TabIndex = 26;
            this.exportToExcel.Text = "EXPORT TO EXCEL";
            this.exportToExcel.UseVisualStyleBackColor = false;
            this.exportToExcel.Click += new System.EventHandler(this.exportToExcel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(47, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 39);
            this.label9.TabIndex = 27;
            this.label9.Text = "Database Log-on.";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Red;
            this.panel9.Location = new System.Drawing.Point(59, 43);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(428, 1);
            this.panel9.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 28;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.exportToExcel);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxDelete);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.displayDataButton);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.currentUserListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.start);
            this.Controls.Add(this.cameraBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox currentUserListBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button displayDataButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textboxDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button exportToExcel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;
    }
}

