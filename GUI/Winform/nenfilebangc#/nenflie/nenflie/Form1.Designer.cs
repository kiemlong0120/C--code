
namespace nenflie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnnen = new System.Windows.Forms.Button();
            this.btngianen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnen
            // 
            this.btnnen.Location = new System.Drawing.Point(111, 245);
            this.btnnen.Name = "btnnen";
            this.btnnen.Size = new System.Drawing.Size(94, 29);
            this.btnnen.TabIndex = 0;
            this.btnnen.Text = "nén";
            this.btnnen.UseVisualStyleBackColor = true;
            this.btnnen.Click += new System.EventHandler(this.btnnen_Click);
            // 
            // btngianen
            // 
            this.btngianen.Location = new System.Drawing.Point(558, 294);
            this.btngianen.Name = "btngianen";
            this.btngianen.Size = new System.Drawing.Size(94, 29);
            this.btngianen.TabIndex = 1;
            this.btngianen.Text = "giải nén";
            this.btngianen.UseVisualStyleBackColor = true;
            this.btngianen.Click += new System.EventHandler(this.btngiainen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngianen);
            this.Controls.Add(this.btnnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnen;
        private System.Windows.Forms.Button btngianen;
    }
}

