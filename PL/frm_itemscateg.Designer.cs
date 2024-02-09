namespace Librarypro.PL
{
    partial class frm_itemscateg
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
            this.pn_itemcateg = new System.Windows.Forms.Panel();
            this.grc_itemcateg = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_categ_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cat_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grp_item_categ = new System.Windows.Forms.GroupBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_categ_name = new System.Windows.Forms.TextBox();
            this.pn_itemcateg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_itemcateg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grp_item_categ.SuspendLayout();
            this.grp_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_itemcateg
            // 
            this.pn_itemcateg.BackColor = System.Drawing.Color.White;
            this.pn_itemcateg.Controls.Add(this.grc_itemcateg);
            this.pn_itemcateg.Controls.Add(this.grp_item_categ);
            this.pn_itemcateg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_itemcateg.Location = new System.Drawing.Point(0, 0);
            this.pn_itemcateg.Name = "pn_itemcateg";
            this.pn_itemcateg.Size = new System.Drawing.Size(1280, 755);
            this.pn_itemcateg.TabIndex = 2;
            // 
            // grc_itemcateg
            // 
            this.grc_itemcateg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grc_itemcateg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grc_itemcateg.Cursor = System.Windows.Forms.Cursors.Default;
            this.grc_itemcateg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grc_itemcateg.Location = new System.Drawing.Point(149, 283);
            this.grc_itemcateg.LookAndFeel.SkinMaskColor = System.Drawing.Color.Turquoise;
            this.grc_itemcateg.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.grc_itemcateg.MainView = this.gridView1;
            this.grc_itemcateg.Name = "grc_itemcateg";
            this.grc_itemcateg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grc_itemcateg.Size = new System.Drawing.Size(954, 437);
            this.grc_itemcateg.TabIndex = 2;
            this.grc_itemcateg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grc_itemcateg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grc_itemcateg_KeyDown);
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
            this.col_categ_item,
            this.col_cat_id});
            this.gridView1.GridControl = this.grc_itemcateg;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_categ_item
            // 
            this.col_categ_item.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.col_categ_item.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.col_categ_item.AppearanceCell.Options.UseBackColor = true;
            this.col_categ_item.AppearanceCell.Options.UseTextOptions = true;
            this.col_categ_item.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_categ_item.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.col_categ_item.AppearanceHeader.Options.UseBackColor = true;
            this.col_categ_item.AppearanceHeader.Options.UseTextOptions = true;
            this.col_categ_item.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_categ_item.Caption = "فئة الصنف";
            this.col_categ_item.FieldName = "Category_Name";
            this.col_categ_item.Name = "col_categ_item";
            this.col_categ_item.OptionsColumn.ReadOnly = true;
            this.col_categ_item.Visible = true;
            this.col_categ_item.VisibleIndex = 0;
            // 
            // col_cat_id
            // 
            this.col_cat_id.Caption = "كود الصنف";
            this.col_cat_id.FieldName = "Category_ID";
            this.col_cat_id.Name = "col_cat_id";
            this.col_cat_id.OptionsColumn.ReadOnly = true;
            // 
            // grp_item_categ
            // 
            this.grp_item_categ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grp_item_categ.AutoSize = true;
            this.grp_item_categ.BackColor = System.Drawing.Color.Turquoise;
            this.grp_item_categ.Controls.Add(this.lb_id);
            this.grp_item_categ.Controls.Add(this.label6);
            this.grp_item_categ.Controls.Add(this.grp_btns);
            this.grp_item_categ.Controls.Add(this.label5);
            this.grp_item_categ.Controls.Add(this.txt_categ_name);
            this.grp_item_categ.Location = new System.Drawing.Point(56, 24);
            this.grp_item_categ.Name = "grp_item_categ";
            this.grp_item_categ.Size = new System.Drawing.Size(1168, 253);
            this.grp_item_categ.TabIndex = 1;
            this.grp_item_categ.TabStop = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(585, 16);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 16);
            this.lb_id.TabIndex = 33;
            this.lb_id.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID";
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
            this.grp_btns.Location = new System.Drawing.Point(154, 125);
            this.grp_btns.Name = "grp_btns";
            this.grp_btns.Size = new System.Drawing.Size(860, 95);
            this.grp_btns.TabIndex = 10;
            this.grp_btns.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_error_24;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(100, 34);
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
            this.btn_delete.Location = new System.Drawing.Point(237, 34);
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
            this.btn_update.Location = new System.Drawing.Point(376, 34);
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
            this.btn_save.Location = new System.Drawing.Point(512, 34);
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
            this.btn_new.Location = new System.Drawing.Point(650, 34);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(119, 36);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(706, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "فئة الصنف";
            // 
            // txt_categ_name
            // 
            this.txt_categ_name.Location = new System.Drawing.Point(397, 64);
            this.txt_categ_name.Name = "txt_categ_name";
            this.txt_categ_name.Size = new System.Drawing.Size(275, 20);
            this.txt_categ_name.TabIndex = 1;
            // 
            // frm_itemscateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_itemcateg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_itemscateg";
            this.Text = "فئات الاصناف";
            this.Load += new System.EventHandler(this.frm_itemscateg_Load);
            this.pn_itemcateg.ResumeLayout(false);
            this.pn_itemcateg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_itemcateg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grp_item_categ.ResumeLayout(false);
            this.grp_item_categ.PerformLayout();
            this.grp_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_itemcateg;
        private DevExpress.XtraGrid.GridControl grc_itemcateg;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_categ_item;
        private System.Windows.Forms.GroupBox grp_item_categ;
        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_categ_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_cat_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label6;
    }
}