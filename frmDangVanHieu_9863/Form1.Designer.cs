
namespace frmDangVanHieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkHoigiao = new System.Windows.Forms.CheckBox();
            this.chkTinlanh = new System.Windows.Forms.CheckBox();
            this.chkThienchua = new System.Windows.Forms.CheckBox();
            this.chkPhatGiao = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rdoKhac = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTruong = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtKhoas = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbDantoc = new System.Windows.Forms.ComboBox();
            this.clsNgoaingu = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(404, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clsNgoaingu);
            this.groupBox1.Controls.Add(this.cbDantoc);
            this.groupBox1.Controls.Add(this.dateNgaysinh);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNganh);
            this.groupBox1.Controls.Add(this.txtKhoa);
            this.groupBox1.Controls.Add(this.txtKhoas);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.txtTruong);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMasv);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.chkHoigiao);
            this.groupBox1.Controls.Add(this.chkTinlanh);
            this.groupBox1.Controls.Add(this.chkThienchua);
            this.groupBox1.Controls.Add(this.chkPhatGiao);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.rdoKhac);
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 635);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(137, 80);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(299, 27);
            this.txtHoten.TabIndex = 25;
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(137, 35);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(299, 27);
            this.txtMasv.TabIndex = 24;
            this.txtMasv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(858, 585);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(362, 595);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(183, 20);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://kcntt.duytan.edu.vn/";
            // 
            // chkHoigiao
            // 
            this.chkHoigiao.AutoSize = true;
            this.chkHoigiao.Location = new System.Drawing.Point(319, 554);
            this.chkHoigiao.Name = "chkHoigiao";
            this.chkHoigiao.Size = new System.Drawing.Size(90, 24);
            this.chkHoigiao.TabIndex = 21;
            this.chkHoigiao.Text = "Hồi Giáo";
            this.chkHoigiao.UseVisualStyleBackColor = true;
            // 
            // chkTinlanh
            // 
            this.chkTinlanh.AutoSize = true;
            this.chkTinlanh.Location = new System.Drawing.Point(124, 554);
            this.chkTinlanh.Name = "chkTinlanh";
            this.chkTinlanh.Size = new System.Drawing.Size(86, 24);
            this.chkTinlanh.TabIndex = 20;
            this.chkTinlanh.Text = "Tin Lành";
            this.chkTinlanh.UseVisualStyleBackColor = true;
            // 
            // chkThienchua
            // 
            this.chkThienchua.AutoSize = true;
            this.chkThienchua.Location = new System.Drawing.Point(319, 504);
            this.chkThienchua.Name = "chkThienchua";
            this.chkThienchua.Size = new System.Drawing.Size(104, 24);
            this.chkThienchua.TabIndex = 19;
            this.chkThienchua.Text = "Thiên Chúa";
            this.chkThienchua.UseVisualStyleBackColor = true;
            // 
            // chkPhatGiao
            // 
            this.chkPhatGiao.AutoSize = true;
            this.chkPhatGiao.Location = new System.Drawing.Point(124, 504);
            this.chkPhatGiao.Name = "chkPhatGiao";
            this.chkPhatGiao.Size = new System.Drawing.Size(95, 24);
            this.chkPhatGiao.TabIndex = 18;
            this.chkPhatGiao.Text = "Phật Giáo";
            this.chkPhatGiao.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 470);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Tôn Giáo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 414);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Dân Tộc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Địa Chỉ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Ngày Sinh";
            // 
            // rdoKhac
            // 
            this.rdoKhac.AutoSize = true;
            this.rdoKhac.Location = new System.Drawing.Point(124, 236);
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Size = new System.Drawing.Size(62, 24);
            this.rdoKhac.TabIndex = 13;
            this.rdoKhac.TabStop = true;
            this.rdoKhac.Text = "Khác";
            this.rdoKhac.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(124, 190);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(50, 24);
            this.rdoNu.TabIndex = 12;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(124, 146);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(62, 24);
            this.rdoNam.TabIndex = 11;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(616, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Số Điện Thoại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(616, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(616, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngoại Ngữ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(616, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ngành:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Khoa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(616, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Khóa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trường:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Đầy Đủ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(137, 305);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(299, 95);
            this.txtDiachi.TabIndex = 26;
            // 
            // txtTruong
            // 
            this.txtTruong.Location = new System.Drawing.Point(706, 35);
            this.txtTruong.Name = "txtTruong";
            this.txtTruong.Size = new System.Drawing.Size(299, 27);
            this.txtTruong.TabIndex = 27;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(706, 80);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(299, 27);
            this.txtLop.TabIndex = 28;
            // 
            // txtKhoas
            // 
            this.txtKhoas.Location = new System.Drawing.Point(706, 119);
            this.txtKhoas.Name = "txtKhoas";
            this.txtKhoas.Size = new System.Drawing.Size(299, 27);
            this.txtKhoas.TabIndex = 29;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(706, 160);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(299, 27);
            this.txtKhoa.TabIndex = 30;
            this.txtKhoa.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new System.Drawing.Point(706, 205);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(299, 27);
            this.txtNganh.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(706, 411);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 27);
            this.txtEmail.TabIndex = 32;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(724, 467);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(281, 27);
            this.txtSdt.TabIndex = 33;
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Location = new System.Drawing.Point(137, 267);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(299, 27);
            this.dateNgaysinh.TabIndex = 34;
            // 
            // cbDantoc
            // 
            this.cbDantoc.FormattingEnabled = true;
            this.cbDantoc.Items.AddRange(new object[] {
            "Không Dân Tộc",
            "Kinh ",
            "Ê Đê"});
            this.cbDantoc.Location = new System.Drawing.Point(137, 407);
            this.cbDantoc.Name = "cbDantoc";
            this.cbDantoc.Size = new System.Drawing.Size(299, 28);
            this.cbDantoc.TabIndex = 35;
            // 
            // clsNgoaingu
            // 
            this.clsNgoaingu.FormattingEnabled = true;
            this.clsNgoaingu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Trung ",
            "Tiếng Nhật",
            "Tiếng Đức"});
            this.clsNgoaingu.Location = new System.Drawing.Point(708, 267);
            this.clsNgoaingu.Name = "clsNgoaingu";
            this.clsNgoaingu.Size = new System.Drawing.Size(297, 114);
            this.clsNgoaingu.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkHoigiao;
        private System.Windows.Forms.CheckBox chkTinlanh;
        private System.Windows.Forms.CheckBox chkThienchua;
        private System.Windows.Forms.CheckBox chkPhatGiao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdoKhac;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtKhoas;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTruong;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.CheckedListBox clsNgoaingu;
        private System.Windows.Forms.ComboBox cbDantoc;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNganh;
    }
}

