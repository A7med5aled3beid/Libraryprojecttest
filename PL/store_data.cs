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
    public partial class frm_store_data : Form
    {
        public frm_store_data()
        {
            InitializeComponent();
        }
        cl_validate clear = new cl_validate();
        void clean() 
        {
            clear.txtclear(grb_store_data);
            clear.txtclear(grb_search);
        }
        #region blind
        void blind() 
        {
            //fill combobox search
            cmb_search_store.DataSource = retrivedata.execute("Sp_Store_DataSelectAll", CommandType.StoredProcedure);
            cmb_search_store.DisplayMember = "Store_Name";
            cmb_search_store.ValueMember = "Store_ID";

            //fil combobox emplyee name
            cmb_emp.DataSource = retrivedata.execute("Sp_empolyeeSelectAll", CommandType.StoredProcedure);
            cmb_emp.DisplayMember = "Emp_Name";
            cmb_emp.ValueMember = "Emp_ID";

            //fill data grid view
            DataTable dt = new DataTable();
            dt = retrivedata.execute("Sp_Store_DataSelectAll", CommandType.StoredProcedure);
            grc_store_data.DataSource = dt;
        }
        #endregion
        private void frm_store_data_Load(object sender, EventArgs e)
        {
            blind();
            clean(); 
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (MessageBox.Show("هل تريد اضافة مخزن جديد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                clean(); 

                #region btn_state
                btn_save.Enabled = true;
                #endregion
            }
            #endregion
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            #region Save
            if (MessageBox.Show("هل تريد حفظ مخزن جديد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                #region Sure Data
                if (txt_store_name.Text=="")
                {
                    MessageBox.Show("من فضلك ادخل اسم المخزن","حقل مطلوب",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                #endregion

                retrivedata.executenonquary("Sp_Store_DataInsert",
                    new paramter("@Store_Name", SqlDbType.NVarChar, txt_store_name.Text),
                    new paramter("@Store_Phone", SqlDbType.Int, int.Parse(txt_store_phone.Text).ToString()),
                    new paramter("@Store_Address", SqlDbType.NVarChar, txt_adress.Text),
                    new paramter("@Store_Notes", SqlDbType.NVarChar, txt_store_nots.Text),
                    new paramter("@Emp_ID", SqlDbType.Int, int.Parse(cmb_emp.SelectedValue.ToString())),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID)
                    );
                MessageBox.Show("تم الحفظ","عملية ناجحة",MessageBoxButtons.OK,MessageBoxIcon.Information);
                blind();
                clean(); 

                #region btn state
                btn_save.Enabled = false;
                #endregion
            }
            #endregion
        }

        private void btn_store_search_Click(object sender, EventArgs e)
        {
            #region Search
            if (cmb_search_store.Text!="")
            {
                DataTable dt = new DataTable();
                dt = retrivedata.execute("Sp_Store_DataSelectBY_ID", CommandType.StoredProcedure, new paramter("@Store_ID", SqlDbType.Int, int.Parse(cmb_search_store.SelectedValue.ToString())));
                txt_store_name.Text = dt.Rows[0]["Store_Name"].ToString();
                txt_store_phone.Text = dt.Rows[0]["Store_Phone"].ToString();
                txt_adress.Text = dt.Rows[0]["Store_Address"].ToString();
                txt_store_nots.Text = dt.Rows[0]["Store_Notes"].ToString();
                cmb_emp.Text = dt.Rows[0]["Emp_Name"].ToString();

                #region btn_state
                btn_save.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                #endregion
            }
            #endregion
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            #region Update
            if (MessageBox.Show("هل تريد تعديل مخزن", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region Sure Data
                if (txt_store_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم المخزن", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                retrivedata.executenonquary("Sp_Store_DataUpdate",
                    new paramter("@Store_ID", SqlDbType.Int, int.Parse(cmb_search_store.SelectedValue.ToString())),
                    new paramter("@Store_Name", SqlDbType.NVarChar, txt_store_name.Text),
                    new paramter("@Store_Phone", SqlDbType.Int, int.Parse(txt_store_phone.Text).ToString()),
                    new paramter("@Store_Address", SqlDbType.NVarChar, txt_adress.Text),
                    new paramter("@Store_Notes", SqlDbType.NVarChar, txt_store_nots.Text),
                    new paramter("@Emp_ID", SqlDbType.Int, int.Parse(cmb_emp.SelectedValue.ToString())),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID)
                    );
                MessageBox.Show("تم التعديل", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();
                clean(); 

                #region btn state
                btn_save.Enabled = false;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                #endregion
            }
            #endregion
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            #region Delete
            if (MessageBox.Show("هل تريدحذف مخزن", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                retrivedata.executenonquary("Sp_Store_DataDelete",
                    new paramter("@Store_ID", SqlDbType.Int, int.Parse(cmb_search_store.SelectedValue.ToString())));
                MessageBox.Show("تم الحذف", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();
                clean(); 

                #region btn state
                btn_save.Enabled = false;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                #endregion
            }
            #endregion
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
