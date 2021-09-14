using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmDangVanHieu
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = "ADMIN";
            string pass = "123456";
            int dem = 0;
            if (user.Equals(txtDangnhap.Text.PadLeft(1).ToUpper()) && pass.Equals(txtMatkhau.Text))
            {
                Form1 listbox = new Form1();
                listbox.Show();
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
            {
                dem++;
                lbThongbao.Text = "Ban da nhap sai " + dem.ToString() + " lan";
                if(dem == 3)
                {
                    MessageBox.Show("Ban da nhap sai 3 lan chuong trinh se tu thoat");
                    Application.Exit();
                }
            }
        }
        public static void ResetControlValues(Control Parent)
        {

            foreach (Control mycontrols in Parent.Controls)
                if (mycontrols is TextBox)
                {

                    (mycontrols as TextBox).Text = string.Empty;

                }

                else if (mycontrols is DateTimePicker)

                {

                    (mycontrols as DateTimePicker).Value = DateTime.Now;

                }

                else if (mycontrols is ComboBox)

                {

                    (mycontrols as ComboBox).SelectedIndex = 0;

                }

                else if (mycontrols is DataGridView)

                {

                    (mycontrols as DataGridView).Rows.Clear();

                }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Ban that su muon thoat?", "Canh bao", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            ResetControlValues(this);
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
