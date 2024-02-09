namespace Librarypro.PL
{
    partial class frm_categories_data
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
            this.pn_categ_item = new System.Windows.Forms.Panel();
            this.grc_item_categ = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_item_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_categ_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_categ_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_categ_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_minimum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grp_item_categ = new System.Windows.Forms.GroupBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.cmb_categ_item = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_categ_minim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_categ_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_categ_item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_item_categ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grp_item_categ.SuspendLayout();
            this.grp_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_categ_item
            // 
            this.pn_categ_item.BackColor = System.Drawing.Color.White;
            this.pn_categ_item.Controls.Add(this.grc_item_categ);
            this.pn_categ_item.Controls.Add(this.grp_item_categ);
            this.pn_categ_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_categ_item.Location = new System.Drawing.Point(0, 0);
            this.pn_categ_item.Name = "pn_categ_item";
            this.pn_categ_item.Size = new System.Drawing.Size(1280, 755);
            this.pn_categ_item.TabIndex = 1;
            // 
            // grc_item_categ
            // 
            this.grc_item_categ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grc_item_categ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grc_item_categ.Cursor = System.Windows.Forms.Cursors.Default;
            this.grc_item_categ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grc_item_categ.Location = new System.Drawing.Point(149, 328);
            this.grc_item_categ.LookAndFeel.SkinMaskColor = System.Drawing.Color.Turquoise;
            this.grc_item_categ.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.grc_item_categ.MainView = this.gridView1;
            this.grc_item_categ.Name = "grc_item_categ";
            this.grc_item_categ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grc_item_categ.Size = new System.Drawing.Size(954, 387);
            this.grc_item_categ.TabIndex = 2;
            this.grc_item_categ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grc_item_categ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grc_item_categ_KeyDown);
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
            this.col_item_id,
            this.col_categ_name,
            this.col_categ_item,
            this.col_categ_ID,
            this.col_minimum});
            this.gridView1.GridControl = this.grc_item_categ;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_item_id
            // 
            this.col_item_id.Caption = "gridColumn1";
            this.col_item_id.FieldName = "Item_ID";
            this.col_item_id.Name = "col_item_id";
            this.col_item_id.OptionsColumn.ReadOnly = true;
            // 
            // col_categ_name
            // 
            this.col_categ_name.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.col_categ_name.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.col_categ_name.AppearanceCell.BorderColor = System.Drawing.Color.White;
            this.col_categ_name.AppearanceCell.Options.UseBackColor = true;
            this.col_categ_name.AppearanceCell.Options.UseBorderColor = true;
            this.col_categ_name.AppearanceCell.Options.UseTextOptions = true;
            this.col_categ_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_categ_name.AppearanceHeader.Options.UseTextOptions = true;
            this.col_categ_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_categ_name.Caption = "اسم الصنف";
            this.col_categ_name.FieldName = "Item_Name";
            this.col_categ_name.Name = "col_categ_name";
            this.col_categ_name.OptionsColumn.ReadOnly = true;
            this.col_categ_name.Visible = true;
            this.col_categ_name.VisibleIndex = 2;
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
            this.col_categ_item.VisibleIndex = 1;
            // 
            // col_categ_ID
            // 
            this.col_categ_ID.Caption = "gridColumn1";
            this.col_categ_ID.FieldName = "Category_ID";
            this.col_categ_ID.Name = "col_categ_ID";
            this.col_categ_ID.OptionsColumn.ReadOnly = true;
            // 
            // col_minimum
            // 
            this.col_minimum.AppearanceCell.Options.UseTextOptions = true;
            this.col_minimum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_minimum.AppearanceHeader.Options.UseTextOptions = true;
            this.col_minimum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_minimum.Caption = "الحد الادنى";
            this.col_minimum.FieldName = "Item_minimum";
            this.col_minimum.Name = "col_minimum";
            this.col_minimum.Visible = true;
            this.col_minimum.VisibleIndex = 0;
            // 
            // grp_item_categ
            // 
            this.grp_item_categ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grp_item_categ.AutoSize = true;
            this.grp_item_categ.BackColor = System.Drawing.Color.Turquoise;
            this.grp_item_categ.Controls.Add(this.lb_id);
            this.grp_item_categ.Controls.Add(this.label6);
            this.grp_item_categ.Controls.Add(this.grp_btns);
            this.grp_item_categ.Controls.Add(this.cmb_categ_item);
            this.grp_item_categ.Controls.Add(this.label5);
            this.grp_item_categ.Controls.Add(this.txt_categ_minim);
            this.grp_item_categ.Controls.Add(this.label3);
            this.grp_item_categ.Controls.Add(this.txt_categ_name);
            this.grp_item_categ.Controls.Add(this.label1);
            this.grp_item_categ.Location = new System.Drawing.Point(56, 24);
            this.grp_item_categ.Name = "grp_item_categ";
            this.grp_item_categ.Size = new System.Drawing.Size(1168, 298);
            this.grp_item_categ.TabIndex = 1;
            this.grp_item_categ.TabStop = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(592, 16);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 16);
            this.lb_id.TabIndex = 35;
            this.lb_id.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 34;
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
            this.grp_btns.Location = new System.Drawing.Point(148, 172);
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
            // cmb_categ_item
            // 
            this.cmb_categ_item.FormattingEnabled = true;
            this.cmb_categ_item.Location = new System.Drawing.Point(226, 58);
            this.cmb_categ_item.Name = "cmb_categ_item";
            this.cmb_categ_item.Size = new System.Drawing.Size(275, 21);
            this.cmb_categ_item.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "فئة الصنف";
            // 
            // txt_categ_minim
            // 
            this.txt_categ_minim.Location = new System.Drawing.Point(643, 127);
            this.txt_categ_minim.Name = "txt_categ_minim";
            this.txt_categ_minim.Size = new System.Drawing.Size(275, 20);
            this.txt_categ_minim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(945, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "الحد الادنى";
            // 
            // txt_categ_name
            // 
            this.txt_categ_name.Location = new System.Drawing.Point(643, 60);
            this.txt_categ_name.Name = "txt_categ_name";
            this.txt_categ_name.Size = new System.Drawing.Size(275, 20);
            this.txt_categ_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(940, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // frm_categories_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_categ_item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_categories_data";
            this.Text = "الاصناف";
            this.Load += new System.EventHandler(this.frm_categories_data_Load);
            this.pn_categ_item.ResumeLayout(false);
            this.pn_categ_item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_item_categ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grp_item_categ.ResumeLayout(false);
            this.grp_item_categ.PerformLayout();
            this.grp_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_categ_item;
        private System.Windows.Forms.GroupBox grp_item_categ;
        private System.Windows.Forms.TextBox txt_categ_minim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_categ_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl grc_item_categ;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_categ_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_categ_item;
        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ComboBox cmb_categ_item;
        private DevExpress.XtraGrid.Columns.GridColumn col_item_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_categ_ID;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn col_minimum;
    }
}