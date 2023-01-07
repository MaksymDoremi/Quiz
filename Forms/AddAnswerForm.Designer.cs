namespace Quiz.Forms
{
    partial class AddAnswerForm
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
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.correctCheckBox = new System.Windows.Forms.CheckBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerTextBox.Location = new System.Drawing.Point(75, 55);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(213, 30);
            this.answerTextBox.TabIndex = 0;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // correctCheckBox
            // 
            this.correctCheckBox.AutoSize = true;
            this.correctCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.correctCheckBox.Location = new System.Drawing.Point(136, 118);
            this.correctCheckBox.Name = "correctCheckBox";
            this.correctCheckBox.Size = new System.Drawing.Size(98, 29);
            this.correctCheckBox.TabIndex = 1;
            this.correctCheckBox.Text = "Correct";
            this.correctCheckBox.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitBtn.Location = new System.Drawing.Point(136, 181);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(94, 34);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // AddAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 279);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.correctCheckBox);
            this.Controls.Add(this.answerTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddAnswerForm";
            this.Text = "AddAnswerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.CheckBox correctCheckBox;
        private System.Windows.Forms.Button submitBtn;
    }
}