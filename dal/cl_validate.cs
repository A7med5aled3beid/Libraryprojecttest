using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Librarypro.dal
{
    class cl_validate
    {
        public void txtclear(GroupBox grb) 
        {
            foreach (Control item in grb.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            //foreach (Control item in frm.Controls)
            //{
            //    if (item is GroupBox)
            //    {
            //        foreach (Control itemGroup in pnl.Controls)
            //        {
            //            if (itemGroup is TextBox)
            //            {
            //                itemGroup.Text = string.Empty;
            //            }

            //            if (itemGroup is ComboBox)
            //            {
            //                itemGroup.Text = string.Empty;
            //            }
            //        }
            //    }
            //}
        }
    }
}
