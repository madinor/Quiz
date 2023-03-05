namespace Quiz
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.comboSelectUser = new Guna.UI.WinForms.GunaComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxShowHide = new Guna.UI.WinForms.GunaCheckBox();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.txtPassWord = new Guna.UI.WinForms.GunaTextBox();
            this.txtUserName = new Guna.UI.WinForms.GunaTextBox();
            this.lblWrong = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnStudentRegister = new Guna.UI.WinForms.GunaButton();
            this.btnStudentLogin = new Guna.UI.WinForms.GunaButton();
            this.txtStudentNumber = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(928, 73);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(420, 62);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Quiz Management";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(1047, 171);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(208, 58);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Select User";
            // 
            // comboSelectUser
            // 
            this.comboSelectUser.BackColor = System.Drawing.Color.Transparent;
            this.comboSelectUser.BaseColor = System.Drawing.Color.White;
            this.comboSelectUser.BorderColor = System.Drawing.Color.Silver;
            this.comboSelectUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSelectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectUser.FocusedColor = System.Drawing.Color.Empty;
            this.comboSelectUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboSelectUser.ForeColor = System.Drawing.Color.Black;
            this.comboSelectUser.FormattingEnabled = true;
            this.comboSelectUser.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.comboSelectUser.Location = new System.Drawing.Point(898, 225);
            this.comboSelectUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSelectUser.Name = "comboSelectUser";
            this.comboSelectUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboSelectUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboSelectUser.Size = new System.Drawing.Size(482, 35);
            this.comboSelectUser.TabIndex = 2;
            this.comboSelectUser.SelectedIndexChanged += new System.EventHandler(this.comboSelectUser_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxShowHide);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassWord);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblWrong);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Location = new System.Drawing.Point(898, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 544);
            this.panel1.TabIndex = 5;
            // 
            // checkBoxShowHide
            // 
            this.checkBoxShowHide.BaseColor = System.Drawing.Color.White;
            this.checkBoxShowHide.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxShowHide.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxShowHide.FillColor = System.Drawing.Color.White;
            this.checkBoxShowHide.Location = new System.Drawing.Point(186, 366);
            this.checkBoxShowHide.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShowHide.Name = "checkBoxShowHide";
            this.checkBoxShowHide.Size = new System.Drawing.Size(126, 20);
            this.checkBoxShowHide.TabIndex = 7;
            this.checkBoxShowHide.Text = "Show Password";
            this.checkBoxShowHide.CheckedChanged += new System.EventHandler(this.checkBoxShowHide_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.BorderSize = 1;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(13, 416);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Radius = 20;
            this.btnLogin.Size = new System.Drawing.Size(457, 44);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = " Login";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BaseColor = System.Drawing.Color.White;
            this.txtPassWord.BorderColor = System.Drawing.Color.Silver;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassWord.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassWord.FocusedForeColor = System.Drawing.Color.Black;
            this.txtPassWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(14, 294);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(457, 46);
            this.txtPassWord.TabIndex = 5;
            this.txtPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.BaseColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedForeColor = System.Drawing.Color.Black;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(14, 162);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(457, 46);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.Red;
            this.lblWrong.Location = new System.Drawing.Point(113, 489);
            this.lblWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(256, 23);
            this.lblWrong.TabIndex = 3;
            this.lblWrong.Text = "Wrong User Name \"OR\" Password";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(186, 258);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(93, 28);
            this.gunaLabel5.TabIndex = 2;
            this.gunaLabel5.Text = "Password";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(186, 130);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(108, 28);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "User Name";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(208, 34);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(143, 28);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Teacher Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnStudentRegister);
            this.panel2.Controls.Add(this.btnStudentLogin);
            this.panel2.Controls.Add(this.txtStudentNumber);
            this.panel2.Controls.Add(this.gunaLabel8);
            this.panel2.Controls.Add(this.gunaLabel9);
            this.panel2.Location = new System.Drawing.Point(244, 209);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 544);
            this.panel2.TabIndex = 8;
            // 
            // BtnStudentRegister
            // 
            this.BtnStudentRegister.AnimationHoverSpeed = 0.07F;
            this.BtnStudentRegister.AnimationSpeed = 0.03F;
            this.BtnStudentRegister.BackColor = System.Drawing.Color.Transparent;
            this.BtnStudentRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnStudentRegister.BorderColor = System.Drawing.Color.Black;
            this.BtnStudentRegister.BorderSize = 1;
            this.BtnStudentRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnStudentRegister.FocusedColor = System.Drawing.Color.Empty;
            this.BtnStudentRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentRegister.ForeColor = System.Drawing.Color.White;
            this.BtnStudentRegister.Image = null;
            this.BtnStudentRegister.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnStudentRegister.Location = new System.Drawing.Point(32, 416);
            this.BtnStudentRegister.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStudentRegister.Name = "BtnStudentRegister";
            this.BtnStudentRegister.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnStudentRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnStudentRegister.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnStudentRegister.OnHoverImage = null;
            this.BtnStudentRegister.OnPressedColor = System.Drawing.Color.Black;
            this.BtnStudentRegister.Radius = 20;
            this.BtnStudentRegister.Size = new System.Drawing.Size(457, 44);
            this.BtnStudentRegister.TabIndex = 7;
            this.BtnStudentRegister.Text = "Register";
            this.BtnStudentRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.AnimationHoverSpeed = 0.07F;
            this.btnStudentLogin.AnimationSpeed = 0.03F;
            this.btnStudentLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnStudentLogin.BorderColor = System.Drawing.Color.Black;
            this.btnStudentLogin.BorderSize = 1;
            this.btnStudentLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStudentLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnStudentLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.ForeColor = System.Drawing.Color.White;
            this.btnStudentLogin.Image = null;
            this.btnStudentLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStudentLogin.Location = new System.Drawing.Point(36, 325);
            this.btnStudentLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnStudentLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStudentLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStudentLogin.OnHoverImage = null;
            this.btnStudentLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnStudentLogin.Radius = 20;
            this.btnStudentLogin.Size = new System.Drawing.Size(457, 44);
            this.btnStudentLogin.TabIndex = 6;
            this.btnStudentLogin.Text = " Login";
            this.btnStudentLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.BaseColor = System.Drawing.Color.White;
            this.txtStudentNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtStudentNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStudentNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtStudentNumber.FocusedForeColor = System.Drawing.Color.Black;
            this.txtStudentNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNumber.Location = new System.Drawing.Point(36, 214);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.SelectedText = "";
            this.txtStudentNumber.Size = new System.Drawing.Size(457, 46);
            this.txtStudentNumber.TabIndex = 4;
            this.txtStudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(185, 182);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(157, 28);
            this.gunaLabel8.TabIndex = 1;
            this.gunaLabel8.Text = "Student Number";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(208, 34);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(144, 28);
            this.gunaLabel9.TabIndex = 0;
            this.gunaLabel9.Text = "Student Login";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.ErrorImage = null;
            this.gunaPictureBox1.Image = global::Quiz.Properties.Resources.Code_Kentucky_Celebrates;
            this.gunaPictureBox1.InitialImage = null;
            this.gunaPictureBox1.Location = new System.Drawing.Point(1, -2);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(708, 946);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.Empty;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1500, -2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(55, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 945);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboSelectUser);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaComboBox comboSelectUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnLogin;
        private Guna.UI.WinForms.GunaTextBox txtPassWord;
        private Guna.UI.WinForms.GunaTextBox txtUserName;
        private Guna.UI.WinForms.GunaLabel lblWrong;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaCheckBox checkBoxShowHide;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnStudentLogin;
        private Guna.UI.WinForms.GunaTextBox txtStudentNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaButton BtnStudentRegister;
    }
}

