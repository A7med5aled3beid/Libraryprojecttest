namespace Librarypro.PL
{
    partial class frm_store_data
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
            this.pn_store_data = new System.Windows.Forms.Panel();
            this.grc_store_data = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_store_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_store_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_store_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_adress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grb_store_data = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_emp = new System.Windows.Forms.ComboBox();
            this.grb_search = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_store_search = new System.Windows.Forms.Button();
            this.cmb_search_store = new System.Windows.Forms.ComboBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_store_phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_store_nots = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_store_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_store_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_store_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grb_store_data.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.grp_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_store_data
            // 
            this.pn_store_data.BackColor = System.Drawing.Color.White;
            this.pn_store_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_store_data.Controls.Add(this.grc_store_data);
            this.pn_store_data.Controls.Add(this.grb_store_data);
            this.pn_store_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_store_data.Location = new System.Drawing.Point(0, 0);
            this.pn_store_data.Name = "pn_store_data";
            this.pn_store_data.Size = new System.Drawing.Size(1280, 755);
            this.pn_store_data.TabIndex = 4;
            // 
            // grc_store_data
            // 
            this.grc_store_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grc_store_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grc_store_data.Cursor = System.Windows.Forms.Cursors.Default;
            this.grc_store_data.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grc_store_data.Location = new System.Drawing.Point(163, 480);
            this.grc_store_data.LookAndFeel.SkinMaskColor = System.Drawing.Color.Turquoise;
            this.grc_store_data.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.grc_store_data.MainView = this.gridView1;
            this.grc_store_data.Name = "grc_store_data";
            this.grc_store_data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grc_store_data.Size = new System.Drawing.Size(954, 254);
            this.grc_store_data.TabIndex = 3;
            this.grc_store_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.MintCream;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Turquoise;
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_store_id,
            this.col_store_name,
            this.col_store_phone,
            this.col_adress});
            this.gridView1.GridControl = this.grc_store_data;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_store_id
            // 
            this.col_store_id.AppearanceCell.Options.UseTextOptions = true;
            this.col_store_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_store_id.AppearanceHeader.Options.UseTextOptions = true;
            this.col_store_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_store_id.Caption = "كود المخزن";
            this.col_store_id.FieldName = "Store_ID";
            this.col_store_id.Name = "col_store_id";
            this.col_store_id.Visible = true;
            this.col_store_id.VisibleIndex = 3;
            // 
            // col_store_name
            // 
            this.col_store_name.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.col_store_name.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.col_store_name.AppearanceCell.Options.UseBackColor = true;
            this.col_store_name.AppearanceCell.Options.UseTextOptions = true;
            this.col_store_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_store_name.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.col_store_name.AppearanceHeader.Options.UseBackColor = true;
            this.col_store_name.AppearanceHeader.Options.UseTextOptions = true;
            this.col_store_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_store_name.Caption = "اسم المخزن ";
            this.col_store_name.FieldName = "Store_Name";
            this.col_store_name.Name = "col_store_name";
            this.col_store_name.Visible = true;
            this.col_store_name.VisibleIndex = 2;
            // 
            // col_store_phone
            // 
            this.col_store_phone.AppearanceCell.Options.UseTextOptions = true;
            this.col_store_phone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_store_phone.AppearanceHeader.Options.UseTextOptions = true;
            this.col_store_phone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_store_phone.Caption = "التليفون";
            this.col_store_phone.FieldName = "Store_Phone";
            this.col_store_phone.Name = "col_store_phone";
            this.col_store_phone.Visible = true;
            this.col_store_phone.VisibleIndex = 1;
            // 
            // col_adress
            // 
            this.col_adress.AppearanceCell.Options.UseTextOptions = true;
            this.col_adress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_adress.AppearanceHeader.Options.UseTextOptions = true;
            this.col_adress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_adress.Caption = "العنوان";
            this.col_adress.FieldName = "Store_Address";
            this.col_adress.Name = "col_adress";
            this.col_adress.Visible = true;
            this.col_adress.VisibleIndex = 0;
            // 
            // grb_store_data
            // 
            this.grb_store_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_store_data.AutoSize = true;
            this.grb_store_data.BackColor = System.Drawing.Color.Gold;
            this.grb_store_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grb_store_data.Controls.Add(this.label3);
            this.grb_store_data.Controls.Add(this.cmb_emp);
            this.grb_store_data.Controls.Add(this.grb_search);
            this.grb_store_data.Controls.Add(this.txt_adress);
            this.grb_store_data.Controls.Add(this.label9);
            this.grb_store_data.Controls.Add(this.txt_store_phone);
            this.grb_store_data.Controls.Add(this.label10);
            this.grb_store_data.Controls.Add(this.grp_btns);
            this.grb_store_data.Controls.Add(this.txt_store_nots);
            this.grb_store_data.Controls.Add(this.label5);
            this.grb_store_data.Controls.Add(this.txt_store_name);
            this.grb_store_data.Controls.Add(this.label2);
            this.grb_store_data.Location = new System.Drawing.Point(56, 45);
            this.grb_store_data.Name = "grb_store_data";
            this.grb_store_data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grb_store_data.Size = new System.Drawing.Size(1168, 437);
            this.grb_store_data.TabIndex = 1;
            this.grb_store_data.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "اسم الموظف";
            // 
            // cmb_emp
            // 
            this.cmb_emp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_emp.BackColor = System.Drawing.Color.Turquoise;
            this.cmb_emp.FormattingEnabled = true;
            this.cmb_emp.Location = new System.Drawing.Point(283, 124);
            this.cmb_emp.Name = "cmb_emp";
            this.cmb_emp.Size = new System.Drawing.Size(275, 21);
            this.cmb_emp.TabIndex = 22;
            // 
            // grb_search
            // 
            this.grb_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_search.BackColor = System.Drawing.Color.Turquoise;
            this.grb_search.Controls.Add(this.label1);
            this.grb_search.Controls.Add(this.btn_store_search);
            this.grb_search.Controls.Add(this.cmb_search_store);
            this.grb_search.Location = new System.Drawing.Point(283, 19);
            this.grb_search.Name = "grb_search";
            this.grb_search.Size = new System.Drawing.Size(603, 95);
            this.grb_search.TabIndex = 21;
            this.grb_search.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "المخزن";
            // 
            // btn_store_search
            // 
            this.btn_store_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_store_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_store_search.Location = new System.Drawing.Point(234, 46);
            this.btn_store_search.Name = "btn_store_search";
            this.btn_store_search.Size = new System.Drawing.Size(119, 36);
            this.btn_store_search.TabIndex = 1;
            this.btn_store_search.Text = "بحث";
            this.btn_store_search.UseVisualStyleBackColor = true;
            this.btn_store_search.Click += new System.EventHandler(this.btn_store_search_Click);
            // 
            // cmb_search_store
            // 
            this.cmb_search_store.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_search_store.FormattingEnabled = true;
            this.cmb_search_store.Location = new System.Drawing.Point(135, 19);
            this.cmb_search_store.Name = "cmb_search_store";
            this.cmb_search_store.Size = new System.Drawing.Size(332, 21);
            this.cmb_search_store.TabIndex = 0;
            // 
            // txt_adress
            // 
            this.txt_adress.BackColor = System.Drawing.Color.Turquoise;
            this.txt_adress.Location = new System.Drawing.Point(219, 201);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(729, 20);
            this.txt_adress.TabIndex = 20;
            this.txt_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(960, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "العنوان";
            // 
            // txt_store_phone
            // 
            this.txt_store_phone.BackColor = System.Drawing.Color.Turquoise;
            this.txt_store_phone.Location = new System.Drawing.Point(673, 164);
            this.txt_store_phone.Name = "txt_store_phone";
            this.txt_store_phone.Size = new System.Drawing.Size(275, 20);
            this.txt_store_phone.TabIndex = 18;
            this.txt_store_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(971, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "التليفون";
            // 
            // grp_btns
            // 
            this.grp_btns.BackColor = System.Drawing.Color.Turquoise;
            this.grp_btns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_btns.Controls.Add(this.btn_close);
            this.grp_btns.Controls.Add(this.btn_delete);
            this.grp_btns.Controls.Add(this.btn_update);
            this.grp_btns.Controls.Add(this.btn_save);
            this.grp_btns.Controls.Add(this.btn_new);
            this.grp_btns.Location = new System.Drawing.Point(162, 323);
            this.grp_btns.Name = "grp_btns";
            this.grp_btns.Size = new System.Drawing.Size(843, 95);
            this.grp_btns.TabIndex = 16;
            this.grp_btns.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_error_24;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(99, 35);
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
            this.btn_delete.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_delete_24;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(236, 35);
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
            this.btn_update.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Pencil_24;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(375, 35);
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
            this.btn_save.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_check_24;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(511, 35);
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
            this.btn_new.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_add_24;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.Location = new System.Drawing.Point(649, 35);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(119, 36);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txt_store_nots
            // 
            this.txt_store_nots.BackColor = System.Drawing.Color.Turquoise;
            this.txt_store_nots.Location = new System.Drawing.Point(219, 238);
            this.txt_store_nots.Multiline = true;
            this.txt_store_nots.Name = "txt_store_nots";
            this.txt_store_nots.Size = new System.Drawing.Size(729, 67);
            this.txt_store_nots.TabIndex = 9;
            this.txt_store_nots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(960, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ملاحظات";
            // 
            // txt_store_name
            // 
            this.txt_store_name.BackColor = System.Drawing.Color.Turquoise;
            this.txt_store_name.Location = new System.Drawing.Point(673, 126);
            this.txt_store_name.Name = "txt_store_name";
            this.txt_store_name.Size = new System.Drawing.Size(275, 20);
            this.txt_store_name.TabIndex = 3;
            this.txt_store_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(959, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "الاسم";
            // 
            // frm_store_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_store_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_store_data";
            this.Text = "بيانات المخازن";
            this.Load += new System.EventHandler(this.frm_store_data_Load);
            this.pn_store_data.ResumeLayout(false);
            this.pn_store_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_store_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grb_store_data.ResumeLayout(false);
            this.grb_store_data.PerformLayout();
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.grp_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_store_data;
        private DevExpress.XtraGrid.GridControl grc_store_data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_store_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_store_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_store_phone;
        private DevExpress.XtraGrid.Columns.GridColumn col_adress;
        private System.Windows.Forms.GroupBox grb_store_data;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_store_phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_store_nots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_store_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_store_search;
        private System.Windows.Forms.ComboBox cmb_search_store;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_emp;
    }
}