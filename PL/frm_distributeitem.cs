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
    public partial class frm_distributeitem : Form
    {
        public frm_distributeitem()
        {
            InitializeComponent();
        }
        #region blind
        void blind()
        {
            //fill combobox Store
            cmb_store.DataSource = retrivedata.execute("Sp_Store_DataSelectAll", CommandType.StoredProcedure);
            cmb_store.DisplayMember = "Store_Name";
            cmb_store.ValueMember = "Store_ID";

            //fill comobox items
            cmb_item.DataSource = retrivedata.execute("Sp_ItemsSelectAll", CommandType.StoredProcedure);
            cmb_item.DisplayMember = "Item_Name";
            cmb_item.ValueMember = "Item_ID";
        }
        #endregion

        private void frm_distributeitem_Load(object sender, EventArgs e)
        {
            blind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Sure
            if (cmb_store.Text==null)
            {
                MessageBox.Show("من فضلك اختر اسم المخزن","حقل مطلوب",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (cmb_item.Text == null)
            {
                MessageBox.Show("من فضلك اختر الصنف", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
            #region AddRow
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            DataGridViewCell cel2 = new DataGridViewTextBoxCell();
            DataGridViewCell cel3 = new DataGridViewTextBoxCell();
            DataGridViewCell cel4 = new DataGridViewTextBoxCell();
            row.Cells.Add(cel1);
            row.Cells.Add(cel2);
            row.Cells.Add(cel3);
            row.Cells.Add(cel4);
            row.Cells[0].Value = cmb_store.SelectedValue.ToString();
            row.Cells[1].Value = cmb_item.SelectedValue.ToString();
            row.Cells[2].Value = cmb_store.Text;
            row.Cells[3].Value = cmb_item.Text;
            dgv_stor.Rows.Add(row);
            #endregion
        }
        DataTable prepardatatable() 
        {
            if (dgv_stor.Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("Store_ID", typeof(int));
                dt.Columns.Add("Item_ID", typeof(int));

                for (int i = 0; i < dgv_stor.Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = dgv_stor.Rows[i].Cells[0].Value.ToString();
                    dr[1] = dgv_stor.Rows[i].Cells[1].Value.ToString();

                    dt.Rows.Add(dr);
                }

                return dt;
            }
            else 
            {
                return null;
            }
        }
        Dbconnect _con = new Dbconnect();
        private void btn_save_Click(object sender, EventArgs e)
        {
            #region Sur Data
            if (dgv_stor.RowCount==0)
            {
                MessageBox.Show("من فضلك ادخل البيانات","لايوجد بيانات",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            #endregion
            #region Save
            DataTable dt = prepardatatable();
            _con.cmd.Connection = Dbconnect.conn;
            _con.cmd.CommandType = CommandType.StoredProcedure;
            _con.cmd.CommandText = "Sp_Store_QuantityInsert";
            _con.cmd.Parameters.AddWithValue("@User_ID", login.User_ID);
            _con.cmd.Parameters.AddWithValue("@Distrubuteitems", dt);
            _con.cmd.ExecuteNonQuery();
            MessageBox.Show("تم الحفظ");
            #endregion
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Auto_Click(object sender, EventArgs e)
        {
            retrivedata.executenonquary("Sp_distributeItemsAuto", new paramter("@User_ID", SqlDbType.Int, login.User_ID));
            MessageBox.Show("تم التوزيع","عملية ناجحة",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
