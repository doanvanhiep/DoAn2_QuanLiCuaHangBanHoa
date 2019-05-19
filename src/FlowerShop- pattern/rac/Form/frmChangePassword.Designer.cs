namespace rac
{
    partial class frmChangePassword
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
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.txtConfirmNewPassword);
            this.ControlPanel.Controls.Add(this.label3);
            this.ControlPanel.Controls.Add(this.txtNewpassword);
            this.ControlPanel.Controls.Add(this.label2);
            this.ControlPanel.Controls.Add(this.txtPassword);
            this.ControlPanel.Controls.Add(this.lbHeader);
            this.ControlPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ControlPanel.Location = new System.Drawing.Point(9, 8);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(464, 206);
            this.ControlPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mật Khẩu Mới";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(149, 154);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '*';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(231, 22);
            this.txtConfirmNewPassword.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập Lại";
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewpassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewpassword.Location = new System.Drawing.Point(149, 118);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.PasswordChar = '*';
            this.txtNewpassword.Size = new System.Drawing.Size(231, 22);
            this.txtNewpassword.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(149, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(231, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Red;
            this.lbHeader.Location = new System.Drawing.Point(64, 13);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(336, 41);
            this.lbHeader.TabIndex = 3;
            this.lbHeader.Text = "Nhập mật khẩu mới";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.Location = new System.Drawing.Point(352, 220);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 37);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Location = new System.Drawing.Point(9, 220);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(121, 37);
            this.btnXacNhan.TabIndex = 11;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 262);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Name = "frmChangePassword";
            this.Text = "frmSignup";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
    }
}