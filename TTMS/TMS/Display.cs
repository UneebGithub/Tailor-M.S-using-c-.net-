using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class Display : Form
    {
       
        public Display()
        {
            InitializeComponent();
        }
        tailorMSDataContext tb;
        private void Display_Load(object sender, EventArgs e)
        {
            tb = new tailorMSDataContext();
            var check = from t in tb.userEnters select t;
            dataGridView1.DataSource = check.ToList();

        }
    }
}
