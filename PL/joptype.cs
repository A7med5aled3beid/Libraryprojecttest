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
    public partial class frm_joptype : Form
    {
        cl_validate clear = new cl_validate();
        public frm_joptype()
        {
            InitializeComponent();
        }
        #region blind
        void blind() 
        {
            grc_jobtype.DataSource = retrivedata.execute("Sp_Jop_TypeSelectAll", CommandType.StoredProcedure);
        }
        #endregion
        private void btn_new_Click(object sender, EventArgs e)
        {
            #region AddNew
            if (MessageBox.Show("هل تريداضافة نوع وظيفة جديد ","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
            clear.txtclear(grp_jobtype);
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
            if (MessageBox.Show("هل تريد حفظ نوع وظيفة جديد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                #region Sure
                if (txt_joptype.Text=="")
                {
                    MessageBox.Show("من فضلك ادخل اسم الوظيفة","حقل مطلوب",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                #endregion
                retrivedata.executenonquary("Sp_Jop_TypeInsert",
                    new paramter("@Job_Name", SqlDbType.NVarChar, txt_joptype.Text),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID)
                    );
                MessageBox.Show("تم الحفظ", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();
                #region btn_state
                btn_save.Enabled = false;
                #endregion

                
            }
           #endregion
        }

        private void frm_joptype_Load(object sender, EventArgs e)
        {
            blind();
        }

        private void grc_jobtype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txt_joptype.Text = gridView1.GetFocusedRowCellValue("Job_Name").ToString();
                lb_id.Text = gridView1.GetFocusedRowCellValue("Jop_ID").ToString();
                #region btn_state
                btn_save.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                #endregion
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            #region Update
            if (MessageBox.Show("هل تريد تعديل اسم وظيفة ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region Sure
                if (txt_joptype.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الوظيفة", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion
                retrivedata.executenonquary("Sp_Jop_TypeUpdate",
                    new paramter("@Jop_ID", SqlDbType.Int, int.Parse(lb_id.Text).ToString()),
                    new paramter("@Job_Name", SqlDbType.NVarChar, txt_joptype.Text),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID)
                    );
                MessageBox.Show("تم التعديل", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();
                #region btn_state
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
            if (MessageBox.Show("هل تريد حذف وظيفة ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                retrivedata.executenonquary("Sp_Jop_TypeDelete",
                    new paramter("@Jop_ID", SqlDbType.Int, int.Parse(lb_id.Text).ToString()));
                MessageBox.Show("تم الحذف", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blind();
                #region btn_state
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
