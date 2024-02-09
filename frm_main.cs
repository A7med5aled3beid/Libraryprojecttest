using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Librarypro.PL;

namespace Librarypro
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private bool IsformActivated(Form frm) 
        {
            bool IsOpened = false;
            if (MdiChildren.Count()>0)
            {
                foreach (var item in MdiChildren)
                {
                    if (frm.Name==item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpened = true;
                    }
                }
            }
            return IsOpened;
        }

        private void Viewform(Form _form) 
        {
            if (!IsformActivated(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
            
        }
        #region btn_main_buttens_by_pn_Right
        private void btn_home_Click(object sender, EventArgs e)
        {
            frm_home fr_home = new frm_home();
            Viewform(fr_home);

            lb_title.Text = "الرئيسية";
        }


        private void btn_cust_ven_Click(object sender, EventArgs e)
        {
            if (pn_cust_ven.Height == 68)
            {
                pn_cust_ven.Height = 150;


            }
            else
            {
                pn_cust_ven.Height = 68;

            }
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            if (pn_emp.Height == 68)
            {
                pn_emp.Height = 150;


            }
            else
            {
                pn_emp.Height = 68;

            }
        }

        private void btn_items_Click(object sender, EventArgs e)
        {
            if (pn_items.Height == 68)
            {
                pn_items.Height = 150;


            }
            else
            {
                pn_items.Height = 68;

            }
        }

        private void btn_stores_Click(object sender, EventArgs e)
        {
            if (pn_stores.Height == 68)
            {
                pn_stores.Height = 194;


            }
            else
            {
                pn_stores.Height = 68;

            }
        }

        private void btn_purch_Click(object sender, EventArgs e)
        {
            if (pn_purch.Height == 68)
            {
                pn_purch.Height = 150;


            }
            else
            {
                pn_purch.Height = 68;

            }
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            if (pn_sale.Height == 68)
            {
                pn_sale.Height = 150;


            }
            else
            {
                pn_sale.Height = 68;

            }
        }

        private void btn_reprot_Click(object sender, EventArgs e)
        {

        }
        #endregion
        
       
        #region btn_close_collapse_max_min
        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if (pn_rghit.Width == 274)
            {
                pn_rghit.Width = 90;
                pn_titelrghit.Visible = false;
                pn_headerright.Height = 100;

            }
            else
            {
                pn_rghit.Width = 274;
                pn_titelrghit.Visible = true;
                pn_headerright.Height = 142;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region btn_custANDven_data
        private void btn_cust_data_Click(object sender, EventArgs e)
        {
            frm_cust_data frm_cust_date = new frm_cust_data();
            Viewform(frm_cust_date);
            lb_title.Text = "تسجيل بيانات العملاء";


        }

        private void btn_ven_data_Click(object sender, EventArgs e)
        {
            frm_ven_data frm_ven_date = new frm_ven_data();
            Viewform(frm_ven_date);
            lb_title.Text = "تسجيل بيانات الموردين";

        }
        #endregion

        #region btn_emplyee
        private void btn_emp_data_Click(object sender, EventArgs e)
        {
            frm_emp_data frm_emp_date = new frm_emp_data();
            Viewform(frm_emp_date);
            lb_title.Text = "تسجيل بيانات الموظفين";
        }

        private void btn_jop_data_Click(object sender, EventArgs e)
        {
            frm_joptype frm_joptype = new frm_joptype();
            Viewform(frm_joptype);
            lb_title.Text = "نوع الوظيفة";
        }
        #endregion

        #region btn_category
        private void btn_item_categories_Click(object sender, EventArgs e)
        {
            frm_itemscateg frm_itemscateg = new frm_itemscateg();
            Viewform(frm_itemscateg);
            lb_title.Text = "بيانات فئات الاصناف";
        }

        private void btn_catego_data_Click(object sender, EventArgs e)
        {
            frm_categories_data frm_item_categories = new frm_categories_data();
            Viewform(frm_item_categories);
            lb_title.Text = "بيانات الاصناف";
        }
        #endregion

        #region btn_store
        private void btn_store_data_Click(object sender, EventArgs e)
        {
            frm_store_data frm_store_data = new frm_store_data();
            Viewform(frm_store_data);
            lb_title.Text = "بيانات المخازن";
        }

        private void btn_store_convert_Click(object sender, EventArgs e)
        {
            frm_store_convert frm_store_convert = new frm_store_convert();
            Viewform(frm_store_convert);
            lb_title.Text = "تحويلات المخازن";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frm_distributeitem frm_store_Quanty = new frm_distributeitem();
            Viewform(frm_store_Quanty);
            lb_title.Text = "توزيع الاصناف على المخازن";
        }

        #endregion

        #region btn_purch
        private void btn_make_purch_Click(object sender, EventArgs e)
        {
            frm_purchases frm_purchases = new frm_purchases();
            Viewform(frm_purchases);
            lb_title.Text = "عملية شراء";
        }
       
        private void btn_view_ven_account_Click(object sender, EventArgs e)
        {
            frm_view_acountvenors frm_viewAcount = new frm_view_acountvenors();
            Viewform(frm_viewAcount);
            lb_title.Text = "عرض حسابات مورد";
        }
        #endregion

        #region btn_sales
        private void btn_make_sale_Click(object sender, EventArgs e)
        {
            frm_sales frm_sales = new frm_sales();
            Viewform(frm_sales);
            lb_title.Text = "عملية بيع";
        }

        private void btn_view_cust_account_Click(object sender, EventArgs e)
        {

            frm_view_Accountcust frm_viewAcount = new frm_view_Accountcust();
            Viewform(frm_viewAcount);
            lb_title.Text = "عرض حركة عميل";
        }
        #endregion

        #region form_load
        private void frm_main_Load(object sender, EventArgs e)
        {
            frm_home fr_home = new frm_home();
            Viewform(fr_home);

            lb_title.Text = "الرئيسية";
        }
        #endregion

        #region mnstr_custAndvendor
        private void تسجيلبياناتالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_cust_data frm_cust_date = new frm_cust_data();
            Viewform(frm_cust_date);
            lb_title.Text = "تسجيل بيانات العملاء";
        }

        private void تسجيلبياناتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ven_data frm_ven_date = new frm_ven_data();
            Viewform(frm_ven_date);
            lb_title.Text = "تسجيل بيانات الموردين";

        }
        #endregion

        #region mnstr_emplyee
        private void تسجيلبياناتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_emp_data frm_emp_date = new frm_emp_data();
            Viewform(frm_emp_date);
            lb_title.Text = "تسجيل بيانات الموظفين";
        }

        private void اضافةالوظائفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_joptype frm_joptype = new frm_joptype();
            Viewform(frm_joptype);
            lb_title.Text = "نوع الوظيفة";
        }
        #endregion

        #region mnstr_category
        private void تسجيلفئاتالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_itemscateg frm_itemscateg = new frm_itemscateg();
            Viewform(frm_itemscateg);
            lb_title.Text = "بيانات فئات الاصناف";
        }

        private void تسجيلبياناتالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_categories_data frm_item_categories = new frm_categories_data();
            Viewform(frm_item_categories);
            lb_title.Text = "بيانات الاصناف";
        }
        #endregion

        #region mnstr_store
        private void بياناتالمخازنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_store_data frm_store_data = new frm_store_data();
            Viewform(frm_store_data);
            lb_title.Text = "بيانات المخازن";
        }

        private void تحويلاتالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_store_convert frm_store_convert = new frm_store_convert();
            Viewform(frm_store_convert);
            lb_title.Text = "تحويلات المخازن";
        }
        #endregion

        #region mnst_make_purchANDdata
        private void اجراءعملياتالشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_purchases frm_purchases = new frm_purchases();
            Viewform(frm_purchases);
            lb_title.Text = "عملية شراء";
        }
         private void سدادموردToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        frm_Account_Vendores frm_account = new frm_Account_Vendores();
                        Viewform(frm_account);
                        lb_title.Text = "سداد مورد";
                    }
        private void اجراءعملياتالبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_sales frm_sales = new frm_sales();
            Viewform(frm_sales);
            lb_title.Text = "عملية بيع";
        }
        #endregion

        private void عرضحساباتموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_view_acountvenors frm_viewAcount = new frm_view_acountvenors();
            Viewform(frm_viewAcount);
            lb_title.Text = "عرض حسابات مورد";
        }

        private void عرضحركةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_view_Accountcust frm_viewAcount = new frm_view_Accountcust();
            Viewform(frm_viewAcount);
            lb_title.Text = "عرض حركة عميل";
        }

        private void سدادعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Account_Customers frm_Acount = new frm_Account_Customers();
            Viewform(frm_Acount);
            lb_title.Text = "سداد عميل";
        }

        private void btn_payed_Click(object sender, EventArgs e)
        {
            if (pnl_payed.Height == 68)
            {
                pnl_payed.Height = 150;


            }
            else
            {
                pnl_payed.Height = 68;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_Account_Customers frm_Acount = new frm_Account_Customers();
            Viewform(frm_Acount);
            lb_title.Text = "سداد عميل";
        }

        private void btn_ven_payed_Click(object sender, EventArgs e)
        {
            frm_Account_Vendores frm_account = new frm_Account_Vendores();
            Viewform(frm_account);
            lb_title.Text = "سداد مورد";
        }

        private void عناToolStripMenuItem_Click(object sender, EventArgs e)
        {
            me frm = new me();
            Viewform(frm);
            lb_title.Text = "";
        }

     

    }
}
