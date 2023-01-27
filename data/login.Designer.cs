using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeMgmt1;

namespace data
{
    public partial class login : Form
    {
        //make aclass called forrm
        private readonly object UNameTb;

        public object PasswordTb { get; private set; }
        //password table
        public login()
        {
            InitializeComponent();
        }

        private void InitializeComponent() => throw new NotImplementedException();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //picturebox1

        }

        private void login_Load(object sender, EventArgs e)
        {
            //loginload
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //text box
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if statement to when enter your paassword
            if (UNameTb.Text != "" && PasswordTb.Text != "")
            {
                //to when enter password and admin
                if (UNameTb.Text == "Admin" && PasswordTb.text == "Password")
                {
                    //password
                    Employees Obj = new Employees();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong user name or password!!!");
                    //message show

                    UNameTb.Text = "";
                    //Uname tale
                    PasswordTb.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Missing Data!!!");
                //messagebox show
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3

        }

        private void ResetLbl_Click(object sender, EventArgs e)
        {
            //Resettaple
            UNameTb.Text = "";
            PasswordTb.Text = "";
            //enter again password 
        }
    }
}