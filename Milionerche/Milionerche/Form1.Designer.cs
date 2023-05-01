namespace Milionerche
{
    partial class Form1
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.Answear1 = new System.Windows.Forms.RadioButton();
            this.Answear2 = new System.Windows.Forms.RadioButton();
            this.Answear3 = new System.Windows.Forms.RadioButton();
            this.Answear4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(474, 88);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(70, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // Answear1
            // 
            this.Answear1.AutoSize = true;
            this.Answear1.Location = new System.Drawing.Point(117, 195);
            this.Answear1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Answear1.Name = "Answear1";
            this.Answear1.Size = new System.Drawing.Size(155, 29);
            this.Answear1.TabIndex = 1;
            this.Answear1.TabStop = true;
            this.Answear1.Text = "radioButton1";
            this.Answear1.UseVisualStyleBackColor = true;
            // 
            // Answear2
            // 
            this.Answear2.AutoSize = true;
            this.Answear2.Location = new System.Drawing.Point(117, 336);
            this.Answear2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Answear2.Name = "Answear2";
            this.Answear2.Size = new System.Drawing.Size(155, 29);
            this.Answear2.TabIndex = 2;
            this.Answear2.TabStop = true;
            this.Answear2.Text = "radioButton2";
            this.Answear2.UseVisualStyleBackColor = true;
            // 
            // Answear3
            // 
            this.Answear3.AutoSize = true;
            this.Answear3.Location = new System.Drawing.Point(697, 195);
            this.Answear3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Answear3.Name = "Answear3";
            this.Answear3.Size = new System.Drawing.Size(155, 29);
            this.Answear3.TabIndex = 3;
            this.Answear3.TabStop = true;
            this.Answear3.Text = "radioButton3";
            this.Answear3.UseVisualStyleBackColor = true;
            // 
            // Answear4
            // 
            this.Answear4.AutoSize = true;
            this.Answear4.Location = new System.Drawing.Point(697, 336);
            this.Answear4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Answear4.Name = "Answear4";
            this.Answear4.Size = new System.Drawing.Size(155, 29);
            this.Answear4.TabIndex = 4;
            this.Answear4.TabStop = true;
            this.Answear4.Text = "radioButton4";
            this.Answear4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 587);
            this.Controls.Add(this.Answear4);
            this.Controls.Add(this.Answear3);
            this.Controls.Add(this.Answear2);
            this.Controls.Add(this.Answear1);
            this.Controls.Add(this.lblQuestion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton Answear1;
        private System.Windows.Forms.RadioButton Answear2;
        private System.Windows.Forms.RadioButton Answear3;
        private System.Windows.Forms.RadioButton Answear4;
    }
}

