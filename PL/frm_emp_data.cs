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
    
    public partial class frm_emp_data : Form
    {
        public frm_emp_data()
        {
           
            InitializeComponent();
        }
        cl_validate clear = new cl_validate();
        void blind() 
        {
            //fil cobmo joptype
            cmb_joptype.DataSource = retrivedata.execute("Sp_Jop_TypeSelectAll", CommandType.StoredProcedure);
            cmb_joptype.DisplayMember = "Job_Name";
            cmb_joptype.ValueMember = "Jop_ID";

            //fil combobox emplyee name
            cmb_search_emp.DataSource = retrivedata.execute("Sp_empolyeeSelectAll", CommandType.StoredProcedure);
            cmb_search_emp.DisplayMember = "Emp_Name";
            cmb_search_emp.ValueMember = "Emp_ID";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_emp_data_Load(object sender, EventArgs e)
        {
            blind(); 
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (MessageBox.Show("هل تريد اضافة موظف جديد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                clear.txtclear(grp_emp_data);
                clear.txtclear(grp_search);
                lb_id.Text = "0";

                #region btn_state
                btn_save.Enabled = true;
                #endregion
            }
            #endregion
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            #region Save
            if (MessageBox.Show("هل تريد حفظ موظف جديد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                #region SureData
                if (txt_emp_name.Text=="")
                {
                    MessageBox.Show("من فضلك ادخل اسم الموظف","حقل مطلوب",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (txt_emp_persID.Text=="")
                {
                    MessageBox.Show("من فضلك ادخل الرقم القومى للموظف","حقل مطلوب",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                #endregion

                retrivedata.executenonquary("Sp_empolyeeInsert",
                     new paramter("@Emp_Name", SqlDbType.NVarChar, txt_emp_name.Text),
                     new paramter("@Job_ID", SqlDbType.Int, int.Parse(cmb_joptype.SelectedValue.ToString())),
                     new paramter("@Emp_Phone", SqlDbType.Int, int.Parse(txt_emp_phone.Text).ToString()),
                     new paramter("@Emp_Mobile", SqlDbType.Int, int.Parse(txt_emp_mobile.Text).ToString()),
                     new paramter("@Emp_Address", SqlDbType.NVarChar, txt_emp_adress.Text),
                     new paramter("@Personal_ID", SqlDbType.Int, int.Parse(txt_emp_persID.Text).ToString()),
                     new paramter("@Bsic_Salary", SqlDbType.Decimal, decimal.Parse(txt_emp_salary.Text).ToString()),
                     new paramter("@User_ID", SqlDbType.Int, login.User_ID),
                     new paramter("@Nots", SqlDbType.NVarChar, txt_emp_nots.Text));

                MessageBox.Show("تم الحفظ","عملية ناجحة",MessageBoxButtons.OK,MessageBoxIcon.Information);
                blind();

                #region btn_State
                btn_save.Enabled = false;
                #endregion
            }
            #endregion
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            #region Update
            if (MessageBox.Show("هل تريد تعديل موظف", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region SureData
                if (txt_emp_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الموظف", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_emp_persID.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل الرقم القومى للموظف", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                retrivedata.executenonquary("Sp_empolyeeUpdate",
                    new paramter("@Emp_ID", SqlDbType.Int, int.Parse(lb_id.Text).ToString()),
                     new paramter("@Emp_Name", SqlDbType.NVarChar, txt_emp_name.Text),
                     new paramter("@Job_ID", SqlDbType.Int, int.Parse(cmb_joptype.SelectedValue.ToString())),
                     new paramter("@Emp_Phone", SqlDbType.Int, int.Parse(txt_emp_phone.Text).ToString()),
                     new paramter("@Emp_Mobile", SqlDbType.Int, int.Parse(txt_emp_mobile.Text).ToString()),
                     new paramter("@Emp_Address", SqlDbType.NVarChar, txt_emp_adress.Text),
                     new paramter("@Personal_ID", SqlDbType.Int, int.Parse(txt_emp_persID.Text).ToString()),
                     new paramter("@Bsic_Salary", SqlDbType.Decimal, decimal.Parse(txt_emp_salary.Text).ToString()),
                     new paramter("@User_ID", SqlDbType.Int, login.User_ID),
                     new paramter("@Nots", SqlDbType.NVarChar, txt_emp_nots.Text));

                MessageBox.Show("تم التعديل", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();

                #region btn_State
                btn_save.Enabled = false;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                #endregion
            }
            #endregion
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            #region Delete
            if (MessageBox.Show("هل تريد حذف موظف", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                retrivedata.executenonquary("Sp_empolyeeDelete",
                    new paramter("@Emp_ID", SqlDbType.Int, int.Parse(lb_id.Text).ToString()));

                MessageBox.Show("تم الحذف", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();

                #region btn_State
                btn_save.Enabled = false;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                #endregion
            }
            #endregion
        }

        private void btn_emp_search_Click(object sender, EventArgs e)
        {
            #region Search
            if (cmb_search_emp.Text!="")
            {
                DataTable dt=new DataTable();
                dt = retrivedata.execute("Sp_empolyeeSelectBY_ID", CommandType.StoredProcedure, new paramter("Emp_ID", SqlDbType.Int, cmb_search_emp.SelectedValue.ToString()));
                lb_id.Text = dt.Rows[0]["Emp_ID"].ToString();
                txt_emp_name.Text = dt.Rows[0]["Emp_Name"].ToString();
                txt_emp_phone.Text = dt.Rows[0]["Emp_Phone"].ToString();
                txt_emp_mobile.Text = dt.Rows[0]["Emp_Mobile"].ToString();
                txt_emp_adress.Text = dt.Rows[0]["Emp_Address"].ToString();
                txt_emp_persID.Text = dt.Rows[0]["Personal_ID"].ToString();
                txt_emp_salary.Text = dt.Rows[0]["Bsic_Salary"].ToString();
                txt_emp_nots.Text = dt.Rows[0]["Nots"].ToString();
                cmb_joptype.Text = dt.Rows[0]["Job_Name"].ToString();
                #region btn_State
                btn_save.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
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
