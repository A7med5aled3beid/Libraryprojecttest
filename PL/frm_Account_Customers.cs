using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Librarypro.dal;

namespace Librarypro.PL
{
    public partial class frm_Account_Customers : Form
    {
        public frm_Account_Customers()
        {
            InitializeComponent();
        }
        #region bind
        void bind()
        {
            cmb_search_cust.DataSource = retrivedata.execute("Sp_CustomersSelectAll", CommandType.StoredProcedure);
            cmb_search_cust.DisplayMember = "Cust_Name";
            cmb_search_cust.ValueMember = "Cust_ID";
            cmb_search_cust.Text = "";
        }

        #endregion
        private void frm_Account_Customers_Load(object sender, EventArgs e)
        {
            bind();
        }

        private void btn_ven_search_Click(object sender, EventArgs e)
        {
            #region btn_search
            if (cmb_search_cust.Text != "")
            {
                DataTable dt = new DataTable();

                dt = retrivedata.execute("Sp_CustomersSelectBy_ID", CommandType.StoredProcedure, new paramter("@Cust_ID", SqlDbType.Int, int.Parse(cmb_search_cust.SelectedValue.ToString())));
                lb_id.Text = dt.Rows[0]["Cust_Name"].ToString();
                txt_remain_value.Text = dt.Rows[0]["Cust_Debit"].ToString();

            }
            #endregion
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            #region Add
            if (MessageBox.Show("هل تريد اضافة سداد مبلغ جديد", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txt_nots.Text = "";
                txt_payed.Text = "";
                Data_time.Text = "";
                btn_save.Enabled = true;
            }
            #endregion
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            #region Save Data
            if (MessageBox.Show("هل تريد حفظ عملية السداد", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region Suredata
                if (double.Parse(txt_payed.Text) > double.Parse(txt_remain_value.Text))
                {
                    MessageBox.Show("المبلغ الدفوع اكبر من المبلغ المتبقى");
                }
                if (Data_time.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل التاريخ");
                    return;
                }
                if (txt_payed.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل المبلغ الدفوع");
                    return;
                }
                #endregion

                retrivedata.executenonquary("Sp_Cust_AccountInsert",
                    new paramter("@Cust_ID", SqlDbType.Int, int.Parse(cmb_search_cust.SelectedValue.ToString())),
                    new paramter("@Payed_Value", SqlDbType.Decimal, decimal.Parse(txt_payed.Text)),
                    new paramter("@Payed_Date", SqlDbType.Date, Data_time.MinDate.Date),
                    new paramter("@Account_Notes", SqlDbType.NVarChar, txt_nots.Text),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID));
                MessageBox.Show("تم الحفظ", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_save.Enabled = false;
            }
            #endregion
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
