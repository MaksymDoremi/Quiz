using System;

namespace Quiz
{
    partial class QuizForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.flowLayoutAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.submitQuizBtn = new System.Windows.Forms.Button();
            this.questionIndexLabel = new System.Windows.Forms.Label();
            this.exitQuiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(425, 106);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(0, 29);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(1231, 39);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "label1";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextBtn.Location = new System.Drawing.Point(1014, 851);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(131, 67);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previousBtn.Location = new System.Drawing.Point(92, 851);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(138, 67);
            this.previousBtn.TabIndex = 4;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // flowLayoutAnswers
            // 
            this.flowLayoutAnswers.AutoScroll = true;
            this.flowLayoutAnswers.Location = new System.Drawing.Point(80, 587);
            this.flowLayoutAnswers.Name = "flowLayoutAnswers";
            this.flowLayoutAnswers.Size = new System.Drawing.Size(1092, 220);
            this.flowLayoutAnswers.TabIndex = 5;
            // 
            // submitQuizBtn
            // 
            this.submitQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitQuizBtn.Location = new System.Drawing.Point(526, 851);
            this.submitQuizBtn.Name = "submitQuizBtn";
            this.submitQuizBtn.Size = new System.Drawing.Size(193, 67);
            this.submitQuizBtn.TabIndex = 6;
            this.submitQuizBtn.Text = "Submit Quiz";
            this.submitQuizBtn.UseVisualStyleBackColor = true;
            this.submitQuizBtn.Visible = false;
            this.submitQuizBtn.Click += new System.EventHandler(this.submitQuizBtn_Click);
            // 
            // questionIndexLabel
            // 
            this.questionIndexLabel.AutoSize = true;
            this.questionIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionIndexLabel.Location = new System.Drawing.Point(73, 106);
            this.questionIndexLabel.Name = "questionIndexLabel";
            this.questionIndexLabel.Size = new System.Drawing.Size(103, 38);
            this.questionIndexLabel.TabIndex = 7;
            this.questionIndexLabel.Text = "label1";
            // 
            // exitQuiz
            // 
            this.exitQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitQuiz.Location = new System.Drawing.Point(1038, 105);
            this.exitQuiz.Name = "exitQuiz";
            this.exitQuiz.Size = new System.Drawing.Size(107, 38);
            this.exitQuiz.TabIndex = 9;
            this.exitQuiz.Text = "Exit";
            this.exitQuiz.UseVisualStyleBackColor = true;
            this.exitQuiz.Click += new System.EventHandler(this.exitQuiz_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1232, 953);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.questionIndexLabel);
            this.Controls.Add(this.submitQuizBtn);
            this.Controls.Add(this.flowLayoutAnswers);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.exitQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizForm_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAnswers;
        private System.Windows.Forms.Button submitQuizBtn;
        private System.Windows.Forms.Label questionIndexLabel;
        private System.Windows.Forms.Button exitQuiz;
    }
}