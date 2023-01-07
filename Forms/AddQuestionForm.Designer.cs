namespace Quiz.Forms
{
    partial class AddQuestionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.listImagesBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // questionImage
            // 
            this.questionImage.Location = new System.Drawing.Point(273, 12);
            this.questionImage.Name = "questionImage";
            this.questionImage.Size = new System.Drawing.Size(350, 350);
            this.questionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.questionImage.TabIndex = 0;
            this.questionImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(268, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question: ";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionTextBox.Location = new System.Drawing.Point(376, 456);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(247, 30);
            this.questionTextBox.TabIndex = 2;
            // 
            // listImagesBtn
            // 
            this.listImagesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listImagesBtn.Location = new System.Drawing.Point(389, 377);
            this.listImagesBtn.Name = "listImagesBtn";
            this.listImagesBtn.Size = new System.Drawing.Size(132, 37);
            this.listImagesBtn.TabIndex = 3;
            this.listImagesBtn.Text = "List Images";
            this.listImagesBtn.UseVisualStyleBackColor = true;
            this.listImagesBtn.Click += new System.EventHandler(this.listImagesBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitBtn.Location = new System.Drawing.Point(401, 545);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(99, 36);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 623);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.listImagesBtn);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddQuestionForm";
            ((System.ComponentModel.ISupportInitialize)(this.questionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox questionImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Button listImagesBtn;
        private System.Windows.Forms.Button submitBtn;
    }
}