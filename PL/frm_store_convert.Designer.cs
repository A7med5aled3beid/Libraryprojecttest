namespace Librarypro.PL
{
    partial class frm_store_convert
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
            this.pn_convert_data = new System.Windows.Forms.Panel();
            this.grc_convert_data = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_item_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_convert_fromit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_converted_to = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_quant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_data_convert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grb_convert_data = new System.Windows.Forms.GroupBox();
            this.txt_Qant_to = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.cmb_convert_from = new System.Windows.Forms.ComboBox();
            this.cmb_converted_to = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_item_categ = new System.Windows.Forms.ComboBox();
            this.dtb_convert_time = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_after_quant = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_item_name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_quant_from = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_convert_nots = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quant_convert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_convert_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_convert_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grb_convert_data.SuspendLayout();
            this.grp_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_convert_data
            // 
            this.pn_convert_data.BackColor = System.Drawing.Color.White;
            this.pn_convert_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_convert_data.Controls.Add(this.grc_convert_data);
            this.pn_convert_data.Controls.Add(this.grb_convert_data);
            this.pn_convert_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_convert_data.Location = new System.Drawing.Point(0, 0);
            this.pn_convert_data.Name = "pn_convert_data";
            this.pn_convert_data.Size = new System.Drawing.Size(1280, 755);
            this.pn_convert_data.TabIndex = 3;
            // 
            // grc_convert_data
            // 
            this.grc_convert_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grc_convert_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grc_convert_data.Cursor = System.Windows.Forms.Cursors.Default;
            this.grc_convert_data.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grc_convert_data.Location = new System.Drawing.Point(163, 455);
            this.grc_convert_data.LookAndFeel.SkinMaskColor = System.Drawing.Color.Turquoise;
            this.grc_convert_data.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.grc_convert_data.MainView = this.gridView1;
            this.grc_convert_data.Name = "grc_convert_data";
            this.grc_convert_data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grc_convert_data.Size = new System.Drawing.Size(954, 254);
            this.grc_convert_data.TabIndex = 3;
            this.grc_convert_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.col_item_name,
            this.col_convert_fromit,
            this.col_converted_to,
            this.col_quant,
            this.col_data_convert,
            this.col_notes});
            this.gridView1.GridControl = this.grc_convert_data;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_item_name
            // 
            this.col_item_name.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.col_item_name.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.col_item_name.AppearanceCell.Options.UseBackColor = true;
            this.col_item_name.AppearanceCell.Options.UseTextOptions = true;
            this.col_item_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_item_name.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.col_item_name.AppearanceHeader.Options.UseBackColor = true;
            this.col_item_name.AppearanceHeader.Options.UseTextOptions = true;
            this.col_item_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_item_name.Caption = "اسم الصنف";
            this.col_item_name.FieldName = "Item_Name";
            this.col_item_name.Name = "col_item_name";
            this.col_item_name.Visible = true;
            this.col_item_name.VisibleIndex = 5;
            // 
            // col_convert_fromit
            // 
            this.col_convert_fromit.AppearanceCell.Options.UseTextOptions = true;
            this.col_convert_fromit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_convert_fromit.AppearanceHeader.Options.UseTextOptions = true;
            this.col_convert_fromit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_convert_fromit.Caption = "المخزن المحول منه";
            this.col_convert_fromit.FieldName = "StoreFrom_ID";
            this.col_convert_fromit.Name = "col_convert_fromit";
            this.col_convert_fromit.Visible = true;
            this.col_convert_fromit.VisibleIndex = 4;
            // 
            // col_converted_to
            // 
            this.col_converted_to.AppearanceCell.Options.UseTextOptions = true;
            this.col_converted_to.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_converted_to.AppearanceHeader.Options.UseTextOptions = true;
            this.col_converted_to.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_converted_to.Caption = "المخزن المحول اليه";
            this.col_converted_to.FieldName = "StoryTo_ID";
            this.col_converted_to.Name = "col_converted_to";
            this.col_converted_to.Visible = true;
            this.col_converted_to.VisibleIndex = 3;
            // 
            // col_quant
            // 
            this.col_quant.AppearanceCell.Options.UseTextOptions = true;
            this.col_quant.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_quant.AppearanceHeader.Options.UseTextOptions = true;
            this.col_quant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_quant.Caption = "الكمية";
            this.col_quant.FieldName = "Item_Quantity";
            this.col_quant.Name = "col_quant";
            this.col_quant.Visible = true;
            this.col_quant.VisibleIndex = 2;
            // 
            // col_data_convert
            // 
            this.col_data_convert.AppearanceCell.Options.UseTextOptions = true;
            this.col_data_convert.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_data_convert.AppearanceHeader.Options.UseTextOptions = true;
            this.col_data_convert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_data_convert.Caption = "تاريخ التحويل";
            this.col_data_convert.FieldName = "Con_Date";
            this.col_data_convert.Name = "col_data_convert";
            this.col_data_convert.Visible = true;
            this.col_data_convert.VisibleIndex = 1;
            // 
            // col_notes
            // 
            this.col_notes.AppearanceCell.Options.UseTextOptions = true;
            this.col_notes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_notes.AppearanceHeader.Options.UseTextOptions = true;
            this.col_notes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_notes.Caption = "ملاحظات";
            this.col_notes.FieldName = "Con_Notes";
            this.col_notes.Name = "col_notes";
            this.col_notes.Visible = true;
            this.col_notes.VisibleIndex = 0;
            // 
            // grb_convert_data
            // 
            this.grb_convert_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_convert_data.AutoSize = true;
            this.grb_convert_data.BackColor = System.Drawing.Color.Gold;
            this.grb_convert_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grb_convert_data.Controls.Add(this.txt_Qant_to);
            this.grb_convert_data.Controls.Add(this.btn_convert);
            this.grb_convert_data.Controls.Add(this.cmb_convert_from);
            this.grb_convert_data.Controls.Add(this.cmb_converted_to);
            this.grb_convert_data.Controls.Add(this.label4);
            this.grb_convert_data.Controls.Add(this.cmb_item_categ);
            this.grb_convert_data.Controls.Add(this.dtb_convert_time);
            this.grb_convert_data.Controls.Add(this.label9);
            this.grb_convert_data.Controls.Add(this.txt_after_quant);
            this.grb_convert_data.Controls.Add(this.label10);
            this.grb_convert_data.Controls.Add(this.grp_btns);
            this.grb_convert_data.Controls.Add(this.label8);
            this.grb_convert_data.Controls.Add(this.cmb_item_name);
            this.grb_convert_data.Controls.Add(this.label6);
            this.grb_convert_data.Controls.Add(this.txt_quant_from);
            this.grb_convert_data.Controls.Add(this.label7);
            this.grb_convert_data.Controls.Add(this.txt_convert_nots);
            this.grb_convert_data.Controls.Add(this.label5);
            this.grb_convert_data.Controls.Add(this.label3);
            this.grb_convert_data.Controls.Add(this.txt_quant_convert);
            this.grb_convert_data.Controls.Add(this.label2);
            this.grb_convert_data.Controls.Add(this.label1);
            this.grb_convert_data.Location = new System.Drawing.Point(56, 45);
            this.grb_convert_data.Name = "grb_convert_data";
            this.grb_convert_data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grb_convert_data.Size = new System.Drawing.Size(1168, 404);
            this.grb_convert_data.TabIndex = 1;
            this.grb_convert_data.TabStop = false;
            // 
            // txt_Qant_to
            // 
            this.txt_Qant_to.BackColor = System.Drawing.Color.Turquoise;
            this.txt_Qant_to.Enabled = false;
            this.txt_Qant_to.Location = new System.Drawing.Point(148, 93);
            this.txt_Qant_to.Name = "txt_Qant_to";
            this.txt_Qant_to.Size = new System.Drawing.Size(275, 20);
            this.txt_Qant_to.TabIndex = 27;
            this.txt_Qant_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_convert.Location = new System.Drawing.Point(564, 125);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(60, 26);
            this.btn_convert.TabIndex = 26;
            this.btn_convert.Text = "<<<";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // cmb_convert_from
            // 
            this.cmb_convert_from.BackColor = System.Drawing.Color.Turquoise;
            this.cmb_convert_from.FormattingEnabled = true;
            this.cmb_convert_from.Location = new System.Drawing.Point(641, 55);
            this.cmb_convert_from.Name = "cmb_convert_from";
            this.cmb_convert_from.Size = new System.Drawing.Size(275, 21);
            this.cmb_convert_from.TabIndex = 25;
            this.cmb_convert_from.SelectedValueChanged += new System.EventHandler(this.cmb_convert_from_SelectedValueChanged);
            // 
            // cmb_converted_to
            // 
            this.cmb_converted_to.BackColor = System.Drawing.Color.Turquoise;
            this.cmb_converted_to.FormattingEnabled = true;
            this.cmb_converted_to.Location = new System.Drawing.Point(148, 61);
            this.cmb_converted_to.Name = "cmb_converted_to";
            this.cmb_converted_to.Size = new System.Drawing.Size(275, 21);
            this.cmb_converted_to.TabIndex = 24;
            this.cmb_converted_to.SelectedValueChanged += new System.EventHandler(this.cmb_converted_to_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "المخزن المحول اليه";
            // 
            // cmb_item_categ
            // 
            this.cmb_item_categ.BackColor = System.Drawing.Color.Turquoise;
            this.cmb_item_categ.FormattingEnabled = true;
            this.cmb_item_categ.Location = new System.Drawing.Point(641, 19);
            this.cmb_item_categ.Name = "cmb_item_categ";
            this.cmb_item_categ.Size = new System.Drawing.Size(275, 21);
            this.cmb_item_categ.TabIndex = 22;
            this.cmb_item_categ.SelectedValueChanged += new System.EventHandler(this.cmb_item_categ_SelectedValueChanged);
            // 
            // dtb_convert_time
            // 
            this.dtb_convert_time.Location = new System.Drawing.Point(641, 167);
            this.dtb_convert_time.Name = "dtb_convert_time";
            this.dtb_convert_time.Size = new System.Drawing.Size(275, 20);
            this.dtb_convert_time.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(467, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "الكمية الحالية";
            // 
            // txt_after_quant
            // 
            this.txt_after_quant.BackColor = System.Drawing.Color.Turquoise;
            this.txt_after_quant.Enabled = false;
            this.txt_after_quant.Location = new System.Drawing.Point(147, 132);
            this.txt_after_quant.Name = "txt_after_quant";
            this.txt_after_quant.Size = new System.Drawing.Size(275, 20);
            this.txt_after_quant.TabIndex = 18;
            this.txt_after_quant.Text = "0";
            this.txt_after_quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(486, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "بعدالتحويل";
            // 
            // grp_btns
            // 
            this.grp_btns.BackColor = System.Drawing.Color.Turquoise;
            this.grp_btns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_btns.Controls.Add(this.btn_close);
            this.grp_btns.Controls.Add(this.btn_save);
            this.grp_btns.Controls.Add(this.btn_new);
            this.grp_btns.Location = new System.Drawing.Point(147, 303);
            this.grp_btns.Name = "grp_btns";
            this.grp_btns.Size = new System.Drawing.Size(770, 71);
            this.grp_btns.TabIndex = 16;
            this.grp_btns.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_error_24;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(186, 17);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 36);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_check_24;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(327, 17);
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
            this.btn_new.Location = new System.Drawing.Point(465, 17);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(119, 36);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "اسم الصنف";
            // 
            // cmb_item_name
            // 
            this.cmb_item_name.BackColor = System.Drawing.Color.Turquoise;
            this.cmb_item_name.FormattingEnabled = true;
            this.cmb_item_name.Location = new System.Drawing.Point(148, 26);
            this.cmb_item_name.Name = "cmb_item_name";
            this.cmb_item_name.Size = new System.Drawing.Size(275, 21);
            this.cmb_item_name.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1012, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "التاريخ";
            // 
            // txt_quant_from
            // 
            this.txt_quant_from.BackColor = System.Drawing.Color.Turquoise;
            this.txt_quant_from.Enabled = false;
            this.txt_quant_from.Location = new System.Drawing.Point(642, 90);
            this.txt_quant_from.Name = "txt_quant_from";
            this.txt_quant_from.Size = new System.Drawing.Size(275, 20);
            this.txt_quant_from.TabIndex = 11;
            this.txt_quant_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(966, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "الكمية الحالية";
            // 
            // txt_convert_nots
            // 
            this.txt_convert_nots.BackColor = System.Drawing.Color.Turquoise;
            this.txt_convert_nots.Location = new System.Drawing.Point(148, 205);
            this.txt_convert_nots.Multiline = true;
            this.txt_convert_nots.Name = "txt_convert_nots";
            this.txt_convert_nots.Size = new System.Drawing.Size(769, 67);
            this.txt_convert_nots.TabIndex = 9;
            this.txt_convert_nots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(995, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ملاحظات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(931, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "المخزن المحول منه";
            // 
            // txt_quant_convert
            // 
            this.txt_quant_convert.BackColor = System.Drawing.Color.Turquoise;
            this.txt_quant_convert.Location = new System.Drawing.Point(641, 126);
            this.txt_quant_convert.Name = "txt_quant_convert";
            this.txt_quant_convert.Size = new System.Drawing.Size(275, 20);
            this.txt_quant_convert.TabIndex = 3;
            this.txt_quant_convert.Text = "0";
            this.txt_quant_convert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(959, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "الكمية المحولة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(984, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "فئة الصنف";
            // 
            // frm_store_convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_convert_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_store_convert";
            this.Text = "تحويلات المخازن";
            this.Load += new System.EventHandler(this.frm_store_convert_Load);
            this.pn_convert_data.ResumeLayout(false);
            this.pn_convert_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_convert_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grb_convert_data.ResumeLayout(false);
            this.grb_convert_data.PerformLayout();
            this.grp_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_convert_data;
        private System.Windows.Forms.GroupBox grb_convert_data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_item_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_quant_from;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_convert_nots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quant_convert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtb_convert_time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_after_quant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private DevExpress.XtraGrid.GridControl grc_convert_data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_item_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_convert_fromit;
        private DevExpress.XtraGrid.Columns.GridColumn col_converted_to;
        private DevExpress.XtraGrid.Columns.GridColumn col_quant;
        private DevExpress.XtraGrid.Columns.GridColumn col_data_convert;
        private DevExpress.XtraGrid.Columns.GridColumn col_notes;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.ComboBox cmb_convert_from;
        private System.Windows.Forms.ComboBox cmb_converted_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_item_categ;
        private System.Windows.Forms.TextBox txt_Qant_to;
    }
}