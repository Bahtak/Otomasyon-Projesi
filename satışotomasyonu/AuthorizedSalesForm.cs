using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satışotomasyonu
{
    public partial class AuthorizedSalesForm : Form
    {
        public AuthorizedSalesForm()
        {
            InitializeComponent();
        }

        private void yetkilisatışonayformu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'satisotomaosyonuDataSet5.Waiting_Orders' table. You can move, or remove it, as needed.
            this.waiting_OrdersTableAdapter.Fill(this.satisotomaosyonuDataSet5.Waiting_Orders);
          

        }

        private void yetkilionaydatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
