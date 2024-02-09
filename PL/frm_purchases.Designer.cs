namespace Librarypro.PL
{
    partial class frm_purchases
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
            this.pn_purchases = new System.Windows.Forms.Panel();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.dgv_purchase = new System.Windows.Forms.DataGridView();
            this.Category_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Categort_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cuanty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_payed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_remain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total_value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_item_price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_item_catog = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_item_name = new System.Windows.Forms.ComboBox();
            this.btn_purchases_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.grb_convert_data = new System.Windows.Forms.GroupBox();
            this.cmb_vendor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_convert = new System.Windows.Forms.ComboBox();
            this.dtb_purchases_time = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pruchases_nots = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_purchases.SuspendLayout();
            this.grp_btns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase)).BeginInit();
            this.grb_convert_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_purchases
            // 
            this.pn_purchases.BackColor = System.Drawing.Color.White;
            this.pn_purchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_purchases.Controls.Add(this.grp_btns);
            this.pn_purchases.Controls.Add(this.grb_convert_data);
            this.pn_purchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_purchases.Location = new System.Drawing.Point(0, 0);
            this.pn_purchases.Name = "pn_purchases";
            this.pn_purchases.Size = new System.Drawing.Size(1280, 755);
            this.pn_purchases.TabIndex = 4;
            // 
            // grp_btns
            // 
            this.grp_btns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grp_btns.BackColor = System.Drawing.Color.Turquoise;
            this.grp_btns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_btns.Controls.Add(this.dgv_purchase);
            this.grp_btns.Controls.Add(this.txt_payed);
            this.grp_btns.Controls.Add(this.label2);
            this.grp_btns.Controls.Add(this.txt_remain);
            this.grp_btns.Controls.Add(this.label4);
            this.grp_btns.Controls.Add(this.txt_total_value);
            this.grp_btns.Controls.Add(this.label7);
            this.grp_btns.Controls.Add(this.txt_quant);
            this.grp_btns.Controls.Add(this.label14);
            this.grp_btns.Controls.Add(this.txt_value);
            this.grp_btns.Controls.Add(this.label13);
            this.grp_btns.Controls.Add(this.txt_item_price);
            this.grp_btns.Controls.Add(this.label12);
            this.grp_btns.Controls.Add(this.label11);
            this.grp_btns.Controls.Add(this.cmb_item_catog);
            this.grp_btns.Controls.Add(this.label8);
            this.grp_btns.Controls.Add(this.cmb_item_name);
            this.grp_btns.Controls.Add(this.btn_purchases_add);
            this.grp_btns.Controls.Add(this.btn_close);
            this.grp_btns.Controls.Add(this.btn_save);
            this.grp_btns.Controls.Add(this.btn_new);
            this.grp_btns.Location = new System.Drawing.Point(52, 193);
            this.grp_btns.Name = "grp_btns";
            this.grp_btns.Size = new System.Drawing.Size(1176, 518);
            this.grp_btns.TabIndex = 17;
            this.grp_btns.TabStop = false;
            // 
            // dgv_purchase
            // 
            this.dgv_purchase.AllowUserToAddRows = false;
            this.dgv_purchase.BackgroundColor = System.Drawing.Color.White;
            this.dgv_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_purchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_ID,
            this.Item_ID,
            this.col_Categort_name,
            this.col_item_name,
            this.col_price,
            this.col_cuanty,
            this.col_value});
            this.dgv_purchase.Location = new System.Drawing.Point(191, 147);
            this.dgv_purchase.Name = "dgv_purchase";
            this.dgv_purchase.ReadOnly = true;
            this.dgv_purchase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_purchase.Size = new System.Drawing.Size(795, 280);
            this.dgv_purchase.TabIndex = 44;
            this.dgv_purchase.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgv_purchase_CellStateChanged);
            this.dgv_purchase.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_purchase_RowsRemoved);
            // 
            // Category_ID
            // 
            this.Category_ID.HeaderText = "";
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.ReadOnly = true;
            this.Category_ID.Visible = false;
            // 
            // Item_ID
            // 
            this.Item_ID.HeaderText = "";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.ReadOnly = true;
            this.Item_ID.Visible = false;
            // 
            // col_Categort_name
            // 
            this.col_Categort_name.HeaderText = "فئة الصنف";
            this.col_Categort_name.Name = "col_Categort_name";
            this.col_Categort_name.ReadOnly = true;
            this.col_Categort_name.Width = 150;
            // 
            // col_item_name
            // 
            this.col_item_name.HeaderText = "اسم الصنف";
            this.col_item_name.Name = "col_item_name";
            this.col_item_name.ReadOnly = true;
            this.col_item_name.Width = 150;
            // 
            // col_price
            // 
            this.col_price.HeaderText = "سعر الصنف";
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            this.col_price.Width = 150;
            // 
            // col_cuanty
            // 
            this.col_cuanty.HeaderText = "الكمية";
            this.col_cuanty.Name = "col_cuanty";
            this.col_cuanty.ReadOnly = true;
            this.col_cuanty.Width = 150;
            // 
            // col_value
            // 
            this.col_value.HeaderText = "القيمة";
            this.col_value.Name = "col_value";
            this.col_value.ReadOnly = true;
            this.col_value.Width = 150;
            // 
            // txt_payed
            // 
            this.txt_payed.BackColor = System.Drawing.Color.OrangeRed;
            this.txt_payed.Location = new System.Drawing.Point(517, 445);
            this.txt_payed.Name = "txt_payed";
            this.txt_payed.Size = new System.Drawing.Size(154, 20);
            this.txt_payed.TabIndex = 43;
            this.txt_payed.Text = "0";
            this.txt_payed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_payed.TextChanged += new System.EventHandler(this.txt_payed_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(680, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "المدفوع";
            // 
            // txt_remain
            // 
            this.txt_remain.BackColor = System.Drawing.Color.OrangeRed;
            this.txt_remain.Enabled = false;
            this.txt_remain.Location = new System.Drawing.Point(280, 445);
            this.txt_remain.Name = "txt_remain";
            this.txt_remain.Size = new System.Drawing.Size(154, 20);
            this.txt_remain.TabIndex = 41;
            this.txt_remain.Text = "0";
            this.txt_remain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "المتبقي";
            // 
            // txt_total_value
            // 
            this.txt_total_value.BackColor = System.Drawing.Color.OrangeRed;
            this.txt_total_value.Enabled = false;
            this.txt_total_value.Location = new System.Drawing.Point(743, 445);
            this.txt_total_value.Name = "txt_total_value";
            this.txt_total_value.Size = new System.Drawing.Size(154, 20);
            this.txt_total_value.TabIndex = 39;
            this.txt_total_value.Text = "0";
            this.txt_total_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_total_value.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(909, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "اجمالى الفاتورة";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_quant
            // 
            this.txt_quant.BackColor = System.Drawing.Color.Yellow;
            this.txt_quant.Location = new System.Drawing.Point(506, 66);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(154, 20);
            this.txt_quant.TabIndex = 37;
            this.txt_quant.Text = "0";
            this.txt_quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quant.TextChanged += new System.EventHandler(this.txt_quant_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(702, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "الكمية";
            // 
            // txt_value
            // 
            this.txt_value.BackColor = System.Drawing.Color.Yellow;
            this.txt_value.Location = new System.Drawing.Point(212, 66);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(154, 20);
            this.txt_value.TabIndex = 35;
            this.txt_value.Text = "0";
            this.txt_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(408, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "القيمة";
            // 
            // txt_item_price
            // 
            this.txt_item_price.BackColor = System.Drawing.Color.Yellow;
            this.txt_item_price.Location = new System.Drawing.Point(812, 66);
            this.txt_item_price.Name = "txt_item_price";
            this.txt_item_price.Size = new System.Drawing.Size(154, 20);
            this.txt_item_price.TabIndex = 33;
            this.txt_item_price.Text = "0";
            this.txt_item_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_item_price.TextChanged += new System.EventHandler(this.txt_item_price_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(984, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "سعر الصنف";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(992, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "فئة الصنف";
            // 
            // cmb_item_catog
            // 
            this.cmb_item_catog.BackColor = System.Drawing.Color.Yellow;
            this.cmb_item_catog.FormattingEnabled = true;
            this.cmb_item_catog.Location = new System.Drawing.Point(686, 23);
            this.cmb_item_catog.Name = "cmb_item_catog";
            this.cmb_item_catog.Size = new System.Drawing.Size(275, 21);
            this.cmb_item_catog.TabIndex = 30;
            this.cmb_item_catog.SelectedValueChanged += new System.EventHandler(this.cmb_item_catog_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(540, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "اسم الصنف";
            // 
            // cmb_item_name
            // 
            this.cmb_item_name.BackColor = System.Drawing.Color.Yellow;
            this.cmb_item_name.FormattingEnabled = true;
            this.cmb_item_name.Location = new System.Drawing.Point(210, 20);
            this.cmb_item_name.Name = "cmb_item_name";
            this.cmb_item_name.Size = new System.Drawing.Size(275, 21);
            this.cmb_item_name.TabIndex = 28;
            // 
            // btn_purchases_add
            // 
            this.btn_purchases_add.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_purchases_add.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchases_add.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_add_24;
            this.btn_purchases_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchases_add.Location = new System.Drawing.Point(359, 109);
            this.btn_purchases_add.Name = "btn_purchases_add";
            this.btn_purchases_add.Size = new System.Drawing.Size(460, 32);
            this.btn_purchases_add.TabIndex = 27;
            this.btn_purchases_add.Text = "اضافة";
            this.btn_purchases_add.UseVisualStyleBackColor = false;
            this.btn_purchases_add.Click += new System.EventHandler(this.btn_purchases_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_error_24;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(391, 477);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_check_24;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(528, 477);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 30);
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
            this.btn_new.Location = new System.Drawing.Point(666, 477);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(119, 30);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // grb_convert_data
            // 
            this.grb_convert_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_convert_data.BackColor = System.Drawing.Color.DarkCyan;
            this.grb_convert_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grb_convert_data.Controls.Add(this.cmb_vendor);
            this.grb_convert_data.Controls.Add(this.label9);
            this.grb_convert_data.Controls.Add(this.cmb_convert);
            this.grb_convert_data.Controls.Add(this.dtb_purchases_time);
            this.grb_convert_data.Controls.Add(this.label6);
            this.grb_convert_data.Controls.Add(this.txt_pruchases_nots);
            this.grb_convert_data.Controls.Add(this.label5);
            this.grb_convert_data.Controls.Add(this.label3);
            this.grb_convert_data.Location = new System.Drawing.Point(52, 43);
            this.grb_convert_data.Name = "grb_convert_data";
            this.grb_convert_data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grb_convert_data.Size = new System.Drawing.Size(1176, 144);
            this.grb_convert_data.TabIndex = 1;
            this.grb_convert_data.TabStop = false;
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.BackColor = System.Drawing.Color.Yellow;
            this.cmb_vendor.FormattingEnabled = true;
            this.cmb_vendor.Location = new System.Drawing.Point(689, 23);
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.Size = new System.Drawing.Size(275, 21);
            this.cmb_vendor.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(984, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "اسم المورد";
            // 
            // cmb_convert
            // 
            this.cmb_convert.BackColor = System.Drawing.Color.Yellow;
            this.cmb_convert.FormattingEnabled = true;
            this.cmb_convert.Location = new System.Drawing.Point(689, 55);
            this.cmb_convert.Name = "cmb_convert";
            this.cmb_convert.Size = new System.Drawing.Size(275, 21);
            this.cmb_convert.TabIndex = 25;
            // 
            // dtb_purchases_time
            // 
            this.dtb_purchases_time.Location = new System.Drawing.Point(210, 24);
            this.dtb_purchases_time.Name = "dtb_purchases_time";
            this.dtb_purchases_time.Size = new System.Drawing.Size(275, 20);
            this.dtb_purchases_time.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "التاريخ";
            // 
            // txt_pruchases_nots
            // 
            this.txt_pruchases_nots.BackColor = System.Drawing.Color.Yellow;
            this.txt_pruchases_nots.Location = new System.Drawing.Point(212, 88);
            this.txt_pruchases_nots.Multiline = true;
            this.txt_pruchases_nots.Name = "txt_pruchases_nots";
            this.txt_pruchases_nots.Size = new System.Drawing.Size(751, 37);
            this.txt_pruchases_nots.TabIndex = 9;
            this.txt_pruchases_nots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1003, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ملاحظات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1013, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "المخزن";
            // 
            // frm_purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_purchases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_purchases";
            this.Text = "اجراء حركة شراء";
            this.Load += new System.EventHandler(this.frm_purchases_Load);
            this.pn_purchases.ResumeLayout(false);
            this.grp_btns.ResumeLayout(false);
            this.grp_btns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase)).EndInit();
            this.grb_convert_data.ResumeLayout(false);
            this.grb_convert_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_purchases;
        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_item_price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_item_catog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_item_name;
        private System.Windows.Forms.Button btn_purchases_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox grb_convert_data;
        private System.Windows.Forms.ComboBox cmb_convert;
        private System.Windows.Forms.DateTimePicker dtb_purchases_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pruchases_nots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_payed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_remain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_purchase;
        private System.Windows.Forms.ComboBox cmb_vendor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Categort_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuanty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_value;
    }
}