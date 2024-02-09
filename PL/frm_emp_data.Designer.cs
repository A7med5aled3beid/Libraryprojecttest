namespace Librarypro.PL
{
    partial class frm_emp_data
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
            this.pn_emp_data = new System.Windows.Forms.Panel();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.btn_emp_search = new System.Windows.Forms.Button();
            this.cmb_search_emp = new System.Windows.Forms.ComboBox();
            this.grp_emp_data = new System.Windows.Forms.GroupBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_joptype = new System.Windows.Forms.ComboBox();
            this.txt_emp_salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_emp_persID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_emp_nots = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_emp_mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_emp_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_emp_adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_emp_data.SuspendLayout();
            this.grp_btns.SuspendLayout();
            this.grp_search.SuspendLayout();
            this.grp_emp_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_emp_data
            // 
            this.pn_emp_data.BackColor = System.Drawing.Color.White;
            this.pn_emp_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_emp_data.Controls.Add(this.grp_btns);
            this.pn_emp_data.Controls.Add(this.grp_search);
            this.pn_emp_data.Controls.Add(this.grp_emp_data);
            this.pn_emp_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_emp_data.Location = new System.Drawing.Point(0, 0);
            this.pn_emp_data.Name = "pn_emp_data";
            this.pn_emp_data.Size = new System.Drawing.Size(1280, 755);
            this.pn_emp_data.TabIndex = 2;
            // 
            // grp_btns
            // 
            this.grp_btns.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grp_btns.BackColor = System.Drawing.Color.Turquoise;
            this.grp_btns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_btns.Controls.Add(this.btn_close);
            this.grp_btns.Controls.Add(this.btn_delete);
            this.grp_btns.Controls.Add(this.btn_update);
            this.grp_btns.Controls.Add(this.btn_save);
            this.grp_btns.Controls.Add(this.btn_new);
            this.grp_btns.Location = new System.Drawing.Point(163, 621);
            this.grp_btns.Name = "grp_btns";
            this.grp_btns.Size = new System.Drawing.Size(954, 95);
            this.grp_btns.TabIndex = 3;
            this.grp_btns.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::Librarypro.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_24;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(159, 33);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 36);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::Librarypro.Properties.Resources.Custom_Icon_Design_Flatastic_4_Male_user_remove_24;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(296, 33);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = global::Librarypro.Properties.Resources.Custom_Icon_Design_Flatastic_4_Male_user_edit_24;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(435, 33);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(119, 36);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Librarypro.Properties.Resources.Custom_Icon_Design_Flatastic_4_Male_user_accept_24;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(571, 33);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 36);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = global::Librarypro.Properties.Resources.Custom_Icon_Design_Flatastic_4_Male_user_add_24;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.Location = new System.Drawing.Point(709, 33);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(119, 36);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // grp_search
            // 
            this.grp_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grp_search.BackColor = System.Drawing.Color.Turquoise;
            this.grp_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_search.Controls.Add(this.btn_emp_search);
            this.grp_search.Controls.Add(this.cmb_search_emp);
            this.grp_search.Location = new System.Drawing.Point(442, 38);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(396, 95);
            this.grp_search.TabIndex = 2;
            this.grp_search.TabStop = false;
            // 
            // btn_emp_search
            // 
            this.btn_emp_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_emp_search.Image = global::Librarypro.Properties.Resources.Custom_Icon_Design_Flatastic_4_Male_user_search_24;
            this.btn_emp_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_emp_search.Location = new System.Drawing.Point(143, 46);
            this.btn_emp_search.Name = "btn_emp_search";
            this.btn_emp_search.Size = new System.Drawing.Size(119, 36);
            this.btn_emp_search.TabIndex = 1;
            this.btn_emp_search.Text = "بحث";
            this.btn_emp_search.UseVisualStyleBackColor = true;
            this.btn_emp_search.Click += new System.EventHandler(this.btn_emp_search_Click);
            // 
            // cmb_search_emp
            // 
            this.cmb_search_emp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_search_emp.FormattingEnabled = true;
            this.cmb_search_emp.Location = new System.Drawing.Point(44, 19);
            this.cmb_search_emp.Name = "cmb_search_emp";
            this.cmb_search_emp.Size = new System.Drawing.Size(332, 21);
            this.cmb_search_emp.TabIndex = 0;
            // 
            // grp_emp_data
            // 
            this.grp_emp_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grp_emp_data.AutoSize = true;
            this.grp_emp_data.BackColor = System.Drawing.Color.Turquoise;
            this.grp_emp_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_emp_data.Controls.Add(this.lb_id);
            this.grp_emp_data.Controls.Add(this.label9);
            this.grp_emp_data.Controls.Add(this.label8);
            this.grp_emp_data.Controls.Add(this.cmb_joptype);
            this.grp_emp_data.Controls.Add(this.txt_emp_salary);
            this.grp_emp_data.Controls.Add(this.label6);
            this.grp_emp_data.Controls.Add(this.txt_emp_persID);
            this.grp_emp_data.Controls.Add(this.label7);
            this.grp_emp_data.Controls.Add(this.txt_emp_nots);
            this.grp_emp_data.Controls.Add(this.label5);
            this.grp_emp_data.Controls.Add(this.txt_emp_mobile);
            this.grp_emp_data.Controls.Add(this.label4);
            this.grp_emp_data.Controls.Add(this.txt_emp_phone);
            this.grp_emp_data.Controls.Add(this.label3);
            this.grp_emp_data.Controls.Add(this.txt_emp_adress);
            this.grp_emp_data.Controls.Add(this.label2);
            this.grp_emp_data.Controls.Add(this.txt_emp_name);
            this.grp_emp_data.Controls.Add(this.label1);
            this.grp_emp_data.Location = new System.Drawing.Point(56, 149);
            this.grp_emp_data.Name = "grp_emp_data";
            this.grp_emp_data.Size = new System.Drawing.Size(1168, 453);
            this.grp_emp_data.TabIndex = 1;
            this.grp_emp_data.TabStop = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(550, 16);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 16);
            this.lb_id.TabIndex = 37;
            this.lb_id.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(505, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "نوع الوظيفة";
            // 
            // cmb_joptype
            // 
            this.cmb_joptype.FormattingEnabled = true;
            this.cmb_joptype.Location = new System.Drawing.Point(165, 58);
            this.cmb_joptype.Name = "cmb_joptype";
            this.cmb_joptype.Size = new System.Drawing.Size(275, 21);
            this.cmb_joptype.TabIndex = 14;
            // 
            // txt_emp_salary
            // 
            this.txt_emp_salary.Location = new System.Drawing.Point(165, 152);
            this.txt_emp_salary.Name = "txt_emp_salary";
            this.txt_emp_salary.Size = new System.Drawing.Size(275, 20);
            this.txt_emp_salary.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "المرتب الاساسي";
            // 
            // txt_emp_persID
            // 
            this.txt_emp_persID.Location = new System.Drawing.Point(619, 153);
            this.txt_emp_persID.Name = "txt_emp_persID";
            this.txt_emp_persID.Size = new System.Drawing.Size(275, 20);
            this.txt_emp_persID.TabIndex = 11;
            this.txt_emp_persID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(920, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = " رقم البطاقة";
            // 
            // txt_emp_nots
            // 
            this.txt_emp_nots.Location = new System.Drawing.Point(165, 251);
            this.txt_emp_nots.Multiline = true;
            this.txt_emp_nots.Name = "txt_emp_nots";
            this.txt_emp_nots.Size = new System.Drawing.Size(729, 88);
            this.txt_emp_nots.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(935, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ملاحظات";
            // 
            // txt_emp_mobile
            // 
            this.txt_emp_mobile.Location = new System.Drawing.Point(165, 106);
            this.txt_emp_mobile.Name = "txt_emp_mobile";
            this.txt_emp_mobile.Size = new System.Drawing.Size(275, 20);
            this.txt_emp_mobile.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "الموبايل";
            // 
            // txt_emp_phone
            // 
            this.txt_emp_phone.Location = new System.Drawing.Point(619, 107);
            this.txt_emp_phone.Name = "txt_emp_phone";
            this.txt_emp_phone.Size = new System.Drawing.Size(275, 20);
            this.txt_emp_phone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(942, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "التليفون";
            // 
            // txt_emp_adress
            // 
            this.txt_emp_adress.Location = new System.Drawing.Point(165, 198);
            this.txt_emp_adress.Name = "txt_emp_adress";
            this.txt_emp_adress.Size = new System.Drawing.Size(732, 20);
            this.txt_emp_adress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(953, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "العنوان";
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Location = new System.Drawing.Point(619, 60);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(275, 20);
            this.txt_emp_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(914, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الموظف";
            // 
            // frm_emp_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_emp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_emp_data";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بيانات الموظفين";
            this.Load += new System.EventHandler(this.frm_emp_data_Load);
            this.pn_emp_data.ResumeLayout(false);
            this.pn_emp_data.PerformLayout();
            this.grp_btns.ResumeLayout(false);
            this.grp_search.ResumeLayout(false);
            this.grp_emp_data.ResumeLayout(false);
            this.grp_emp_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_emp_data;
        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.Button btn_emp_search;
        private System.Windows.Forms.ComboBox cmb_search_emp;
        private System.Windows.Forms.GroupBox grp_emp_data;
        private System.Windows.Forms.TextBox txt_emp_nots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_emp_mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_emp_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_emp_adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_emp_salary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_emp_persID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_joptype;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label9;
    }
}