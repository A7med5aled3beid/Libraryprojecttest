﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Librarypro.dal;
using System.Data.SqlClient;
using Librarypro.Report;

namespace Librarypro.PL
{
    public partial class frm_sales : Form
    {
        public frm_sales()
        {
            InitializeComponent();
        }
        #region connectString
        Dbconnect _con = new Dbconnect();
        #endregion
        #region RetriveDataTable
        DataTable prepardata()
        {
            if (dgv_sales.Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Clear();
                dt.Columns.Add("Category_ID", typeof(int));
                dt.Columns.Add("Item_ID", typeof(int));
                dt.Columns.Add("Purchases_Price", typeof(decimal));
                dt.Columns.Add("Item_Quantity", typeof(int));
                dt.Columns.Add("Item_Value", typeof(decimal));
                for (int i = 0; i < dgv_sales.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = dgv_sales.Rows[i].Cells[0].Value.ToString();
                    dr[1] = dgv_sales.Rows[i].Cells[1].Value.ToString();
                    dr[2] = dgv_sales.Rows[i].Cells[4].Value.ToString();
                    dr[3] = dgv_sales.Rows[i].Cells[5].Value.ToString();
                    dr[4] = dgv_sales.Rows[i].Cells[6].Value.ToString();

                    dt.Rows.Add(dr);

                }

                return dt;
            }
            else
            { return null; }
        }
        #endregion

        #region blind
        void blindcmb()
        {
            // fill combo box vendors
            cmb_cust_name.DataSource = retrivedata.execute("Sp_CustomersSelectAll", CommandType.StoredProcedure);
            cmb_cust_name.DisplayMember = "Cust_Name";
            cmb_cust_name.ValueMember = "Cust_ID";
            cmb_cust_name.Text = "";

            //fill combobox Store 
            cmb_convert.DataSource = retrivedata.execute("Sp_Store_DataSelectAll", CommandType.StoredProcedure);
            cmb_convert.DisplayMember = "Store_Name";
            cmb_convert.ValueMember = "Store_ID";

            //fill combo box item Category
            cmb_item_catog.DataSource = retrivedata.execute("Sp_Item_CategorySelectAll", CommandType.StoredProcedure);
            cmb_item_catog.DisplayMember = "Category_Name";
            cmb_item_catog.ValueMember = "Category_ID";
        }
        #endregion

        #region calcitemvalue
        void calcitemvalue()
        {
            if (txt_item_price.Text == "")
            {
                txt_item_price.Text = "0";
            }
            if (txt_quant.Text == "")
            {
                txt_quant.Text = "0";
            }
            txt_value.Text = (double.Parse(txt_item_price.Text) * double.Parse(txt_quant.Text)).ToString();
        }
        #endregion

        #region cal total value
        void CalTotalValue()
        {
            double sum = 0;
            for (int i = 0; i < dgv_sales.RowCount; i++)
            {
                sum += Convert.ToDouble(dgv_sales.Rows[i].Cells[6].Value);
            }
            txt_total_value.Text = sum.ToString();


        }
        #endregion

        #region Cal Remin Value
        void CalRemin()
        {
            CalTotalValue();
            if (txt_payed.Text == "")
            {
                txt_payed.Text = "0";
            }
            if (double.Parse(txt_payed.Text) > double.Parse(txt_total_value.Text))
            {
                return;
            }
            txt_remain.Text = (double.Parse(txt_total_value.Text) - double.Parse(txt_payed.Text)).ToString();
        }
        #endregion
        private void frm_sales_Load(object sender, EventArgs e)
        {
            blindcmb();
        }

        private void cmb_item_catog_SelectedValueChanged(object sender, EventArgs e)
        {
            #region fill combbox item
            if (cmb_item_catog.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                cmb_item_name.DataSource =
                retrivedata.execute
                ("Sp_Item_SelectID", CommandType.StoredProcedure,
                new paramter("@Category_ID", SqlDbType.Int, int.Parse(cmb_item_catog.SelectedValue.ToString())));
                cmb_item_name.DisplayMember = "Item_Name";
                cmb_item_name.ValueMember = "Item_ID";
                cmb_item_name.Text = "";

            }
            #endregion
        }

        private void btn_salse_add_Click(object sender, EventArgs e)
        {
            #region data
            if (cmb_item_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_value.Text == "0")
            {
                MessageBox.Show("من فضلك ادخل البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region Add Data
            DataGridViewRow Row = new DataGridViewRow();
            DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            DataGridViewCell cel2 = new DataGridViewTextBoxCell();
            DataGridViewCell cel3 = new DataGridViewTextBoxCell();
            DataGridViewCell cel4 = new DataGridViewTextBoxCell();
            DataGridViewCell cel5 = new DataGridViewTextBoxCell();
            DataGridViewCell cel6 = new DataGridViewTextBoxCell();
            DataGridViewCell cel7 = new DataGridViewTextBoxCell();

            Row.Cells.Add(cel1); Row.Cells.Add(cel2); Row.Cells.Add(cel3);
            Row.Cells.Add(cel4); Row.Cells.Add(cel5); Row.Cells.Add(cel6);
            Row.Cells.Add(cel7);

            Row.Cells[0].Value = cmb_item_catog.SelectedValue.ToString();
            Row.Cells[1].Value = cmb_item_name.SelectedValue.ToString();
            Row.Cells[2].Value = cmb_item_catog.Text;
            Row.Cells[3].Value = cmb_item_name.Text;
            Row.Cells[4].Value = txt_item_price.Text;
            Row.Cells[5].Value = txt_quant.Text;
            Row.Cells[6].Value = txt_value.Text;

            dgv_sales.Rows.Add(Row);


            CalTotalValue();

            #endregion
        }

        private void txt_item_price_TextChanged(object sender, EventArgs e)
        {
            calcitemvalue();
        }

        private void txt_payed_TextChanged(object sender, EventArgs e)
        {
            CalRemin();
        }

        private void dgv_sales_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            CalTotalValue();
        }

        private void dgv_sales_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txt_total_value.Text = "0";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد اجراء حركة بيع ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btn_save.Enabled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            #region Save
            if (MessageBox.Show("هل تريد حفظ بيع جديدة", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region Sure Data
                if (cmb_cust_name.Text == "")
                {
                    MessageBox.Show("من فضلك اختر اسم العميل", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtb_purchases_time.Text == "")
                {
                    MessageBox.Show("من فضلك اختر التاريخ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion
                if (dgv_sales.Rows.Count > 0)
                {

                    DataTable dt = prepardata();
                    _con.cmd.Connection = Dbconnect.conn;
                    _con.cmd.CommandType = CommandType.StoredProcedure;
                    _con.cmd.CommandText = "Sp_Sales_MainInsert";
                    _con.cmd.Parameters.Clear();

                    _con.cmd.Parameters.AddWithValue("@Cust_ID", int.Parse(cmb_cust_name.SelectedValue.ToString()));
                    _con.cmd.Parameters.AddWithValue("@Sales_Data", dtb_purchases_time.MinDate.Date);
                    _con.cmd.Parameters.AddWithValue("@Total_Value", txt_total_value.Text);
                    _con.cmd.Parameters.AddWithValue("@Payed_Value", txt_payed.Text);
                    _con.cmd.Parameters.AddWithValue("@Remain_Value", txt_remain.Text);
                    _con.cmd.Parameters.AddWithValue("@Sales_Notes", txt_sales_nots.Text);
                    _con.cmd.Parameters.AddWithValue("@User_ID", login.User_ID);
                    _con.cmd.Parameters.AddWithValue("@Store_ID", int.Parse(cmb_convert.SelectedValue.ToString()));
                    _con.cmd.Parameters.AddWithValue("@SalesDataTable", dt);

                    _con.cmd.ExecuteNonQuery();

                    MessageBox.Show("تم الحفظ", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btn_save.Enabled = false;
                    #region print 
                    /*
                    if (MessageBox.Show("هل تريد طباعة الفاتورة","طباعة",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        _con.cmd.Connection = Dbconnect.conn;
                        _con.cmd.CommandType = CommandType.StoredProcedure;
                        _con.cmd.CommandText = "Sp_mainSale_SlectMax";

                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();

                        da.Fill(ds, "DtSale");
                        Cr_sales rpt = new Cr_sales();
                        rpt.SetDataSource(ds.Tables["DtSale"]);

                    }*/
                    #endregion
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل المبيعات", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            #endregion
        }

        private void txt_quant_TextChanged(object sender, EventArgs e)
        {
            calcitemvalue();
        }

        private void txt_total_value_TextChanged(object sender, EventArgs e)
        {
            CalRemin();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
