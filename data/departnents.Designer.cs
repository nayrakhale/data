using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data;

namespace data
{
    public partial class Departnents : Form
    {
        Functions Con;
        public Departnents()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDepartments();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Departnents
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Departnents";
            this.Text = "z";
            this.ResumeLayout(false);

        }

        private void ShowDepartments()
        {
            string Query = "Select * from DepartmentTb1";
            DepList.DataSource = Con.GetData(Query);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTb1 values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;

        public object DepNameTb { get; private set; }
        public object DepList { get; private set; }

        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text != "")
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Update DepartmentTb1 set Depname = '{0}' where Depid = {1}";
                    Query = string.Format(Query, DepNameTb.Text, key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated!!!");
                    DepNameTb.Text = "";
                }
                else
                {
                    MessageBox.Show("missing data!!!");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepNameTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartmentTb1 where Depid = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();
        }

        private class Functions
        {
            public Functions()
            {
            }

            internal void SetData(string query)
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class Salary
    {
        public Salary()
        {
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}