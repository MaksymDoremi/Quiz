namespace Quiz.Forms
{
    partial class QuestionForm
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
            this.questionImage = new System.Windows.Forms.PictureBox();
            this.listImagesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.submitChangesBtn = new System.Windows.Forms.Button();
            this.addAnswerBtn = new System.Windows.Forms.Button();
            this.deleteWholeQuestionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // questionImage
            // 
            this.questionImage.Location = new System.Drawing.Point(670, 40);
            this.questionImage.Name = "questionImage";
            this.questionImage.Size = new System.Drawing.Size(400, 400);
            this.questionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.questionImage.TabIndex = 0;
            this.questionImage.TabStop = false;
            // 
            // listImagesBtn
            // 
            this.listImagesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listImagesBtn.Location = new System.Drawing.Point(804, 468);
            this.listImagesBtn.Name = "listImagesBtn";
            this.listImagesBtn.Size = new System.Drawing.Size(134, 35);
            this.listImagesBtn.TabIndex = 1;
            this.listImagesBtn.Text = "List Images";
            this.listImagesBtn.UseVisualStyleBackColor = true;
            this.listImagesBtn.Click += new System.EventHandler(this.listImagesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question:";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionTextBox.Location = new System.Drawing.Point(135, 79);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(240, 30);
            this.questionTextBox.TabIndex = 4;
            // 
            // flowLayoutAnswers
            // 
            this.flowLayoutAnswers.AutoScroll = true;
            this.flowLayoutAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutAnswers.Location = new System.Drawing.Point(43, 153);
            this.flowLayoutAnswers.Name = "flowLayoutAnswers";
            this.flowLayoutAnswers.Size = new System.Drawing.Size(550, 483);
            this.flowLayoutAnswers.TabIndex = 5;
            // 
            // submitChangesBtn
            // 
            this.submitChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitChangesBtn.Location = new System.Drawing.Point(1029, 688);
            this.submitChangesBtn.Name = "submitChangesBtn";
            this.submitChangesBtn.Size = new System.Drawing.Size(190, 41);
            this.submitChangesBtn.TabIndex = 6;
            this.submitChangesBtn.Text = "Submit Changes";
            this.submitChangesBtn.UseVisualStyleBackColor = true;
            this.submitChangesBtn.Click += new System.EventHandler(this.submitChangesBtn_Click);
            // 
            // addAnswerBtn
            // 
            this.addAnswerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addAnswerBtn.Location = new System.Drawing.Point(43, 654);
            this.addAnswerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addAnswerBtn.Name = "addAnswerBtn";
            this.addAnswerBtn.Size = new System.Drawing.Size(96, 75);
            this.addAnswerBtn.TabIndex = 7;
            this.addAnswerBtn.Text = "+";
            this.addAnswerBtn.UseVisualStyleBackColor = true;
            this.addAnswerBtn.Click += new System.EventHandler(this.addAnswerBtn_Click);
            // 
            // deleteWholeQuestionBtn
            // 
            this.deleteWholeQuestionBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteWholeQuestionBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteWholeQuestionBtn.Location = new System.Drawing.Point(272, 660);
            this.deleteWholeQuestionBtn.Name = "deleteWholeQuestionBtn";
            this.deleteWholeQuestionBtn.Size = new System.Drawing.Size(85, 66);
            this.deleteWholeQuestionBtn.TabIndex = 8;
            this.deleteWholeQuestionBtn.Text = "X";
            this.deleteWholeQuestionBtn.UseVisualStyleBackColor = true;
            this.deleteWholeQuestionBtn.Click += new System.EventHandler(this.deleteWholeQuestionBtn_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 738);
            this.Controls.Add(this.deleteWholeQuestionBtn);
            this.Controls.Add(this.addAnswerBtn);
            this.Controls.Add(this.submitChangesBtn);
            this.Controls.Add(this.flowLayoutAnswers);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listImagesBtn);
            this.Controls.Add(this.questionImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.questionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox questionImage;
        private System.Windows.Forms.Button listImagesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAnswers;
        private System.Windows.Forms.Button submitChangesBtn;
        private System.Windows.Forms.Button addAnswerBtn;
        private System.Windows.Forms.Button deleteWholeQuestionBtn;
    }
}