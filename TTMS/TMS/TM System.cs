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
    public partial class TM_System : Form
    {
        userEnter ue = new userEnter();

        public TM_System()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser au=new AddUser();
            au.ShowDialog();

        }
        tailorMSDataContext tb;
        private void button1_Click(object sender, EventArgs e)
        {
            tb= new tailorMSDataContext();  
                     var ph=Convert.ToInt64(textBox1.Text);
            //var ch_phh=from t in tb.userEnters where t.phone == ph select t;
            var user_info = tb.userEnters.FirstOrDefault(userEnter => userEnter.phone == ph);
            if (user_info!=null)
            {
                textBox2.Text=" "+user_info.collar.ToString();
                textBox3.Text = " " + user_info.chest.ToString();
                textBox4.Text = " " + user_info.waist.ToString();
                textBox5.Text = " " + user_info.hip.ToString();
                textBox6.Text = " " + user_info.arm.ToString();
                textBox7.Text = " " + user_info.yore.ToString();
                textBox8.Text = " " + user_info.lengths.ToString();
                textBox9.Text = " " + user_info.cuffs.ToString();
                textBox10.Text = " " + user_info.back.ToString();
                textBox11.Text = " " + user_info.sleeves.ToString();
                //..textBox2.Text = " " + user_info.cuffs.ToString();


            }
            else
            {
                MessageBox.Show("User Not Found :( ");
                clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
            {
            textBox1.Focus();
            textBox1.Text = " ";
            textBox2.Text = " " ;
            textBox3.Text = " " ;
            textBox4.Text = " " ;
            textBox5.Text = " " ;
            textBox6.Text = " " ;
            textBox7.Text = " " ;
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";


        }

        private void showUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tb=new tailorMSDataContext();
            Display d = new Display();
            d.Show();
        }

        private void TM_System_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Userinfo d=new Delete_Userinfo();
            d.Show();
        }
    }
}
