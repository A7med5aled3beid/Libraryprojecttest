namespace Librarypro.PL
{
    partial class frm_cust_data
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
            this.pn_cust_data = new System.Windows.Forms.Panel();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.cmb_cust_search = new System.Windows.Forms.ComboBox();
            this.grp_cust_data = new System.Windows.Forms.GroupBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cust_nots = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cust_mobil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cust_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cust_adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cust_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.pn_cust_data.SuspendLayout();
            this.grp_btns.SuspendLayout();
            this.grp_search.SuspendLayout();
            this.grp_cust_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_cust_data
            // 
            this.pn_cust_data.BackColor = System.Drawing.Color.White;
            this.pn_cust_data.Controls.Add(this.grp_btns);
            this.pn_cust_data.Controls.Add(this.grp_search);
            this.pn_cust_data.Controls.Add(this.grp_cust_data);
            this.pn_cust_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cust_data.Location = new System.Drawing.Point(0, 0);
            this.pn_cust_data.Name = "pn_cust_data";
            this.pn_cust_data.Size = new System.Drawing.Size(1280, 755);
            this.pn_cust_data.TabIndex = 0;
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
            // grp_search
            // 
            this.grp_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grp_search.BackColor = System.Drawing.Color.Turquoise;
            this.grp_search.Controls.Add(this.btn_search);
            this.grp_search.Controls.Add(this.cmb_cust_search);
            this.grp_search.Location = new System.Drawing.Point(442, 38);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(396, 95);
            this.grp_search.TabIndex = 2;
            this.grp_search.TabStop = false;
            // 
            // cmb_cust_search
            // 
            this.cmb_cust_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_cust_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_cust_search.FormattingEnabled = true;
            this.cmb_cust_search.Location = new System.Drawing.Point(44, 19);
            this.cmb_cust_search.Name = "cmb_cust_search";
            this.cmb_cust_search.Size = new System.Drawing.Size(332, 21);
            this.cmb_cust_search.TabIndex = 0;
            this.cmb_cust_search.Click += new System.EventHandler(this.cmb_cust_search_Click);
            // 
            // grp_cust_data
            // 
            this.grp_cust_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grp_cust_data.AutoSize = true;
            this.grp_cust_data.BackColor = System.Drawing.Color.Turquoise;
            this.grp_cust_data.Controls.Add(this.lb_id);
            this.grp_cust_data.Controls.Add(this.label6);
            this.grp_cust_data.Controls.Add(this.txt_cust_nots);
            this.grp_cust_data.Controls.Add(this.label5);
            this.grp_cust_data.Controls.Add(this.txt_cust_mobil);
            this.grp_cust_data.Controls.Add(this.label4);
            this.grp_cust_data.Controls.Add(this.txt_cust_phone);
            this.grp_cust_data.Controls.Add(this.label3);
            this.grp_cust_data.Controls.Add(this.txt_cust_adress);
            this.grp_cust_data.Controls.Add(this.label2);
            this.grp_cust_data.Controls.Add(this.txt_cust_name);
            this.grp_cust_data.Controls.Add(this.label1);
            this.grp_cust_data.Location = new System.Drawing.Point(56, 149);
            this.grp_cust_data.Name = "grp_cust_data";
            this.grp_cust_data.Size = new System.Drawing.Size(1168, 453);
            this.grp_cust_data.TabIndex = 1;
            this.grp_cust_data.TabStop = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(605, 16);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 16);
            this.lb_id.TabIndex = 31;
            this.lb_id.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "ID";
            // 
            // txt_cust_nots
            // 
            this.txt_cust_nots.Location = new System.Drawing.Point(195, 236);
            this.txt_cust_nots.Multiline = true;
            this.txt_cust_nots.Name = "txt_cust_nots";
            this.txt_cust_nots.Size = new System.Drawing.Size(676, 119);
            this.txt_cust_nots.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(912, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "ملاحظات";
            // 
            // txt_cust_mobil
            // 
            this.txt_cust_mobil.Location = new System.Drawing.Point(195, 163);
            this.txt_cust_mobil.Name = "txt_cust_mobil";
            this.txt_cust_mobil.Size = new System.Drawing.Size(275, 20);
            this.txt_cust_mobil.TabIndex = 27;
            this.txt_cust_mobil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "الموبايل";
            // 
            // txt_cust_phone
            // 
            this.txt_cust_phone.Location = new System.Drawing.Point(596, 164);
            this.txt_cust_phone.Name = "txt_cust_phone";
            this.txt_cust_phone.Size = new System.Drawing.Size(275, 20);
            this.txt_cust_phone.TabIndex = 25;
            this.txt_cust_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(919, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "التليفون";
            // 
            // txt_cust_adress
            // 
            this.txt_cust_adress.Location = new System.Drawing.Point(195, 100);
            this.txt_cust_adress.Name = "txt_cust_adress";
            this.txt_cust_adress.Size = new System.Drawing.Size(275, 20);
            this.txt_cust_adress.TabIndex = 23;
            this.txt_cust_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "العنوان";
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.Location = new System.Drawing.Point(596, 98);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Size = new System.Drawing.Size(275, 20);
            this.txt_cust_name.TabIndex = 21;
            this.txt_cust_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(893, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "اسم العميل";
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
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.Image = global::Librarypro.Properties.Resources.Custom_Icon_Design_Flatastic_4_Male_user_search_24;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(143, 46);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(119, 36);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frm_cust_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_cust_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_cust_data";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بيانات عميل";
            this.Load += new System.EventHandler(this.frm_cust_data_Load);
            this.pn_cust_data.ResumeLayout(false);
            this.pn_cust_data.PerformLayout();
            this.grp_btns.ResumeLayout(false);
            this.grp_search.ResumeLayout(false);
            this.grp_cust_data.ResumeLayout(false);
            this.grp_cust_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_cust_search;
        private System.Windows.Forms.GroupBox grp_cust_data;
        public System.Windows.Forms.Panel pn_cust_data;
        private System.Windows.Forms.TextBox txt_cust_nots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cust_mobil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cust_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cust_adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cust_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label6;
    }
}