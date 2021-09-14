using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmDangVanHieu
{
    public partial class frm_GiaiPTBac2 : Form
    {
        // thoát 
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Ban that su muon thoat?", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // giải 
        private void btn1_Click(object sender, EventArgs e)
        {
            float a, b, c, f, g ,h ;
            float x1 = 0, x2 = 0, d = 0;
            a = Convert.ToSingle(txtSoa.Text);
            b = Convert.ToSingle(txtSob.Text);
            c = Convert.ToSingle(txtSoc.Text);
            if(txtSoa.Text=="" || txtSob.Text == "" || txtSoc.Text == "")
            {
                txtKetqua.Text = "Ban chua nhap du a,b,c";
            }
            else
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            // truong hop a!=0 && b=0 && c=0
                            txtKetqua.Text = "Phuong trinh co vo so nghiem";
                        }
                        else
                        {
                            //truong hop a!=0 && b!=0 && c=0
                            txtKetqua.Text = "Phuong trinh vo ngiem";
                        }
                    }
                    else 
                    { 
                        // truong hop a=0 && b!=0 && c!=0
                        x1 = -b / c;
                        txtKetqua.Text = "Phuong trinh co 1 nghiem kep: " + x1;
                    }
                }
                else
                {
                    d = (b * b) + 4 * a * c; // Tinh delta 
                    double dt = Convert.ToDouble(d); // ep kieu cho delta
                    if (dt < 0)
                    {
                        txtKetqua.Text = "Phuong trinh vo nghiem";
                    }
                    else
                    {
                        if (dt > 0)
                        {
                            x1 = Convert.ToSingle((-Math.Sqrt(dt) - b) - (2 * a));
                            x2 = Convert.ToSingle((Math.Sqrt(dt) - b) + (2 * a));
                            txtKetqua.Text = ("Phuong trinh co 2 nghiem phan biet la : {0} ; {1} ", x1, x2).ToString();
                        }
                        else
                        {
                            x1 = -b / a;
                            txtKetqua.Text = "Phuong trinh co nghiem kep la: " + x1;
                        }
                    }
                }
            }
        }

        public frm_GiaiPTBac2()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ResetControlValues(this);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
