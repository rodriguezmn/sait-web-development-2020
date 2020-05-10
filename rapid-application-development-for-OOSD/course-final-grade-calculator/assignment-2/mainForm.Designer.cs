namespace assignment_2
{
    partial class mainForm
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
            this.resetQuizzMarksButton = new System.Windows.Forms.Button();
            this.calculateGradeButton = new System.Windows.Forms.Button();
            this.resetAllMarksButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.dropCheckBox = new System.Windows.Forms.CheckBox();
            this.quizzMarkTextbox = new System.Windows.Forms.TextBox();
            this.quizzesTexbox = new System.Windows.Forms.TextBox();
            this.finalNumberGradeTexBox = new System.Windows.Forms.TextBox();
            this.finalLetterGradeTexBox = new System.Windows.Forms.TextBox();
            this.midtermMarkTextBox = new System.Windows.Forms.TextBox();
            this.finalExamMarkTextBox = new System.Windows.Forms.TextBox();
            this.quizzMarkLabel = new System.Windows.Forms.Label();
            this.quizzesLabel = new System.Windows.Forms.Label();
            this.midtermMarkLabel = new System.Windows.Forms.Label();
            this.finalExamMarkLabel = new System.Windows.Forms.Label();
            this.transferMarkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetQuizzMarksButton
            // 
            this.resetQuizzMarksButton.Location = new System.Drawing.Point(32, 148);
            this.resetQuizzMarksButton.Name = "resetQuizzMarksButton";
            this.resetQuizzMarksButton.Size = new System.Drawing.Size(331, 49);
            this.resetQuizzMarksButton.TabIndex = 1;
            this.resetQuizzMarksButton.Text = "Reset Quizz Marks";
            this.resetQuizzMarksButton.UseVisualStyleBackColor = true;
            this.resetQuizzMarksButton.Click += new System.EventHandler(this.resetQuizzMarksButton_Click);
            // 
            // calculateGradeButton
            // 
            this.calculateGradeButton.Location = new System.Drawing.Point(238, 455);
            this.calculateGradeButton.Name = "calculateGradeButton";
            this.calculateGradeButton.Size = new System.Drawing.Size(185, 50);
            this.calculateGradeButton.TabIndex = 2;
            this.calculateGradeButton.Text = "Calculate Grade";
            this.calculateGradeButton.UseVisualStyleBackColor = true;
            this.calculateGradeButton.Click += new System.EventHandler(this.calculateGradeButton_Click);
            // 
            // resetAllMarksButton
            // 
            this.resetAllMarksButton.Location = new System.Drawing.Point(238, 519);
            this.resetAllMarksButton.Name = "resetAllMarksButton";
            this.resetAllMarksButton.Size = new System.Drawing.Size(185, 49);
            this.resetAllMarksButton.TabIndex = 3;
            this.resetAllMarksButton.Text = "Reset All Marks";
            this.resetAllMarksButton.UseVisualStyleBackColor = true;
            this.resetAllMarksButton.Click += new System.EventHandler(this.resetAllMarksButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(238, 583);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(185, 44);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // dropCheckBox
            // 
            this.dropCheckBox.AutoSize = true;
            this.dropCheckBox.Location = new System.Drawing.Point(226, 293);
            this.dropCheckBox.Name = "dropCheckBox";
            this.dropCheckBox.Size = new System.Drawing.Size(369, 29);
            this.dropCheckBox.TabIndex = 1;
            this.dropCheckBox.TabStop = false;
            this.dropCheckBox.Text = "Drop Highest and Lowest Quizzes";
            this.dropCheckBox.UseVisualStyleBackColor = true;
            this.dropCheckBox.CheckedChanged += new System.EventHandler(this.dropCheckBox_CheckedChanged);
            // 
            // quizzMarkTextbox
            // 
            this.quizzMarkTextbox.Location = new System.Drawing.Point(178, 78);
            this.quizzMarkTextbox.Name = "quizzMarkTextbox";
            this.quizzMarkTextbox.Size = new System.Drawing.Size(83, 31);
            this.quizzMarkTextbox.TabIndex = 5;
            this.quizzMarkTextbox.TabStop = false;
            this.quizzMarkTextbox.TextChanged += new System.EventHandler(this.quizzMarkTextbox_TextChanged);
            // 
            // quizzesTexbox
            // 
            this.quizzesTexbox.Location = new System.Drawing.Point(388, 20);
            this.quizzesTexbox.Multiline = true;
            this.quizzesTexbox.Name = "quizzesTexbox";
            this.quizzesTexbox.ReadOnly = true;
            this.quizzesTexbox.Size = new System.Drawing.Size(144, 225);
            this.quizzesTexbox.TabIndex = 2;
            this.quizzesTexbox.TabStop = false;
            // 
            // finalNumberGradeTexBox
            // 
            this.finalNumberGradeTexBox.Location = new System.Drawing.Point(444, 455);
            this.finalNumberGradeTexBox.Name = "finalNumberGradeTexBox";
            this.finalNumberGradeTexBox.ReadOnly = true;
            this.finalNumberGradeTexBox.Size = new System.Drawing.Size(71, 31);
            this.finalNumberGradeTexBox.TabIndex = 2;
            this.finalNumberGradeTexBox.TabStop = false;
            // 
            // finalLetterGradeTexBox
            // 
            this.finalLetterGradeTexBox.Location = new System.Drawing.Point(534, 455);
            this.finalLetterGradeTexBox.Name = "finalLetterGradeTexBox";
            this.finalLetterGradeTexBox.ReadOnly = true;
            this.finalLetterGradeTexBox.Size = new System.Drawing.Size(71, 31);
            this.finalLetterGradeTexBox.TabIndex = 2;
            this.finalLetterGradeTexBox.TabStop = false;
            // 
            // midtermMarkTextBox
            // 
            this.midtermMarkTextBox.Location = new System.Drawing.Point(388, 348);
            this.midtermMarkTextBox.Name = "midtermMarkTextBox";
            this.midtermMarkTextBox.Size = new System.Drawing.Size(100, 31);
            this.midtermMarkTextBox.TabIndex = 2;
            this.midtermMarkTextBox.TabStop = false;
            this.midtermMarkTextBox.TextChanged += new System.EventHandler(this.midtermMarkTextBox_TextChanged);
            // 
            // finalExamMarkTextBox
            // 
            this.finalExamMarkTextBox.Location = new System.Drawing.Point(388, 400);
            this.finalExamMarkTextBox.Name = "finalExamMarkTextBox";
            this.finalExamMarkTextBox.Size = new System.Drawing.Size(100, 31);
            this.finalExamMarkTextBox.TabIndex = 2;
            this.finalExamMarkTextBox.TabStop = false;
            this.finalExamMarkTextBox.TextChanged += new System.EventHandler(this.finalExamMarkTextBox_TextChanged);
            // 
            // quizzMarkLabel
            // 
            this.quizzMarkLabel.AutoSize = true;
            this.quizzMarkLabel.Location = new System.Drawing.Point(27, 78);
            this.quizzMarkLabel.Name = "quizzMarkLabel";
            this.quizzMarkLabel.Size = new System.Drawing.Size(127, 25);
            this.quizzMarkLabel.TabIndex = 3;
            this.quizzMarkLabel.Text = "Quizz Mark:";
            // 
            // quizzesLabel
            // 
            this.quizzesLabel.AutoSize = true;
            this.quizzesLabel.Location = new System.Drawing.Point(267, 20);
            this.quizzesLabel.Name = "quizzesLabel";
            this.quizzesLabel.Size = new System.Drawing.Size(96, 25);
            this.quizzesLabel.TabIndex = 3;
            this.quizzesLabel.Text = "Quizzes:";
            // 
            // midtermMarkLabel
            // 
            this.midtermMarkLabel.AutoSize = true;
            this.midtermMarkLabel.Location = new System.Drawing.Point(233, 348);
            this.midtermMarkLabel.Name = "midtermMarkLabel";
            this.midtermMarkLabel.Size = new System.Drawing.Size(149, 25);
            this.midtermMarkLabel.TabIndex = 3;
            this.midtermMarkLabel.Text = "Midterm Mark:";
            // 
            // finalExamMarkLabel
            // 
            this.finalExamMarkLabel.AutoSize = true;
            this.finalExamMarkLabel.Location = new System.Drawing.Point(203, 400);
            this.finalExamMarkLabel.Name = "finalExamMarkLabel";
            this.finalExamMarkLabel.Size = new System.Drawing.Size(179, 25);
            this.finalExamMarkLabel.TabIndex = 3;
            this.finalExamMarkLabel.Text = "Final Exam Mark:";
            // 
            // transferMarkButton
            // 
            this.transferMarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferMarkButton.Location = new System.Drawing.Point(288, 76);
            this.transferMarkButton.Name = "transferMarkButton";
            this.transferMarkButton.Size = new System.Drawing.Size(75, 44);
            this.transferMarkButton.TabIndex = 0;
            this.transferMarkButton.Text = "→";
            this.transferMarkButton.UseVisualStyleBackColor = true;
            this.transferMarkButton.Click += new System.EventHandler(this.transferMarkButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 674);
            this.Controls.Add(this.transferMarkButton);
            this.Controls.Add(this.finalExamMarkLabel);
            this.Controls.Add(this.midtermMarkLabel);
            this.Controls.Add(this.quizzesLabel);
            this.Controls.Add(this.quizzMarkLabel);
            this.Controls.Add(this.finalExamMarkTextBox);
            this.Controls.Add(this.midtermMarkTextBox);
            this.Controls.Add(this.finalLetterGradeTexBox);
            this.Controls.Add(this.finalNumberGradeTexBox);
            this.Controls.Add(this.quizzesTexbox);
            this.Controls.Add(this.quizzMarkTextbox);
            this.Controls.Add(this.dropCheckBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.resetAllMarksButton);
            this.Controls.Add(this.calculateGradeButton);
            this.Controls.Add(this.resetQuizzMarksButton);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetQuizzMarksButton;
        private System.Windows.Forms.Button calculateGradeButton;
        private System.Windows.Forms.Button resetAllMarksButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.CheckBox dropCheckBox;
        private System.Windows.Forms.TextBox quizzMarkTextbox;
        private System.Windows.Forms.TextBox quizzesTexbox;
        private System.Windows.Forms.TextBox finalNumberGradeTexBox;
        private System.Windows.Forms.TextBox finalLetterGradeTexBox;
        private System.Windows.Forms.TextBox midtermMarkTextBox;
        private System.Windows.Forms.TextBox finalExamMarkTextBox;
        private System.Windows.Forms.Label quizzMarkLabel;
        private System.Windows.Forms.Label quizzesLabel;
        private System.Windows.Forms.Label midtermMarkLabel;
        private System.Windows.Forms.Label finalExamMarkLabel;
        private System.Windows.Forms.Button transferMarkButton;
    }
}

