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
    public partial class frm_view_acountvenors : Form
    {
        public frm_view_acountvenors()
        {
            InitializeComponent();
        }

        private void frm_view_acountvenors_Load(object sender, EventArgs e)
        {
            dgr_search.DataSource= retrivedata.execute("Sp_Ven_AccountSelectAll",CommandType.StoredProcedure);
        }
    }
}
