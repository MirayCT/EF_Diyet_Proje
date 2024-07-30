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
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
            var userFoodManager = new UserFoodManager();
            var weeklyRep = userFoodManager.GetWeeklyReport();
            dataGridView1.DataSource = weeklyRep.Data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
