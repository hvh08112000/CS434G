using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmDangVanHieu
{
    public partial class frm_TimThu : Form
    {
        int thu;
        public frm_TimThu()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            thu = int.Parse(txtThu.Text);
            if(thu < 2 || thu >8)
            {
                MessageBox.Show("Nhap sai thu");
            }else
            {
                switch (thu)
                {
                    case 2: MessageBox.Show("Thu hai");
                        break;
                    case 3: MessageBox.Show("Thu ba");
                        break;
                    case 4: MessageBox.Show("Thu tu");
                        break;
                    case 5: MessageBox.Show("Thu nam");
                        break;
                    case 6: MessageBox.Show("Thu sau");
                        break;
                    case 7: MessageBox.Show("Thu bay");
                        break;
                    case 8: MessageBox.Show("Chu Nhat");
                        break;
                }
            }
        }
    }
}
