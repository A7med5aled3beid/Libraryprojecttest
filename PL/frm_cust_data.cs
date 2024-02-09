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
    public partial class frm_cust_data : Form
    {
        public frm_cust_data()
        {
            InitializeComponent();

        }
        cl_validate _validate = new cl_validate();

        private void btn_new_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (MessageBox.Show("هل تريد اضافة عميل جديد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _validate.txtclear(grp_search);
                _validate.txtclear(grp_cust_data);

                #region btn_Enabled
                btn_save.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                #endregion
            }
            #endregion
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            #region Save

            #region suredata
            if (txt_cust_name.Text == string.Empty)
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_cust_phone.Text == "")
            {
                txt_cust_phone.Text = "0";
            }
            if (txt_cust_mobil.Text == "")
            {
                txt_cust_mobil.Text = "0";
            }
            #endregion
            if (MessageBox.Show("هل تريد حفظ عميل جديد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                #region savedata
                retrivedata.executenonquary("Sp_CustomersInsert",
                    new paramter("@Cust_Name", SqlDbType.NVarChar, txt_cust_name.Text),
                    new paramter("@Cust_Phone", SqlDbType.Int, int.Parse(txt_cust_phone.Text)),
                    new paramter("@Cust_Mobile", SqlDbType.Int, int.Parse(txt_cust_mobil.Text)),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID),
                    new paramter("@Cust_Address", SqlDbType.NVarChar, txt_cust_adress.Text),
                    new paramter("@Cust_Notes", SqlDbType.NVarChar, txt_cust_nots.Text));
                MessageBox.Show("تم الحفظ ", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindcmb();
                #endregion

                #region btn_enabel_state
                btn_save.Enabled = false;
                #endregion
            }
            #endregion
        }
        #region bindcmb
        void bindcmb()
        {
            cmb_cust_search.DataSource = retrivedata.execute("Sp_CustomersSelectAll", CommandType.StoredProcedure);
            cmb_cust_search.DisplayMember = "Cust_Name";
            cmb_cust_search.ValueMember = "Cust_ID";
            cmb_cust_search.Text = "";
        }
        #endregion
        private void frm_cust_data_Load(object sender, EventArgs e)
        {
            bindcmb();
        }

        private void cmb_cust_search_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            #region search
            if (cmb_cust_search.Text != "")
            {
                DataTable dt = new DataTable();
                dt = retrivedata.execute("Sp_CustomersSelectBy_ID ", CommandType.StoredProcedure, new paramter("@Cust_ID", SqlDbType.Int, int.Parse(cmb_cust_search.SelectedValue.ToString())));
                lb_id.Text = dt.Rows[0]["Cust_ID"].ToString();
                txt_cust_name.Text = dt.Rows[0]["Cust_Name"].ToString();
                txt_cust_adress.Text = dt.Rows[0]["Cust_Address"].ToString();
                txt_cust_nots.Text = dt.Rows[0]["Cust_Notes"].ToString();
                txt_cust_mobil.Text = dt.Rows[0]["Cust_Mobile"].ToString();
                txt_cust_phone.Text = dt.Rows[0]["Cust_Phone"].ToString();

                #region btn_enabled
                btn_save.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                #endregion
            }
            #endregion
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lb_id.Text != "0")
            {
                if (MessageBox.Show("هل تريد تعديل عميل ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    #region editdata
                    retrivedata.executenonquary("Sp_CustomersUpdate",
                        new paramter("@Cust_ID", SqlDbType.NVarChar, lb_id.Text),
                        new paramter("@Cust_Name", SqlDbType.NVarChar, txt_cust_name.Text),
                        new paramter("@Cust_Phone", SqlDbType.Int, int.Parse(txt_cust_phone.Text)),
                        new paramter("@Cust_Mobile", SqlDbType.Int, int.Parse(txt_cust_mobil.Text)),
                        new paramter("@User_ID", SqlDbType.Int, login.User_ID),
                        new paramter("@Cust_Address", SqlDbType.NVarChar, txt_cust_adress.Text),
                        new paramter("@Cust_Notes", SqlDbType.NVarChar, txt_cust_nots.Text));
                    MessageBox.Show("تم التعديل ", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindcmb();
                    #endregion

                    #region btn_enabel_state
                    btn_save.Enabled = false;
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    #endregion
                    #region clearcontrols
                    _validate.txtclear(grp_search);
                    _validate.txtclear(grp_cust_data);
                    #endregion
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lb_id.Text != "0")
            {
                if (MessageBox.Show("هل تريد حذف عميل ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    #region deletedata
                    retrivedata.executenonquary("Sp_CustomersDelete", new paramter("@Cust_ID", SqlDbType.NVarChar, lb_id.Text));
                    MessageBox.Show("تم الحذف ", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindcmb();
                    #endregion

                    #region btn_enabel_state
                    btn_save.Enabled = false;
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    #endregion
                    #region clearcontrols
                    _validate.txtclear(grp_search);
                    _validate.txtclear(grp_cust_data);
                    #endregion
                }

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}