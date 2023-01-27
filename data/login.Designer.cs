using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class login : Form
    {
        public object PasswordTb { get; private set; }
        public object UNameTb { get; private set; }

        public login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e, PasswordTb);
        }

        private void button1_Click(object sender, EventArgs e, object passwordTb)
        {
            if (UNameTb.Text != ""
                && passwordTb.Text != "")
            {
                if (UNameTb.Text == "Admin" && PasswordTb.Text == "Password")
                {
                    Employees Obj = new Employees();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong user name or password!!!");
                    UNameTb.Text = "";
                    PasswordTb.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Missing Data!!!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ResetLbl_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }
    }

    internal class Employees
    {
        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}