namespace Librarypro.PL
{
    partial class frm_view_Accountcust
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
            this.dgr_search = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_cust_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_payed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_remain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nots = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr_search
            // 
            this.dgr_search.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgr_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgr_search.Location = new System.Drawing.Point(0, 0);
            this.dgr_search.MainView = this.gridView1;
            this.dgr_search.Name = "dgr_search";
            this.dgr_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgr_search.Size = new System.Drawing.Size(1280, 755);
            this.dgr_search.TabIndex = 1;
            this.dgr_search.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_cust_name,
            this.col_payed,
            this.col_remain,
            this.col_data,
            this.col_nots});
            this.gridView1.GridControl = this.dgr_search;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_cust_name
            // 
            this.col_cust_name.AppearanceCell.Options.UseTextOptions = true;
            this.col_cust_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_cust_name.AppearanceHeader.Options.UseTextOptions = true;
            this.col_cust_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_cust_name.Caption = "اسم العميل";
            this.col_cust_name.FieldName = "Cust_Name";
            this.col_cust_name.Name = "col_cust_name";
            this.col_cust_name.Visible = true;
            this.col_cust_name.VisibleIndex = 4;
            // 
            // col_payed
            // 
            this.col_payed.AppearanceCell.Options.UseTextOptions = true;
            this.col_payed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_payed.AppearanceHeader.Options.UseTextOptions = true;
            this.col_payed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_payed.Caption = "المبلغ المدفوع";
            this.col_payed.FieldName = "Payed_Value";
            this.col_payed.Name = "col_payed";
            this.col_payed.Visible = true;
            this.col_payed.VisibleIndex = 3;
            // 
            // col_remain
            // 
            this.col_remain.AppearanceCell.Options.UseTextOptions = true;
            this.col_remain.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_remain.AppearanceHeader.Options.UseTextOptions = true;
            this.col_remain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_remain.Caption = "المبلغ المتبقى";
            this.col_remain.FieldName = "Remain_Value";
            this.col_remain.Name = "col_remain";
            this.col_remain.Visible = true;
            this.col_remain.VisibleIndex = 2;
            // 
            // col_data
            // 
            this.col_data.AppearanceCell.Options.UseTextOptions = true;
            this.col_data.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_data.AppearanceHeader.Options.UseTextOptions = true;
            this.col_data.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_data.Caption = "تاريخ السداد";
            this.col_data.FieldName = "Payed_Date";
            this.col_data.Name = "col_data";
            this.col_data.Visible = true;
            this.col_data.VisibleIndex = 1;
            // 
            // col_nots
            // 
            this.col_nots.AppearanceCell.Options.UseTextOptions = true;
            this.col_nots.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_nots.AppearanceHeader.Options.UseTextOptions = true;
            this.col_nots.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_nots.Caption = "ملاحظات";
            this.col_nots.FieldName = "Account_Notes";
            this.col_nots.Name = "col_nots";
            this.col_nots.Visible = true;
            this.col_nots.VisibleIndex = 0;
            // 
            // frm_view_Accountcust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 755);
            this.Controls.Add(this.dgr_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_view_Accountcust";
            this.Text = "حركة حسابات عميل";
            this.Load += new System.EventHandler(this.frm_view_Accountcust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgr_search;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_cust_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_payed;
        private DevExpress.XtraGrid.Columns.GridColumn col_remain;
        private DevExpress.XtraGrid.Columns.GridColumn col_data;
        private DevExpress.XtraGrid.Columns.GridColumn col_nots;
    }
}