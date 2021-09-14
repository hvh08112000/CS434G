
namespace frmDangVanHieu
{
    partial class frm_NhapMang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinhtoan = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtManga = new System.Windows.Forms.TextBox();
            this.txtTongle = new System.Windows.Forms.TextBox();
            this.txtTongchan = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng các số lẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng các số chẵn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng các số mảng A";
            // 
            // btnTinhtoan
            // 
            this.btnTinhtoan.Location = new System.Drawing.Point(61, 386);
            this.btnTinhtoan.Name = "btnTinhtoan";
            this.btnTinhtoan.Size = new System.Drawing.Size(94, 29);
            this.btnTinhtoan.TabIndex = 4;
            this.btnTinhtoan.Text = "Tính toán";
            this.btnTinhtoan.UseVisualStyleBackColor = true;
            this.btnTinhtoan.Click += new System.EventHandler(this.btnTinhtoan_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(366, 385);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(94, 29);
            this.btnLammoi.TabIndex = 5;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(675, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtManga
            // 
            this.txtManga.Location = new System.Drawing.Point(227, 37);
            this.txtManga.Name = "txtManga";
            this.txtManga.Size = new System.Drawing.Size(310, 27);
            this.txtManga.TabIndex = 7;
            // 
            // txtTongle
            // 
            this.txtTongle.Location = new System.Drawing.Point(227, 111);
            this.txtTongle.Name = "txtTongle";
            this.txtTongle.Size = new System.Drawing.Size(489, 27);
            this.txtTongle.TabIndex = 8;
            // 
            // txtTongchan
            // 
            this.txtTongchan.Location = new System.Drawing.Point(227, 175);
            this.txtTongchan.Name = "txtTongchan";
            this.txtTongchan.Size = new System.Drawing.Size(489, 27);
            this.txtTongchan.TabIndex = 9;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(227, 244);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(489, 27);
            this.txtTong.TabIndex = 10;
            // 
            // frm_NhapMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 680);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtTongchan);
            this.Controls.Add(this.txtTongle);
            this.Controls.Add(this.txtManga);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnTinhtoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_NhapMang";
            this.Text = "frm_NhapMang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTinhtoan;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtManga;
        private System.Windows.Forms.TextBox txtTongle;
        private System.Windows.Forms.TextBox txtTongchan;
        private System.Windows.Forms.TextBox txtTong;
    }
}