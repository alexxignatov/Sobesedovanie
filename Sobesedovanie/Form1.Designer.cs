namespace Sobesedovanie
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(49, 148);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(30, 13);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "text1";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(49, 176);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(30, 13);
            this.lblText2.TabIndex = 1;
            this.lblText2.Text = "text2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 268);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
    }
}

