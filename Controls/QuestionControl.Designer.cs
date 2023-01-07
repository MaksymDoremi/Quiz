namespace Quiz.Controls
{
    partial class QuestionControl
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
            this.questionPhoto = new System.Windows.Forms.PictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPhoto
            // 
            this.questionPhoto.Location = new System.Drawing.Point(52, 19);
            this.questionPhoto.Name = "questionPhoto";
            this.questionPhoto.Size = new System.Drawing.Size(275, 275);
            this.questionPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.questionPhoto.TabIndex = 0;
            this.questionPhoto.TabStop = false;
            this.questionPhoto.Click += new System.EventHandler(this.QuestionClicked);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(0, 332);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(380, 38);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "label1";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Click += new System.EventHandler(this.QuestionClicked);
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionPhoto);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(378, 378);
            this.Click += new System.EventHandler(this.QuestionClicked);
            ((System.ComponentModel.ISupportInitialize)(this.questionPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox questionPhoto;
        private System.Windows.Forms.Label questionLabel;
    }
}
