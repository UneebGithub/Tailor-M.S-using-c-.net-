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
    public partial class Delete_Userinfo : Form
    {
        public Delete_Userinfo()
        {
            InitializeComponent();
           
        }

        tailorMSDataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (var db = new tailorMSDataContext())
                {
                  
                    long ph = Convert.ToInt64(textBox1.Text);

                   
                    var ck = db.userEnters.FirstOrDefault(s => s.phone == ph);

                   
                    if (ck != null)
                    {
                   
                        db.userEnters.DeleteOnSubmit(ck);

                       
                        db.SubmitChanges();

                        MessageBox.Show("Data deleted successfully");

                        
                        dataGridView1.DataSource = db.userEnters.ToList();
                    }
                    else
                    {
                        
                        MessageBox.Show("No record found with the provided phone number");
                    }
                }
            }
           
            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }
    }
}
