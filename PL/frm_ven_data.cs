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
    public partial class frm_ven_data : Form
    {
        public frm_ven_data()
        {
            InitializeComponent();
        }
        cl_validate _validate = new cl_validate();

        #region blind_combobox
        void blindcmb()
        {
            cmb_search_ven.DataSource = retrivedata.execute("Sp_VendorsSelectAll", CommandType.StoredProcedure);
            cmb_search_ven.DisplayMember = "Ven_Name";
            cmb_search_ven.ValueMember = "Ven_ID";
            cmb_search_ven.Text = "";
        }
        #endregion
        private void btn_new_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (MessageBox.Show("هل تريد اضافة مورد جديد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _validate.txtclear(grp_search);
                _validate.txtclear(grp_ven_data);

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
             #region suredata
            if (txt_ven_name.Text == string.Empty)
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_ven_phone.Text == "")
            {
                txt_ven_phone.Text = "0";
            }
            if (txt_ven_mobile.Text == "")
            {
                txt_ven_mobile.Text = "0";
            }
            #endregion
            if (MessageBox.Show("هل تريد حفظ مورد جديد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region save
                retrivedata.executenonquary("Sp_VendorsInsert",
                    new paramter("@Ven_Name", SqlDbType.NVarChar, txt_ven_name.Text),
                    new paramter("@Ven_Address", SqlDbType.NVarChar, txt_ven_adress.Text),
                    new paramter("@Ven_Notes", SqlDbType.NVarChar, txt_ven_nots.Text),
                    new paramter("@Ven_Phone", SqlDbType.Int, int.Parse(txt_ven_phone.Text)),
                    new paramter("@Ven_Mobile", SqlDbType.Int, int.Parse(txt_ven_mobile.Text)),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID));
                MessageBox.Show("تم الحفظ", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blindcmb();
                #endregion


                #region btn_enabel_state
                btn_save.Enabled = false;
                #endregion
            }
           
        }

        private void frm_ven_data_Load(object sender, EventArgs e)
        {
            blindcmb();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_ven_search_Click(object sender, EventArgs e)
        {
            #region btn_search
            if (cmb_search_ven.Text!="")
            {
                DataTable dt = new DataTable();

                dt = retrivedata.execute("Sp_VendorsSelectBy_ID", CommandType.StoredProcedure,new paramter("@Ven_ID",SqlDbType.Int,int.Parse(cmb_search_ven.SelectedValue.ToString())));
                lb_id.Text = dt.Rows[0]["Ven_ID"].ToString();
                txt_ven_name.Text = dt.Rows[0]["Ven_Name"].ToString();
                txt_ven_adress.Text = dt.Rows[0]["Ven_Address"].ToString();
                txt_ven_nots.Text = dt.Rows[0]["Ven_Notes"].ToString();
                txt_ven_phone.Text = dt.Rows[0]["Ven_Phone"].ToString();
                txt_ven_mobile.Text = dt.Rows[0]["Ven_Mobile"].ToString();
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
             #region suredata
            if (txt_ven_name.Text == string.Empty)
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_ven_phone.Text == "")
            {
                txt_ven_phone.Text = "0";
            }
            if (txt_ven_mobile.Text == "")
            {
                txt_ven_mobile.Text = "0";
            }
            #endregion
            if (MessageBox.Show("هل تريد تعديل مورد ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region Update
                retrivedata.executenonquary("Sp_VendorsUpdate",
                    new paramter("@Ven_ID", SqlDbType.Int, int.Parse(cmb_search_ven.SelectedValue.ToString())),
                    new paramter("@Ven_Name", SqlDbType.NVarChar, txt_ven_name.Text),
                    new paramter("@Ven_Address", SqlDbType.NVarChar, txt_ven_adress.Text),
                    new paramter("@Ven_Notes", SqlDbType.NVarChar, txt_ven_nots.Text),
                    new paramter("@Ven_Phone", SqlDbType.Int, int.Parse(txt_ven_phone.Text)),
                    new paramter("@Ven_Mobile", SqlDbType.Int, int.Parse(txt_ven_mobile.Text)),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID));
                MessageBox.Show("تم التعديل", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blindcmb();
                #endregion
                #region btn_enabel_state
                btn_save.Enabled = false;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                #endregion
                #region clearcontrols
                _validate.txtclear(grp_search);
                _validate.txtclear(grp_ven_data);
                #endregion
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف مورد ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region delete
                retrivedata.executenonquary("Sp_VendorsDelete",new paramter("@Ven_ID", SqlDbType.Int, int.Parse(cmb_search_ven.SelectedValue.ToString())));
                MessageBox.Show("تم الحذف", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blindcmb();
                #endregion
                #region btn_enabel_state
                btn_save.Enabled = false;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                #endregion

                #region clearcontrols
                _validate.txtclear(grp_search);
                _validate.txtclear(grp_ven_data);
                #endregion

            }
        }

       
    }
}
