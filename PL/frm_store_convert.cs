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
    public partial class frm_store_convert : Form
    {
        public frm_store_convert()
        {
            InitializeComponent();
        }
        #region blind
        void blind()
        {
            //fill combo box item Category
            cmb_item_categ.DataSource = retrivedata.execute("Sp_Item_CategorySelectAll", CommandType.StoredProcedure);
            cmb_item_categ.DisplayMember = "Category_Name";
            cmb_item_categ.ValueMember = "Category_ID";

            //fill combobox Store from
            cmb_convert_from.DataSource = retrivedata.execute("Sp_Store_DataSelectAll", CommandType.StoredProcedure);
            cmb_convert_from.DisplayMember = "Store_Name";
            cmb_convert_from.ValueMember = "Store_ID";

            //fill combobox Store to
            cmb_converted_to.DataSource = retrivedata.execute("Sp_Store_DataSelectAll", CommandType.StoredProcedure);
            cmb_converted_to.DisplayMember = "Store_Name";
            cmb_converted_to.ValueMember = "Store_ID";

            
        }
        #endregion
        private void frm_store_convert_Load(object sender, EventArgs e)
        {
            blind();
        }

        private void cmb_item_categ_SelectedValueChanged(object sender, EventArgs e)
        {
            #region fill combbox item
            if (cmb_item_categ.SelectedValue.ToString()!="System.Data.DataRowView")
            {
                 cmb_item_name.DataSource =
                 retrivedata.execute
                 ("Sp_Item_SelectID", CommandType.StoredProcedure,
                 new paramter("@Category_ID", SqlDbType.Int, int.Parse(cmb_item_categ.SelectedValue.ToString())));
                 cmb_item_name.DisplayMember = "Item_Name";
                 cmb_item_name.ValueMember = "Item_ID";
                 cmb_item_name.Text = "";
            #endregion
            }
        }

        private void cmb_convert_from_SelectedValueChanged(object sender, EventArgs e)
        {
            #region Quanty Now in Store from
            if (cmb_item_name.Text!="" &&cmb_convert_from.Text!="")
            {
                DataTable dt = new DataTable();
                dt = retrivedata.execute("Sp_StoreQuanty_SelectQuanty", CommandType.StoredProcedure,
                    new paramter("@Item_ID", SqlDbType.Int, int.Parse(cmb_item_name.SelectedValue.ToString())),
                    new paramter("@Store_ID", SqlDbType.Int, int.Parse(cmb_convert_from.SelectedValue.ToString())));
                txt_quant_from.Text = dt.Rows[0][0].ToString();
            }
            #endregion
        }

        private void cmb_converted_to_SelectedValueChanged(object sender, EventArgs e)
        {
            #region Quanty Now in Store to
            if (cmb_item_name.Text != "" && cmb_converted_to.Text != "")
            {
                DataTable dt = new DataTable();
                dt = retrivedata.execute("Sp_StoreQuanty_SelectQuanty", CommandType.StoredProcedure,
                    new paramter("@Item_ID", SqlDbType.Int, int.Parse(cmb_item_name.SelectedValue.ToString())),
                    new paramter("@Store_ID", SqlDbType.Int, int.Parse(cmb_converted_to.SelectedValue.ToString())));
                txt_Qant_to.Text = dt.Rows[0][0].ToString();
            }
            #endregion
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            #region convert click
            if ((double.Parse(txt_quant_convert.Text)+double.Parse(txt_after_quant.Text)) > double.Parse(txt_quant_from.Text))
            {
                MessageBox.Show("عفواً الكمية لا تسمح");
                return;
            }
            txt_after_quant.Text=(double.Parse(txt_after_quant.Text)+double.Parse(txt_quant_convert.Text)).ToString();
            #endregion
        }
        cl_validate clearcontrol = new cl_validate();
        private void btn_new_Click(object sender, EventArgs e)
        {
            #region Add new
            if (MessageBox.Show("هل تريد اضافة تحويل جديد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                clearcontrol.txtclear(grb_convert_data);
                txt_after_quant.Text = "0";
                btn_save.Enabled = true;
            }
            #endregion
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            #region Save
            if (MessageBox.Show("هل تريد حفظ تحويل جديد","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                #region Sure data
                if (txt_after_quant.Text == "0")
                {
                    MessageBox.Show("من فضلك ادخل البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtb_convert_time.Text=="")
                {
                     MessageBox.Show("من فضلك ادخل التاريخ","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                #endregion

                retrivedata.executenonquary("Sp_Store_ConvertInsert",
                    new paramter("@StoreFrom_ID", SqlDbType.Int, int.Parse(cmb_convert_from.SelectedValue.ToString())),
                    new paramter("@StoryTo_ID", SqlDbType.Int, int.Parse(cmb_converted_to.SelectedValue.ToString())),
                    new paramter("@Item_ID", SqlDbType.Int, int.Parse(cmb_item_name.SelectedValue.ToString())),
                    new paramter("@Item_Quantity", SqlDbType.Int, int.Parse(cmb_item_categ.SelectedValue.ToString())),
                    new paramter("@Con_Date", SqlDbType.Date, dtb_convert_time.Text),
                    new paramter("@Con_Notes", SqlDbType.NVarChar, txt_convert_nots.Text),
                    new paramter("@User_ID", SqlDbType.Int, login.User_ID) );
                MessageBox.Show("تم التحويل", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DataTable dt = new DataTable();
                //dt = retrivedata.execute("Sp_Store_Convert_selectAll", CommandType.StoredProcedure);
                //int Con_ID= dt.Rows.Count;
                //grc_convert_data.DataSource = retrivedata.execute("Sp_Store_Convert_selectbyID", CommandType.StoredProcedure,
                //    new paramter("@Con_ID", SqlDbType.Int, Con_ID),
                //    new paramter("@Item_ID", SqlDbType.Int, int.Parse(cmb_item_name.SelectedValue.ToString())));

                btn_save.Enabled = false;
            }

            #endregion
        }
    }
}
