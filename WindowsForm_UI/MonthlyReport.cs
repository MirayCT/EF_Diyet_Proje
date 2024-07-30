using _02Project.BusinessLogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_UI
{
    public partial class MonthlyReport : Form
    {
        public MonthlyReport()
        {
            InitializeComponent();
            var userFoodManager = new UserFoodManager();
            var monthlyRep = userFoodManager.GetMonthlyReport();
            dataGridView1.DataSource = monthlyRep.Data; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
