namespace Librarypro.PL
{
    partial class frm_ven_data
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
            this.pn_ven_data = new System.Windows.Forms.Panel();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.btn_ven_search = new System.Windows.Forms.Button();
            this.cmb_search_ven = new System.Windows.Forms.ComboBox();
            this.grp_ven_data = new System.Windows.Forms.GroupBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ven_nots = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ven_mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ven_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ven_adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ven_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_ven_data.SuspendLayout();
            this.grp_btns.SuspendLayout();
            this.grp_search.SuspendLayout();
            this.grp_ven_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_ven_data
            // 
            this.pn_ven_data.BackColor = System.Drawing.Color.White;
            this.pn_ven_data.Controls.Add(this.grp_btns);
            this.pn_ven_data.Controls.Add(this.grp_search);
            this.pn_ven_data.Controls.Add(this.grp_ven_data);
            this.pn_ven_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ven_data.Location = new System.Drawing.Point(0, 0);
            this.pn_ven_data.Name = "pn_ven_data";
            this.pn_ven_data.Size = new System.Drawing.Size(1280, 755);
            this.pn_ven_data.TabIndex = 1;
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
            this.btn_close.Location = new System.Drawing.Point(143, 33);
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
            this.btn_delete.Location = new System.Drawing.Point(280, 33);
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
            this.btn_update.Location = new System.Drawing.Point(419, 33);
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
            this.btn_save.Location = new System.Drawing.Point(555, 33);
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
            this.btn_new.Location = new System.Drawing.Point(693, 33);
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
            this.grp_search.Controls.Add(this.btn_ven_search);
            this.grp_search.Controls.Add(this.cmb_search_ven);
            this.grp_search.Location = new System.Drawing.Point(339, 38);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(603, 95);
            this.grp_search.TabIndex = 2;
            this.grp_search.TabStop = false;
            // 
            // btn_ven_search
            // 
            this.btn_ven_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ven_search.Image = global::Librarypro.Properties.Resources.Custom_Icon_Design_Flatastic_4_Male_user_search_24;
            this.btn_ven_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ven_search.Location = new System.Drawing.Point(234, 46);
            this.btn_ven_search.Name = "btn_ven_search";
            this.btn_ven_search.Size = new System.Drawing.Size(119, 36);
            this.btn_ven_search.TabIndex = 1;
            this.btn_ven_search.Text = "بحث";
            this.btn_ven_search.UseVisualStyleBackColor = true;
            this.btn_ven_search.Click += new System.EventHandler(this.btn_ven_search_Click);
            // 
            // cmb_search_ven
            // 
            this.cmb_search_ven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_search_ven.FormattingEnabled = true;
            this.cmb_search_ven.Location = new System.Drawing.Point(135, 19);
            this.cmb_search_ven.Name = "cmb_search_ven";
            this.cmb_search_ven.Size = new System.Drawing.Size(332, 21);
            this.cmb_search_ven.TabIndex = 0;
            // 
            // grp_ven_data
            // 
            this.grp_ven_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grp_ven_data.AutoSize = true;
            this.grp_ven_data.BackColor = System.Drawing.Color.Turquoise;
            this.grp_ven_data.Controls.Add(this.lb_id);
            this.grp_ven_data.Controls.Add(this.label6);
            this.grp_ven_data.Controls.Add(this.txt_ven_nots);
            this.grp_ven_data.Controls.Add(this.label5);
            this.grp_ven_data.Controls.Add(this.txt_ven_mobile);
            this.grp_ven_data.Controls.Add(this.label4);
            this.grp_ven_data.Controls.Add(this.txt_ven_phone);
            this.grp_ven_data.Controls.Add(this.label3);
            this.grp_ven_data.Controls.Add(this.txt_ven_adress);
            this.grp_ven_data.Controls.Add(this.label2);
            this.grp_ven_data.Controls.Add(this.txt_ven_name);
            this.grp_ven_data.Controls.Add(this.label1);
            this.grp_ven_data.Location = new System.Drawing.Point(52, 149);
            this.grp_ven_data.Name = "grp_ven_data";
            this.grp_ven_data.Size = new System.Drawing.Size(1176, 453);
            this.grp_ven_data.TabIndex = 1;
            this.grp_ven_data.TabStop = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(573, 16);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 16);
            this.lb_id.TabIndex = 33;
            this.lb_id.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID";
            // 
            // txt_ven_nots
            // 
            this.txt_ven_nots.Location = new System.Drawing.Point(199, 198);
            this.txt_ven_nots.Multiline = true;
            this.txt_ven_nots.Name = "txt_ven_nots";
            this.txt_ven_nots.Size = new System.Drawing.Size(676, 119);
            this.txt_ven_nots.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(916, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ملاحظات";
            // 
            // txt_ven_mobile
            // 
            this.txt_ven_mobile.Location = new System.Drawing.Point(199, 125);
            this.txt_ven_mobile.Name = "txt_ven_mobile";
            this.txt_ven_mobile.Size = new System.Drawing.Size(275, 20);
            this.txt_ven_mobile.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "الموبايل";
            // 
            // txt_ven_phone
            // 
            this.txt_ven_phone.Location = new System.Drawing.Point(600, 126);
            this.txt_ven_phone.Name = "txt_ven_phone";
            this.txt_ven_phone.Size = new System.Drawing.Size(275, 20);
            this.txt_ven_phone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(923, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "التليفون";
            // 
            // txt_ven_adress
            // 
            this.txt_ven_adress.Location = new System.Drawing.Point(199, 62);
            this.txt_ven_adress.Name = "txt_ven_adress";
            this.txt_ven_adress.Size = new System.Drawing.Size(275, 20);
            this.txt_ven_adress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "العنوان";
            // 
            // txt_ven_name
            // 
            this.txt_ven_name.Location = new System.Drawing.Point(600, 60);
            this.txt_ven_name.Name = "txt_ven_name";
            this.txt_ven_name.Size = new System.Drawing.Size(275, 20);
            this.txt_ven_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(897, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المورد";
            // 
            // frm_ven_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_ven_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ven_data";
            this.Text = "بيانات مورد";
            this.Load += new System.EventHandler(this.frm_ven_data_Load);
            this.pn_ven_data.ResumeLayout(false);
            this.pn_ven_data.PerformLayout();
            this.grp_btns.ResumeLayout(false);
            this.grp_search.ResumeLayout(false);
            this.grp_ven_data.ResumeLayout(false);
            this.grp_ven_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_ven_data;
        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.Button btn_ven_search;
        private System.Windows.Forms.ComboBox cmb_search_ven;
        private System.Windows.Forms.GroupBox grp_ven_data;
        private System.Windows.Forms.TextBox txt_ven_nots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ven_mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ven_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ven_adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ven_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label6;
    }
}