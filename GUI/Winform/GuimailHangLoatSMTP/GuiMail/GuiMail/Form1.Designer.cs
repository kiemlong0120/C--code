
namespace GuiMail
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbGuiDen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTieuDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
            this.tbDinhKem = new System.Windows.Forms.TextBox();
            this.btnDinhKem = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gửi đến:";
            // 
            // tbGuiDen
            // 
            this.tbGuiDen.Location = new System.Drawing.Point(123, 95);
            this.tbGuiDen.Name = "tbGuiDen";
            this.tbGuiDen.Size = new System.Drawing.Size(347, 27);
            this.tbGuiDen.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tiêu đề";
            // 
            // tbTieuDe
            // 
            this.tbTieuDe.Location = new System.Drawing.Point(174, 149);
            this.tbTieuDe.Name = "tbTieuDe";
            this.tbTieuDe.Size = new System.Drawing.Size(347, 27);
            this.tbTieuDe.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên đăng nhập";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(174, 212);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(347, 27);
            this.tbUsername.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mật khẩu";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(174, 269);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(347, 27);
            this.tbPass.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nội dung";
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Location = new System.Drawing.Point(22, 377);
            this.tbNoiDung.Multiline = true;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNoiDung.Size = new System.Drawing.Size(556, 307);
            this.tbNoiDung.TabIndex = 18;
            // 
            // tbDinhKem
            // 
            this.tbDinhKem.Location = new System.Drawing.Point(41, 31);
            this.tbDinhKem.Name = "tbDinhKem";
            this.tbDinhKem.ReadOnly = true;
            this.tbDinhKem.Size = new System.Drawing.Size(347, 27);
            this.tbDinhKem.TabIndex = 20;
            // 
            // btnDinhKem
            // 
            this.btnDinhKem.Location = new System.Drawing.Point(419, 28);
            this.btnDinhKem.Name = "btnDinhKem";
            this.btnDinhKem.Size = new System.Drawing.Size(94, 29);
            this.btnDinhKem.TabIndex = 21;
            this.btnDinhKem.Text = "Đính kèm tệp";
            this.btnDinhKem.UseVisualStyleBackColor = true;
            this.btnDinhKem.Click += new System.EventHandler(this.btnDinhKem_Click);
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(244, 316);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(187, 43);
            this.btnGui.TabIndex = 22;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(484, 93);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(94, 29);
            this.btnAddList.TabIndex = 23;
            this.btnAddList.Text = "Danh sách mail";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 696);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnDinhKem);
            this.Controls.Add(this.tbDinhKem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTieuDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGuiDen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gui Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGuiDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNoiDung;
        private System.Windows.Forms.TextBox tbDinhKem;
        private System.Windows.Forms.Button btnDinhKem;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnAddList;
    }
}

