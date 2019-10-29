namespace SqlServer_Connection_EXP
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.txtAddTemp = new System.Windows.Forms.TextBox();
            this.cbAddGender = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpAddBirthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpUpdateBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.cbUpdateGender = new System.Windows.Forms.ComboBox();
            this.txtUpdateTemp = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDelID = new System.Windows.Forms.TextBox();
            this.lebel7 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpAddBirthday);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAddAddress);
            this.groupBox1.Controls.Add(this.cbAddGender);
            this.groupBox1.Controls.Add(this.txtAddTemp);
            this.groupBox1.Controls.Add(this.txtAddName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加用户";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "备注";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(54, 18);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(133, 21);
            this.txtAddName.TabIndex = 5;
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Location = new System.Drawing.Point(54, 72);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(133, 21);
            this.txtAddAddress.TabIndex = 6;
            // 
            // txtAddTemp
            // 
            this.txtAddTemp.Location = new System.Drawing.Point(54, 126);
            this.txtAddTemp.Multiline = true;
            this.txtAddTemp.Name = "txtAddTemp";
            this.txtAddTemp.Size = new System.Drawing.Size(133, 186);
            this.txtAddTemp.TabIndex = 8;
            // 
            // cbAddGender
            // 
            this.cbAddGender.FormattingEnabled = true;
            this.cbAddGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbAddGender.Location = new System.Drawing.Point(54, 46);
            this.cbAddGender.Name = "cbAddGender";
            this.cbAddGender.Size = new System.Drawing.Size(133, 20);
            this.cbAddGender.TabIndex = 9;
            this.cbAddGender.Text = "男";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpAddBirthday
            // 
            this.dtpAddBirthday.Location = new System.Drawing.Point(54, 99);
            this.dtpAddBirthday.Name = "dtpAddBirthday";
            this.dtpAddBirthday.Size = new System.Drawing.Size(133, 21);
            this.dtpAddBirthday.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUpdateID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpUpdateBirthday);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtUpdateAddress);
            this.groupBox2.Controls.Add(this.cbUpdateGender);
            this.groupBox2.Controls.Add(this.txtUpdateTemp);
            this.groupBox2.Controls.Add(this.txtUpdateName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(212, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "更新用户";
            // 
            // dtpUpdateBirthday
            // 
            this.dtpUpdateBirthday.Location = new System.Drawing.Point(54, 128);
            this.dtpUpdateBirthday.Name = "dtpUpdateBirthday";
            this.dtpUpdateBirthday.Size = new System.Drawing.Size(133, 21);
            this.dtpUpdateBirthday.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(54, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(54, 101);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(133, 21);
            this.txtUpdateAddress.TabIndex = 6;
            // 
            // cbUpdateGender
            // 
            this.cbUpdateGender.FormattingEnabled = true;
            this.cbUpdateGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbUpdateGender.Location = new System.Drawing.Point(54, 75);
            this.cbUpdateGender.Name = "cbUpdateGender";
            this.cbUpdateGender.Size = new System.Drawing.Size(133, 20);
            this.cbUpdateGender.TabIndex = 9;
            this.cbUpdateGender.Text = "男";
            // 
            // txtUpdateTemp
            // 
            this.txtUpdateTemp.Location = new System.Drawing.Point(54, 155);
            this.txtUpdateTemp.Multiline = true;
            this.txtUpdateTemp.Name = "txtUpdateTemp";
            this.txtUpdateTemp.Size = new System.Drawing.Size(133, 186);
            this.txtUpdateTemp.TabIndex = 8;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(54, 48);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(133, 21);
            this.txtUpdateName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "生日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "地址";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "性别";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "用户名";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(54, 21);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(133, 21);
            this.txtUpdateID.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDelID);
            this.groupBox3.Controls.Add(this.lebel7);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Location = new System.Drawing.Point(411, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 425);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "删除用户";
            // 
            // txtDelID
            // 
            this.txtDelID.Location = new System.Drawing.Point(54, 21);
            this.txtDelID.Name = "txtDelID";
            this.txtDelID.Size = new System.Drawing.Size(133, 21);
            this.txtDelID.TabIndex = 13;
            // 
            // lebel7
            // 
            this.lebel7.AutoSize = true;
            this.lebel7.Location = new System.Drawing.Point(7, 24);
            this.lebel7.Name = "lebel7";
            this.lebel7.Size = new System.Drawing.Size(17, 12);
            this.lebel7.TabIndex = 12;
            this.lebel7.Text = "ID";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(67, 66);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpAddBirthday;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.ComboBox cbAddGender;
        private System.Windows.Forms.TextBox txtAddTemp;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpUpdateBirthday;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.ComboBox cbUpdateGender;
        private System.Windows.Forms.TextBox txtUpdateTemp;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDelID;
        private System.Windows.Forms.Label lebel7;
        private System.Windows.Forms.Button btnDel;
    }
}

