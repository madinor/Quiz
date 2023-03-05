namespace Quiz
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnUpdateQuestion = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddNewQuestion = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.uC_ViewDelete1 = new Quiz.Teacher_UC.UC_ViewDelete();
            this.uc_UpdateQuestion1 = new Quiz.Teacher_UC.Uc_UpdateQuestion();
            this.uC_Addnewquestion1 = new Quiz.Teacher_UC.UC_Addnewquestion();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Quiz.Properties.Resources.q5;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.uC_ViewDelete1);
            this.panel2.Controls.Add(this.uc_UpdateQuestion1);
            this.panel2.Controls.Add(this.uC_Addnewquestion1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(367, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 945);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::Quiz.Properties.Resources.Close_all_form;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1127, -13);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(53, 67);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Quiz.Properties.Resources.q5;
            this.panel1.Controls.Add(this.gunaAdvenceButton1);
            this.panel1.Controls.Add(this.btnViewDelete);
            this.panel1.Controls.Add(this.gunaAdvenceButton4);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaAdvenceButton3);
            this.panel1.Controls.Add(this.gunaPictureBox2);
            this.panel1.Controls.Add(this.btnUpdateQuestion);
            this.panel1.Controls.Add(this.btnAddNewQuestion);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 945);
            this.panel1.TabIndex = 0;
            // 
            // btnViewDelete
            // 
            this.btnViewDelete.AnimationHoverSpeed = 0.07F;
            this.btnViewDelete.AnimationSpeed = 0.03F;
            this.btnViewDelete.BaseColor = System.Drawing.Color.Indigo;
            this.btnViewDelete.BorderColor = System.Drawing.Color.Black;
            this.btnViewDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnViewDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnViewDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnViewDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnViewDelete.CheckedImage")));
            this.btnViewDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnViewDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDelete.ForeColor = System.Drawing.Color.White;
            this.btnViewDelete.Image = global::Quiz.Properties.Resources.eye1;
            this.btnViewDelete.ImageSize = new System.Drawing.Size(35, 35);
            this.btnViewDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewDelete.Location = new System.Drawing.Point(22, 454);
            this.btnViewDelete.Name = "btnViewDelete";
            this.btnViewDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnViewDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnViewDelete.OnHoverImage = null;
            this.btnViewDelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnViewDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewDelete.Size = new System.Drawing.Size(308, 42);
            this.btnViewDelete.TabIndex = 12;
            this.btnViewDelete.Text = "View & Delete Questions";
            this.btnViewDelete.Click += new System.EventHandler(this.btnViewDelete_Click);
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.Indigo;
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.CheckedImage")));
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.Image = global::Quiz.Properties.Resources.target_arrow;
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(22, 502);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(308, 42);
            this.gunaAdvenceButton4.TabIndex = 11;
            this.gunaAdvenceButton4.Text = "Students Result";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(105, 268);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(116, 38);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Teacher";
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.Indigo;
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = global::Quiz.Properties.Resources.power_button;
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(22, 561);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(308, 42);
            this.gunaAdvenceButton3.TabIndex = 10;
            this.gunaAdvenceButton3.Text = "Logout";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::Quiz.Properties.Resources.admin1;
            this.gunaPictureBox2.Location = new System.Drawing.Point(22, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(284, 277);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 0;
            this.gunaPictureBox2.TabStop = false;
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.AnimationHoverSpeed = 0.07F;
            this.btnUpdateQuestion.AnimationSpeed = 0.03F;
            this.btnUpdateQuestion.BaseColor = System.Drawing.Color.Indigo;
            this.btnUpdateQuestion.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUpdateQuestion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateQuestion.CheckedImage")));
            this.btnUpdateQuestion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdateQuestion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateQuestion.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuestion.ForeColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateQuestion.Image")));
            this.btnUpdateQuestion.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUpdateQuestion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdateQuestion.Location = new System.Drawing.Point(22, 385);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdateQuestion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.OnHoverImage = null;
            this.btnUpdateQuestion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdateQuestion.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.Size = new System.Drawing.Size(308, 42);
            this.btnUpdateQuestion.TabIndex = 9;
            this.btnUpdateQuestion.Text = "Update Question";
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.AnimationHoverSpeed = 0.07F;
            this.btnAddNewQuestion.AnimationSpeed = 0.03F;
            this.btnAddNewQuestion.BaseColor = System.Drawing.Color.Indigo;
            this.btnAddNewQuestion.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddNewQuestion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewQuestion.CheckedImage")));
            this.btnAddNewQuestion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddNewQuestion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewQuestion.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.Image = global::Quiz.Properties.Resources.add_user;
            this.btnAddNewQuestion.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewQuestion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddNewQuestion.Location = new System.Drawing.Point(22, 322);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddNewQuestion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.OnHoverImage = null;
            this.btnAddNewQuestion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddNewQuestion.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.Size = new System.Drawing.Size(308, 42);
            this.btnAddNewQuestion.TabIndex = 8;
            this.btnAddNewQuestion.Text = "Add New Question";
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddNewQuestion_Click);
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.panel2;
            // 
            // uC_ViewDelete1
            // 
            this.uC_ViewDelete1.BackColor = System.Drawing.Color.White;
            this.uC_ViewDelete1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewDelete1.Name = "uC_ViewDelete1";
            this.uC_ViewDelete1.Size = new System.Drawing.Size(1184, 945);
            this.uC_ViewDelete1.TabIndex = 3;
            // 
            // uc_UpdateQuestion1
            // 
            this.uc_UpdateQuestion1.BackColor = System.Drawing.Color.White;
            this.uc_UpdateQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uc_UpdateQuestion1.Name = "uc_UpdateQuestion1";
            this.uc_UpdateQuestion1.Size = new System.Drawing.Size(1184, 945);
            this.uc_UpdateQuestion1.TabIndex = 2;
            // 
            // uC_Addnewquestion1
            // 
            this.uC_Addnewquestion1.BackColor = System.Drawing.Color.White;
            this.uC_Addnewquestion1.Location = new System.Drawing.Point(0, 0);
            this.uC_Addnewquestion1.Name = "uC_Addnewquestion1";
            this.uC_Addnewquestion1.Size = new System.Drawing.Size(1184, 945);
            this.uC_Addnewquestion1.TabIndex = 1;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Indigo;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::Quiz.Properties.Resources.power_button;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(22, 619);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(308, 42);
            this.gunaAdvenceButton1.TabIndex = 13;
            this.gunaAdvenceButton1.Text = "Exit";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 945);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddNewQuestion;
        private Guna.UI.WinForms.GunaAdvenceButton btnViewDelete;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdateQuestion;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Teacher_UC.UC_Addnewquestion uC_Addnewquestion1;
        private Teacher_UC.Uc_UpdateQuestion uc_UpdateQuestion1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Teacher_UC.UC_ViewDelete uC_ViewDelete1;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}