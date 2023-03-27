namespace Quiz.Teacher_UC
{
    partial class UC_StudentQuiz
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_StudentQuiz));
            this.comboQuestion = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.comboSet = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtQuestion = new Guna.UI.WinForms.GunaTextBox();
            this.lblQuestion = new Guna.UI.WinForms.GunaLabel();
            this.txtAnswer = new Guna.UI.WinForms.GunaTextBox();
            this.lblAnswer = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnOption4 = new Guna.UI.WinForms.GunaButton();
            this.btnOption3 = new Guna.UI.WinForms.GunaButton();
            this.btnOption2 = new Guna.UI.WinForms.GunaButton();
            this.btnOption1 = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // comboQuestion
            // 
            this.comboQuestion.BackColor = System.Drawing.Color.Transparent;
            this.comboQuestion.BaseColor = System.Drawing.Color.White;
            this.comboQuestion.BorderColor = System.Drawing.Color.Black;
            this.comboQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuestion.FocusedColor = System.Drawing.Color.Empty;
            this.comboQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboQuestion.ForeColor = System.Drawing.Color.Black;
            this.comboQuestion.FormattingEnabled = true;
            this.comboQuestion.Location = new System.Drawing.Point(652, 214);
            this.comboQuestion.Name = "comboQuestion";
            this.comboQuestion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboQuestion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboQuestion.Size = new System.Drawing.Size(340, 35);
            this.comboQuestion.TabIndex = 8;
            this.comboQuestion.SelectedIndexChanged += new System.EventHandler(this.comboQuestion_SelectedIndexChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(647, 170);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(123, 28);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Question No";
            // 
            // comboSet
            // 
            this.comboSet.BackColor = System.Drawing.Color.Transparent;
            this.comboSet.BaseColor = System.Drawing.Color.White;
            this.comboSet.BorderColor = System.Drawing.Color.Black;
            this.comboSet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSet.FocusedColor = System.Drawing.Color.Empty;
            this.comboSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSet.ForeColor = System.Drawing.Color.Black;
            this.comboSet.FormattingEnabled = true;
            this.comboSet.Location = new System.Drawing.Point(205, 214);
            this.comboSet.Name = "comboSet";
            this.comboSet.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboSet.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboSet.Size = new System.Drawing.Size(340, 35);
            this.comboSet.TabIndex = 6;
            this.comboSet.SelectedIndexChanged += new System.EventHandler(this.comboSet_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(200, 170);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 28);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Set";
            // 
            // txtQuestion
            // 
            this.txtQuestion.BaseColor = System.Drawing.SystemColors.HotTrack;
            this.txtQuestion.BorderColor = System.Drawing.Color.Transparent;
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuestion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuestion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(36, 322);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.Size = new System.Drawing.Size(1115, 50);
            this.txtQuestion.TabIndex = 11;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(31, 291);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(91, 28);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Question";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BaseColor = System.Drawing.Color.White;
            this.txtAnswer.BorderColor = System.Drawing.Color.Black;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAnswer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAnswer.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(47, 722);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.Size = new System.Drawing.Size(1104, 50);
            this.txtAnswer.TabIndex = 18;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(42, 690);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(75, 28);
            this.lblAnswer.TabIndex = 17;
            this.lblAnswer.Text = "Answer";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(198, 56);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(766, 41);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Quiz: Get to Know Visual Studio – Test your knowledge";
            // 
            // btnOption4
            // 
            this.btnOption4.AnimationHoverSpeed = 0.07F;
            this.btnOption4.AnimationSpeed = 0.03F;
            this.btnOption4.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnOption4.BorderColor = System.Drawing.Color.Blue;
            this.btnOption4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOption4.FocusedColor = System.Drawing.Color.Empty;
            this.btnOption4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.ForeColor = System.Drawing.Color.White;
            this.btnOption4.Image = null;
            this.btnOption4.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOption4.Location = new System.Drawing.Point(36, 625);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOption4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOption4.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOption4.OnHoverImage = null;
            this.btnOption4.OnPressedColor = System.Drawing.Color.Black;
            this.btnOption4.Size = new System.Drawing.Size(1115, 50);
            this.btnOption4.TabIndex = 14;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.AnimationHoverSpeed = 0.07F;
            this.btnOption3.AnimationSpeed = 0.03F;
            this.btnOption3.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnOption3.BorderColor = System.Drawing.Color.Blue;
            this.btnOption3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOption3.FocusedColor = System.Drawing.Color.Empty;
            this.btnOption3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.ForeColor = System.Drawing.Color.White;
            this.btnOption3.Image = null;
            this.btnOption3.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOption3.Location = new System.Drawing.Point(36, 549);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOption3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOption3.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOption3.OnHoverImage = null;
            this.btnOption3.OnPressedColor = System.Drawing.Color.Black;
            this.btnOption3.Size = new System.Drawing.Size(1115, 50);
            this.btnOption3.TabIndex = 13;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.AnimationHoverSpeed = 0.07F;
            this.btnOption2.AnimationSpeed = 0.03F;
            this.btnOption2.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnOption2.BorderColor = System.Drawing.Color.Blue;
            this.btnOption2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOption2.FocusedColor = System.Drawing.Color.Empty;
            this.btnOption2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.ForeColor = System.Drawing.Color.White;
            this.btnOption2.Image = null;
            this.btnOption2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOption2.Location = new System.Drawing.Point(36, 477);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOption2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOption2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOption2.OnHoverImage = null;
            this.btnOption2.OnPressedColor = System.Drawing.Color.Black;
            this.btnOption2.Size = new System.Drawing.Size(1115, 50);
            this.btnOption2.TabIndex = 12;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption1
            // 
            this.btnOption1.AnimationHoverSpeed = 0.07F;
            this.btnOption1.AnimationSpeed = 0.03F;
            this.btnOption1.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnOption1.BorderColor = System.Drawing.Color.Blue;
            this.btnOption1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOption1.FocusedColor = System.Drawing.Color.Empty;
            this.btnOption1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.ForeColor = System.Drawing.Color.White;
            this.btnOption1.Image = null;
            this.btnOption1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOption1.Location = new System.Drawing.Point(36, 406);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOption1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOption1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOption1.OnHoverImage = null;
            this.btnOption1.OnPressedColor = System.Drawing.Color.Black;
            this.btnOption1.Size = new System.Drawing.Size(1115, 50);
            this.btnOption1.TabIndex = 9;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
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
            this.btnExit.Location = new System.Drawing.Point(1126, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(55, 50);
            this.btnExit.TabIndex = 20;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UC_StudentQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.comboQuestion);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.comboSet);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "UC_StudentQuiz";
            this.Size = new System.Drawing.Size(1184, 945);
            this.Load += new System.EventHandler(this.UC_StudentQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox comboQuestion;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox comboSet;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnOption1;
        private Guna.UI.WinForms.GunaTextBox txtQuestion;
        private Guna.UI.WinForms.GunaLabel lblQuestion;
        private Guna.UI.WinForms.GunaButton btnOption2;
        private Guna.UI.WinForms.GunaButton btnOption3;
        private Guna.UI.WinForms.GunaButton btnOption4;
        private Guna.UI.WinForms.GunaTextBox txtAnswer;
        private Guna.UI.WinForms.GunaLabel lblAnswer;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}
