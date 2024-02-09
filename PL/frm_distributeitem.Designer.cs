namespace Librarypro.PL
{
    partial class frm_distributeitem
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
            this.pn_store_Qaunty = new System.Windows.Forms.Panel();
            this.grp_btns = new System.Windows.Forms.GroupBox();
            this.btn_Auto = new System.Windows.Forms.Button();
            this.dgv_stor = new System.Windows.Forms.DataGridView();
            this.col_store_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grb_store_item = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_store = new System.Windows.Forms.ComboBox();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_store_Qaunty.SuspendLayout();
            this.grp_btns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stor)).BeginInit();
            this.grb_store_item.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_store_Qaunty
            // 
            this.pn_store_Qaunty.BackColor = System.Drawing.Color.White;
            this.pn_store_Qaunty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_store_Qaunty.Controls.Add(this.grp_btns);
            this.pn_store_Qaunty.Controls.Add(this.grb_store_item);
            this.pn_store_Qaunty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_store_Qaunty.Location = new System.Drawing.Point(0, 0);
            this.pn_store_Qaunty.Name = "pn_store_Qaunty";
            this.pn_store_Qaunty.Size = new System.Drawing.Size(1280, 755);
            this.pn_store_Qaunty.TabIndex = 6;
            // 
            // grp_btns
            // 
            this.grp_btns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grp_btns.BackColor = System.Drawing.Color.Turquoise;
            this.grp_btns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_btns.Controls.Add(this.btn_Auto);
            this.grp_btns.Controls.Add(this.dgv_stor);
            this.grp_btns.Controls.Add(this.btn_close);
            this.grp_btns.Controls.Add(this.btn_save);
            this.grp_btns.Location = new System.Drawing.Point(52, 193);
            this.grp_btns.Name = "grp_btns";
            this.grp_btns.Size = new System.Drawing.Size(1176, 518);
            this.grp_btns.TabIndex = 17;
            this.grp_btns.TabStop = false;
            // 
            // btn_Auto
            // 
            this.btn_Auto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Auto.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_check_24;
            this.btn_Auto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Auto.Location = new System.Drawing.Point(301, 466);
            this.btn_Auto.Name = "btn_Auto";
            this.btn_Auto.Size = new System.Drawing.Size(225, 30);
            this.btn_Auto.TabIndex = 6;
            this.btn_Auto.Text = "توزيع تلقائي";
            this.btn_Auto.UseVisualStyleBackColor = true;
            this.btn_Auto.Click += new System.EventHandler(this.btn_Auto_Click);
            // 
            // dgv_stor
            // 
            this.dgv_stor.AllowUserToAddRows = false;
            this.dgv_stor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_store_ID,
            this.col_item_ID,
            this.col_store_name,
            this.col_item_name});
            this.dgv_stor.Location = new System.Drawing.Point(34, 19);
            this.dgv_stor.Name = "dgv_stor";
            this.dgv_stor.ReadOnly = true;
            this.dgv_stor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_stor.Size = new System.Drawing.Size(1096, 413);
            this.dgv_stor.TabIndex = 5;
            // 
            // col_store_ID
            // 
            this.col_store_ID.HeaderText = "";
            this.col_store_ID.Name = "col_store_ID";
            this.col_store_ID.ReadOnly = true;
            this.col_store_ID.Visible = false;
            // 
            // col_item_ID
            // 
            this.col_item_ID.HeaderText = "";
            this.col_item_ID.Name = "col_item_ID";
            this.col_item_ID.ReadOnly = true;
            this.col_item_ID.Visible = false;
            // 
            // col_store_name
            // 
            this.col_store_name.HeaderText = "اسم المخزن";
            this.col_store_name.Name = "col_store_name";
            this.col_store_name.ReadOnly = true;
            this.col_store_name.Width = 150;
            // 
            // col_item_name
            // 
            this.col_item_name.HeaderText = "اسم الصنف";
            this.col_item_name.Name = "col_item_name";
            this.col_item_name.ReadOnly = true;
            this.col_item_name.Width = 150;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_error_24;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.Location = new System.Drawing.Point(619, 466);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_check_24;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(756, 466);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 30);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // grb_store_item
            // 
            this.grb_store_item.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_store_item.BackColor = System.Drawing.Color.DarkCyan;
            this.grb_store_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grb_store_item.Controls.Add(this.btn_Add);
            this.grb_store_item.Controls.Add(this.cmb_store);
            this.grb_store_item.Controls.Add(this.cmb_item);
            this.grb_store_item.Controls.Add(this.label3);
            this.grb_store_item.Controls.Add(this.label1);
            this.grb_store_item.Location = new System.Drawing.Point(52, 43);
            this.grb_store_item.Name = "grb_store_item";
            this.grb_store_item.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grb_store_item.Size = new System.Drawing.Size(1176, 144);
            this.grb_store_item.TabIndex = 1;
            this.grb_store_item.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = global::Librarypro.Properties.Resources.Paomedia_Small_N_Flat_Sign_add_24;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.Location = new System.Drawing.Point(770, 89);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(119, 30);
            this.btn_Add.TabIndex = 26;
            this.btn_Add.Text = "اضافة";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_store
            // 
            this.cmb_store.BackColor = System.Drawing.Color.Yellow;
            this.cmb_store.FormattingEnabled = true;
            this.cmb_store.Location = new System.Drawing.Point(614, 62);
            this.cmb_store.Name = "cmb_store";
            this.cmb_store.Size = new System.Drawing.Size(275, 21);
            this.cmb_store.TabIndex = 25;
            // 
            // cmb_item
            // 
            this.cmb_item.BackColor = System.Drawing.Color.Yellow;
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(192, 62);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(275, 21);
            this.cmb_item.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(938, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "المخزن";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // frm_distributeitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.pn_store_Qaunty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_distributeitem";
            this.Text = "توزيع الاصناف على المخازن";
            this.Load += new System.EventHandler(this.frm_distributeitem_Load);
            this.pn_store_Qaunty.ResumeLayout(false);
            this.grp_btns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stor)).EndInit();
            this.grb_store_item.ResumeLayout(false);
            this.grb_store_item.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_store_Qaunty;
        private System.Windows.Forms.GroupBox grp_btns;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox grb_store_item;
        private System.Windows.Forms.ComboBox cmb_store;
        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_stor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_store_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_store_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_name;
        private System.Windows.Forms.Button btn_Auto;
    }
}