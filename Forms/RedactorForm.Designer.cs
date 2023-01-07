using System;

namespace Quiz.Forms
{
    partial class RedactorForm
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
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.openMenuBtn = new System.Windows.Forms.Button();
            this.addNewQuestionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Location = new System.Drawing.Point(0, 50);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(1230, 578);
            this.flowLayout.TabIndex = 0;
            // 
            // openMenuBtn
            // 
            this.openMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openMenuBtn.Location = new System.Drawing.Point(12, 12);
            this.openMenuBtn.Name = "openMenuBtn";
            this.openMenuBtn.Size = new System.Drawing.Size(87, 30);
            this.openMenuBtn.TabIndex = 1;
            this.openMenuBtn.Text = "Menu";
            this.openMenuBtn.UseVisualStyleBackColor = true;
            this.openMenuBtn.Click += new System.EventHandler(this.openMenuBtn_Click);
            // 
            // addNewQuestionBtn
            // 
            this.addNewQuestionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewQuestionBtn.Location = new System.Drawing.Point(12, 634);
            this.addNewQuestionBtn.Name = "addNewQuestionBtn";
            this.addNewQuestionBtn.Size = new System.Drawing.Size(114, 77);
            this.addNewQuestionBtn.TabIndex = 2;
            this.addNewQuestionBtn.Text = "+";
            this.addNewQuestionBtn.UseVisualStyleBackColor = true;
            this.addNewQuestionBtn.Click += new System.EventHandler(this.addNewQuestionBtn_Click);
            // 
            // RedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 723);
            this.Controls.Add(this.addNewQuestionBtn);
            this.Controls.Add(this.openMenuBtn);
            this.Controls.Add(this.flowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RedactorForm";
            this.Text = "RedactorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RedactorForm_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Button openMenuBtn;
        private System.Windows.Forms.Button addNewQuestionBtn;
    }
}