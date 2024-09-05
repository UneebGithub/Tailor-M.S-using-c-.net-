using System;
using System.Linq;
using System.Windows.Forms;

namespace TMS
{
    public partial class AddUser : Form
    {
        private tailorMSDataContext tb;

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            tb = new tailorMSDataContext();
            userEnter ue = new userEnter();
            try
            {
                var ph = Convert.ToInt64(textBox1.Text);
                var name = textBox12.Text;
                var adr = textBox14.Text;
                var cl = Convert.ToDouble(textBox2.Text);
                var che = Convert.ToDouble(textBox3.Text);
                var was = Convert.ToDouble(textBox4.Text);
                var hi = Convert.ToDouble(textBox5.Text);
                var arm = Convert.ToDouble(textBox6.Text);
                var yor = Convert.ToDouble(textBox7.Text);
                var len = Convert.ToDouble(textBox8.Text);
                var cuf = Convert.ToDouble(textBox9.Text);
                var bck = Convert.ToDouble(textBox10.Text);
                var sel = Convert.ToDouble(textBox11.Text);

                ue.phone = ph;
                ue.FullName = name;
                ue.Address_User = adr;
                ue.collar = cl;
                ue.chest = che;
                ue.waist = was;
                ue.hip = hi;
                ue.arm = arm;
                ue.yore = yor;
                ue.lengths = len;
                ue.cuffs = cuf;
                ue.back = bck;
                ue.sleeves = sel;
                tb.userEnters.InsertOnSubmit(ue);
                tb.SubmitChanges();
                MessageBox.Show("Your Data Insert Successfully");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clear();
            }
            finally
            {
                tb.Dispose();             }
        }
        public void clear()
        {
            textBox12.Text = " ";
            textBox14.Text = " ";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                textBox7.Text = " ";
                textBox8.Text = " ";
                textBox9.Text = " ";
                textBox10.Text = " ";
                textBox11.Text = " ";


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

              
                using (var db = new tailorMSDataContext())
                {
              
                    long ph = Convert.ToInt64(textBox1.Text);
                    string name = textBox12.Text;
                    string adr = textBox14.Text;
                    double cl = Convert.ToDouble(textBox2.Text);
                    double che = Convert.ToDouble(textBox3.Text);
                    double was = Convert.ToDouble(textBox4.Text);
                    double hi = Convert.ToDouble(textBox5.Text);
                    double arm = Convert.ToDouble(textBox6.Text);
                    double yor = Convert.ToDouble(textBox7.Text);
                    double len = Convert.ToDouble(textBox8.Text);
                    double cuf = Convert.ToDouble(textBox9.Text);
                    double bck = Convert.ToDouble(textBox10.Text);
                    double sel = Convert.ToDouble(textBox11.Text);

                   
                    var user = db.userEnters.FirstOrDefault(s => s.phone == ph);

                   
                    if (user != null)
                    {
                   
                        user.FullName = name;
                        user.Address_User = adr;
                        user.collar = cl;
                        user.chest = che;
                        user.waist = was;
                        user.hip = hi;
                        user.arm = arm;
                        user.yore = yor;
                        user.lengths = len;
                        user.cuffs = cuf;
                        user.back = bck;
                        user.sleeves = sel;

                        
                        db.SubmitChanges();

                        
                        MessageBox.Show("Data updated successfully");

                        
                      
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
