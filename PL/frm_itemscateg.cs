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
    public partial class frm_itemscateg : Form
    {
        public frm_itemscateg()
        {
            InitializeComponent();
        }

        void blindGrid() 
        {
            grc_itemcateg.DataSource = retrivedata.execute("Sp_Item_CategorySelectAll", CommandType.StoredProcedure);

        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            #region addnew
            if (MessageBox.Show("هل تريد اضافة فئة جديدة", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                txt_categ_name.Text = "";
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
            if (MessageBox.Show("هل تريد حفظ فئة جديدة", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region DataSure
                if (txt_categ_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الفئة", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                retrivedata.executenonquary("Sp_Item_CategoryInsert",
                    new paramter("@Category_Name", SqlDbType.NVarChar, txt_categ_name.Text),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID));
                MessageBox.Show("تم الحفظ", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                blindGrid(); 

                #region btn_state
                btn_save.Enabled = false;
                #endregion

            }
            #endregion
        }

        private void frm_itemscateg_Load(object sender, EventArgs e)
        {
            blindGrid();
        }

        private void grc_itemcateg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                lb_id.Text = gridView1.GetFocusedRowCellValue("Category_ID").ToString();
                txt_categ_name.Text = gridView1.GetFocusedRowCellValue("Category_Name").ToString();
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
                 if (lb_id.Text!="0")
            {
            if (MessageBox.Show("هل تريد تعديل فئة ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region DataSure
                if (txt_categ_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الفئة", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                retrivedata.executenonquary("Sp_Item_CategoryUpdate",
                    new paramter("@Category_ID", SqlDbType.Int, int.Parse(lb_id.Text).ToString()),
                    new paramter("@Category_Name", SqlDbType.NVarChar, txt_categ_name.Text),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID));
                MessageBox.Show("تم التعديل", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                blindGrid();

                #region btn_state
                btn_save.Enabled = false;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                #endregion
            }
                      }
            #endregion
           

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
                #region Delete

            if (lb_id.Text != "0")
            {
                if (MessageBox.Show("هل تريد حذف فئة ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    retrivedata.executenonquary("Sp_Item_CategoryDelete",
                      new paramter("@Category_ID", SqlDbType.Int, int.Parse(lb_id.Text).ToString()));
                    MessageBox.Show("تم التعديل", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lb_id.Text = "0";
                    txt_categ_name.Text = "";

                    blindGrid();
                    #region btn_state
                    btn_save.Enabled = false;
                    btn_update.Enabled = false;
                    btn_delete.Enabled = false;
                    #endregion
 
                }
 
            }

                #endregion
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
