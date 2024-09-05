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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        tailorMSDataContext ms;
        private void button1_Click(object sender, EventArgs e)
        {
            ms = new tailorMSDataContext();
            loginnn lg = new loginnn();
            try
            {
                
                
                        
                    
                    var textuser = textBox1.Text;
                    var textpass = textBox2.Text;

                    var check = ms.loginnns.FirstOrDefault(loginnn => loginnn.username == textuser && loginnn.pass == textpass);
                    if (check != null)
                    {
                       // Form1 fm=new Form1();   
                        TM_System tm = new TM_System();
                        tm.ShowDialog();
                    


                    }
                    else
                    {
                        label4.Text = "Your Username or Password Is Wrong";
                        textBox1.Text = " ";
                        textBox2.Text = " ";
                        textBox1.Focus();
                    }
                
                }catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           //this.Close();
           // this.Dispose();
        }
    }
}
