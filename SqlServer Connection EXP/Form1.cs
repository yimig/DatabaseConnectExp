using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;


namespace SqlServer_Connection_EXP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //初始化combobox，防止未选择直接确认。
            cbAddGender.SelectedIndex = 0;
            cbUpdateGender.SelectedIndex = 0;
        }

        /// <summary>
        /// 转换性别选择框的性别
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        private char GetGender(ComboBox cb)
        {
            if (cb.SelectedIndex == 0) return '0';
            else return '1';
        }

        /// <summary>
        /// 添加信息按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user=new User();
            user.Name = txtAddName.Text;
            user.Gender = GetGender(cbAddGender);
            user.Address=txtAddAddress.Text;
            user.Birthday = dtpAddBirthday.Value;
            user.Temp = txtAddTemp.Text;
            if (!UserManager.AddUser(user)) MessageBox.Show("添加失败！");
            else MessageBox.Show("操作成功！");
        }

        /// <summary>
        /// 更新信息按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = Convert.ToInt32(txtUpdateID.Text);
            user.Name = txtUpdateName.Text;
            user.Gender = GetGender(cbUpdateGender);
            user.Address = txtUpdateAddress.Text;
            user.Birthday = dtpUpdateBirthday.Value;
            user.Temp = txtUpdateTemp.Text;
            if (!UserManager.UpdateUser(user)) MessageBox.Show("更新失败！");
            else MessageBox.Show("操作成功！");
        }

        /// <summary>
        /// 删除信息按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!UserManager.DelUser(Convert.ToInt32(txtDelID.Text))) MessageBox.Show("删除失败！");
            else MessageBox.Show("操作成功！");
        }
    }
}
