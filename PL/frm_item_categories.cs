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
    public partial class frm_categories_data : Form
    {
        cl_validate clear = new cl_validate();
        public frm_categories_data()
        {
            InitializeComponent();
        }

        #region blind
        void blind() 
        {
            cmb_categ_item.DataSource = retrivedata.execute("Sp_Item_CategorySelectAll", CommandType.StoredProcedure);
            cmb_categ_item.DisplayMember = "Category_Name";
            cmb_categ_item.ValueMember = "Category_ID";

            //blind datagrid
            grc_item_categ.DataSource = retrivedata.execute("Sp_ItemsSelectAll", CommandType.StoredProcedure);
        }
        #endregion
        private void cmb_cust_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            #region AddNew

            if (MessageBox.Show("هل تريداضافة صنف جديد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                clear.txtclear(grp_item_categ);
                lb_id.Text = "0";

                #region btn_state
                btn_save.Enabled = true;
                #endregion
            }

            #endregion
        }

        private void frm_categories_data_Load(object sender, EventArgs e)
        {
            blind();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            #region Save
            if (MessageBox.Show("هل تريد حفظ صنف جديد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

            #region Sure
                if (txt_categ_name.Text=="")
                {
                    MessageBox.Show("من فضلك ادخل اسم الصنف", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_categ_minim.Text=="")
                {
                    MessageBox.Show("من فضلك ادخل الحد الادنى المطلوب للصنف", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmb_categ_item.Text == "")
                {
                    MessageBox.Show("من فضلك اختر فئة الصنف", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            #endregion

                retrivedata.executenonquary("Sp_ItemsInsert",
                    new paramter("@Category_ID", SqlDbType.Int, int.Parse(cmb_categ_item.SelectedValue.ToString())),
                    new paramter("@Item_Name", SqlDbType.NVarChar, txt_categ_name.Text),
                    new paramter("@Item_minimum", SqlDbType.Int, int.Parse(txt_categ_minim.Text)),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID));

                MessageBox.Show("تم الحفظ", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();
                #region btn_state
                btn_save.Enabled = false;
                #endregion

            }
            #endregion
        }

        private void grc_item_categ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                lb_id.Text = gridView1.GetFocusedRowCellValue("Item_ID").ToString();
                txt_categ_name.Text = gridView1.GetFocusedRowCellValue("Item_Name").ToString();
                txt_categ_minim.Text = gridView1.GetFocusedRowCellValue("Item_minimum").ToString();
                cmb_categ_item.SelectedValue = gridView1.GetFocusedRowCellValue("Category_ID").ToString();

                #region btn_state
                btn_save.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                #endregion
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            #region Update
            if (MessageBox.Show("هل تريد تعديل صنف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                #region Sure
                if (txt_categ_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الصنف", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_categ_minim.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل الحد الادنى المطلوب للصنف", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmb_categ_item.Text == "")
                {
                    MessageBox.Show("من فضلك اختر فئة الصنف", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                retrivedata.executenonquary("Sp_ItemsUpdate",
                    new paramter("@Item_ID", SqlDbType.Int, int.Parse(lb_id.Text).ToString()),
                    new paramter("@Category_ID", SqlDbType.Int, int.Parse(cmb_categ_item.SelectedValue.ToString())),
                    new paramter("@Item_Name", SqlDbType.NVarChar, txt_categ_name.Text),
                    new paramter("@Item_minimum", SqlDbType.Int, int.Parse(txt_categ_minim.Text)),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID));

                MessageBox.Show("تم التعديل", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();
                #region btn_state
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
            if (MessageBox.Show("هل تريد حذف صنف ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                retrivedata.executenonquary("Sp_ItemsDelete",
                new paramter("@Item_ID", SqlDbType.Int, int.Parse(lb_id.Text).ToString()));

                MessageBox.Show("تم الحذف", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();


                clear.txtclear(grp_item_categ);
                lb_id.Text = "0";

                #region btn_state
                btn_save.Enabled = false;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
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
