using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        // nút thêm
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string manv = tbx_EmployID.Text;
            string tennv = tBx_name.Text;
            string diachi = tBx_Address.Text;
            string sodt = tBx_Phone.Text;
            string ketquagioitinh = "";
            string gioitinh = "";
            if (tbx_EmployID.Text == string.Empty
                || tBx_Address.Text == string.Empty
                || tBx_name.Text == string.Empty
                || tBx_Phone.Text == string.Empty)
                MessageBox.Show("Please enter missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // lấy giá trị từ phần giới tính thông qua duyệt
            foreach (Control ctr in this.Information.Controls)
            {
                if (ctr is RadioButton)
                {
                    RadioButton radio = (RadioButton)ctr;
                    if (radio.Checked)
                    {
                        gioitinh += radio.Text;
                    }
                }
            }
            ketquagioitinh += gioitinh;
            if (tbx_EmployID.Text != string.Empty
                && tBx_Address.Text != string.Empty
                && tBx_name.Text != string.Empty
                && tBx_Phone.Text != string.Empty
                && (raBtn_Male.Checked || rdBtnFemale.Checked))
            {
                dataGridView1.Rows.Add(manv, tennv, DOBpicker.Value.ToString(), ketquagioitinh, diachi, sodt);
            }
        }
        // lưu thông tin
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.RowCount;
            if (count == 1)
                MessageBox.Show("Can't save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("You sure want to save this??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Save success.", "Save dialog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Save not success.", "Save dialog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        }
        // xóa thông tin
        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int selectcurrent = dataGridView1.CurrentCell.RowIndex;
                if (MessageBox.Show("Are you sure want to Remove this?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    dataGridView1.Rows.RemoveAt(selectcurrent);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("This is null");
            }
        }
        // reset all
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to reset?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                tbx_EmployID.Clear();
                tBx_Address.Clear();
                tBx_name.Clear();
                tBx_Phone.Clear();
            }
        }
        // cancel
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
