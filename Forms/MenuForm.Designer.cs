namespace Quiz
{
    partial class MenuForm
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
            this.startQuizBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fiveQuestionsBtn = new System.Windows.Forms.Button();
            this.sevenQuestionsBtn = new System.Windows.Forms.Button();
            this.tenQuestionsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openRedactorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startQuizBtn
            // 
            this.startQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startQuizBtn.Location = new System.Drawing.Point(550, 390);
            this.startQuizBtn.Name = "startQuizBtn";
            this.startQuizBtn.Size = new System.Drawing.Size(150, 60);
            this.startQuizBtn.TabIndex = 0;
            this.startQuizBtn.Text = "Start Quiz";
            this.startQuizBtn.UseVisualStyleBackColor = true;
            this.startQuizBtn.Click += new System.EventHandler(this.startQuizBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(563, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(496, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Count Of Questions";
            // 
            // fiveQuestionsBtn
            // 
            this.fiveQuestionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fiveQuestionsBtn.Location = new System.Drawing.Point(409, 568);
            this.fiveQuestionsBtn.Name = "fiveQuestionsBtn";
            this.fiveQuestionsBtn.Size = new System.Drawing.Size(61, 50);
            this.fiveQuestionsBtn.TabIndex = 3;
            this.fiveQuestionsBtn.Text = "5";
            this.fiveQuestionsBtn.UseVisualStyleBackColor = true;
            this.fiveQuestionsBtn.Click += new System.EventHandler(this.difficultyBtn_Click);
            // 
            // sevenQuestionsBtn
            // 
            this.sevenQuestionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sevenQuestionsBtn.Location = new System.Drawing.Point(595, 568);
            this.sevenQuestionsBtn.Name = "sevenQuestionsBtn";
            this.sevenQuestionsBtn.Size = new System.Drawing.Size(61, 50);
            this.sevenQuestionsBtn.TabIndex = 4;
            this.sevenQuestionsBtn.Text = "7";
            this.sevenQuestionsBtn.UseVisualStyleBackColor = true;
            this.sevenQuestionsBtn.Click += new System.EventHandler(this.difficultyBtn_Click);
            // 
            // tenQuestionsBtn
            // 
            this.tenQuestionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tenQuestionsBtn.Location = new System.Drawing.Point(772, 568);
            this.tenQuestionsBtn.Name = "tenQuestionsBtn";
            this.tenQuestionsBtn.Size = new System.Drawing.Size(61, 50);
            this.tenQuestionsBtn.TabIndex = 5;
            this.tenQuestionsBtn.Text = "10";
            this.tenQuestionsBtn.UseVisualStyleBackColor = true;
            this.tenQuestionsBtn.Click += new System.EventHandler(this.difficultyBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(89, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 105);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rules:\nCorrect +1\nIncorrect -0.25\nDo not cheat";
            // 
            // openRedactorBtn
            // 
            this.openRedactorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openRedactorBtn.Location = new System.Drawing.Point(49, 646);
            this.openRedactorBtn.Name = "openRedactorBtn";
            this.openRedactorBtn.Size = new System.Drawing.Size(108, 35);
            this.openRedactorBtn.TabIndex = 7;
            this.openRedactorBtn.Text = "Redactor";
            this.openRedactorBtn.UseVisualStyleBackColor = true;
            this.openRedactorBtn.Click += new System.EventHandler(this.openRedactorBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1232, 723);
            this.Controls.Add(this.openRedactorBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenQuestionsBtn);
            this.Controls.Add(this.sevenQuestionsBtn);
            this.Controls.Add(this.fiveQuestionsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startQuizBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenuForm";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startQuizBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fiveQuestionsBtn;
        private System.Windows.Forms.Button sevenQuestionsBtn;
        private System.Windows.Forms.Button tenQuestionsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openRedactorBtn;
    }
}

