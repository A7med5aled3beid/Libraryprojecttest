namespace Librarypro.PL
{
    partial class frm_joptype
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
            this.pn_jobtype = new System.Windows.Forms.Panel();
            this.grc_jobtype = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_job_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_joptype_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grp_jobtype = new System.Windows.Forms.GroupBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_joptype = new System.Windows.Forms.TextBox();
            this.pn_jobtype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_jobtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grp_jobtype.SuspendLayout();
            this.grp_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_jobtype
            // 
            this.pn_jobtype.BackColor = System.Drawing.Color.White;
            this.pn_jobtype.Controls.Add(this.grc_jobtype);
            this.pn_jobtype.Controls.Add(this.grp_jobtype);
            this.pn_jobtype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_jobtype.Location = new System.Drawing.Point(0, 0);
            this.pn_jobtype.Name = "pn_jobtype";
            this.pn_jobtype.Size = new System.Drawing.Size(1006, 681);
            this.pn_jobtype.TabIndex = 3;
            // 
            // grc_jobtype
            // 
            this.grc_jobtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grc_jobtype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grc_jobtype.Cursor = System.Windows.Forms.Cursors.Default;
            this.grc_jobtype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grc_jobtype.Location = new System.Drawing.Point(12, 283);
            this.grc_jobtype.LookAndFeel.SkinMaskColor = System.Drawing.Color.Turquoise;
            this.grc_jobtype.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.grc_jobtype.MainView = this.gridView1;
            this.grc_jobtype.Name = "grc_jobtype";
            this.grc_jobtype.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grc_jobtype.Size = new System.Drawing.Size(954, 363);
            this.grc_jobtype.TabIndex = 2;
            this.grc_jobtype.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grc_jobtype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grc_jobtype_KeyDown);
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
            this.col_job_name,
            this.col_joptype_id});
            this.gridView1.GridControl = this.grc_jobtype;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_job_name
            // 
            this.col_job_name.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.col_job_name.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.col_job_name.AppearanceCell.Options.UseBackColor = true;
            this.col_job_name.AppearanceCell.Options.UseTextOptions = true;
            this.col_job_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_job_name.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.col_job_name.AppearanceHeader.Options.UseBackColor = true;
            this.col_job_name.AppearanceHeader.Options.UseTextOptions = true;
            this.col_job_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_job_name.Caption = "اسم الوظيفة";
            this.col_job_name.FieldName = "Job_Name";
            this.col_job_name.Name = "col_job_name";
            this.col_job_name.Visible = true;
            this.col_job_name.VisibleIndex = 0;
            // 
            // col_joptype_id
            // 
            this.col_joptype_id.Caption = "كود الوظيفة";
            this.col_joptype_id.FieldName = "Jop_ID";
            this.col_joptype_id.Name = "col_joptype_id";
            // 
            // grp_jobtype
            // 
            this.grp_jobtype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grp_jobtype.AutoSize = true;
            this.grp_jobtype.BackColor = System.Drawing.Color.Turquoise;
            this.grp_jobtype.Controls.Add(this.lb_id);
            this.grp_jobtype.Controls.Add(this.label6);
            this.grp_jobtype.Controls.Add(this.grp_btns);
            this.grp_jobtype.Controls.Add(this.label5);
            this.grp_jobtype.Controls.Add(this.txt_joptype);
            this.grp_jobtype.Location = new System.Drawing.Point(12, 24);
            this.grp_jobtype.Name = "grp_jobtype";
            this.grp_jobtype.Size = new System.Drawing.Size(954, 253);
            this.grp_jobtype.TabIndex = 1;
            this.grp_jobtype.TabStop = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(498, 16);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 16);
            this.lb_id.TabIndex = 37;
            this.lb_id.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 36;
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
            this.grp_btns.Location = new System.Drawing.Point(25, 125);
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
            this.label5.Location = new System.Drawing.Point(577, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "نوع الوظيفة";
            // 
            // txt_joptype
            // 
            this.txt_joptype.Location = new System.Drawing.Point(268, 64);
            this.txt_joptype.Name = "txt_joptype";
            this.txt_joptype.Size = new System.Drawing.Size(275, 20);
            this.txt_joptype.TabIndex = 1;
            // 
            // frm_joptype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 681);
            this.Controls.Add(this.pn_jobtype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_joptype";
            this.Text = "نوع الوظائف";
            this.Load += new System.EventHandler(this.frm_joptype_Load);
            this.pn_jobtype.ResumeLayout(false);
            this.pn_jobtype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_jobtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grp_jobtype.ResumeLayout(false);
            this.grp_jobtype.PerformLayout();
            this.grp_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_jobtype;
        private DevExpress.XtraGrid.GridControl grc_jobtype;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_job_name;
        private System.Windows.Forms.GroupBox grp_jobtype;
        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_joptype;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn col_joptype_id;
    }
}