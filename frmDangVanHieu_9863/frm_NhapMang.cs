using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmDangVanHieu
{
    public partial class frm_NhapMang : Form
    {
        public frm_NhapMang()
        {
            InitializeComponent();
        }

        private void btnTinhtoan_Click(object sender, EventArgs e)
        {
            int tongchan = 0;
            int tongle = 0;
            int tongmang = 0;
            string[] a = txtManga.Text.Split(' ');
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                if (Convert.ToInt32(a[i]) % 2 == 0)
                {
                    tongchan += Convert.ToInt32(a[i]);
                    txtTongchan.Text = tongchan.ToString();
                }
                else
                {
                    tongle += Convert.ToInt32(a[i]);
                    txtTongle.Text = tongle.ToString();
                }
                tongmang += Convert.ToInt32(a[i]);
                txtTong.Text = tongmang.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Ban that su muon thoat?", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
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

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ResetControlValues(this);
        }
    }
}
