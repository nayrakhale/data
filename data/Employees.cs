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

namespace EmployeeMgmt1
{
    public partial class Employees : Form
    {
        //class employees
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();
            //get department
        }
        private void ShowEmp()
        {
            try
            {
                string Query = "Select * from EmployeeTb1";
                EmployeeList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //text changed
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //text changed
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //text changed
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1_SelectedIndexChanged
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // Employees_Load
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2_Click
        }

        private void GetDepartment()
        {
            string Query = "Select * from DepartmentTb1";
            DepCb.DisplayMember = Con.GetData(Query).Columns["Depname"].ToString();
            DepCb.ValueMember = Con.GetData(Query).Columns["Depid"].ToString();
            DepCb.DataSource = Con.GetData(Query);

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    //string DOB
                    string JDate = JDateTb.Value.ToString();
                    //string JDate
                   
                    
                    string Query = "insert into EmployeeTb1 values('{0}','{1}',{2},'{3}','{4}',{5})";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Emoloyee Updated!!!");
                    //message box


                    EmpNameTb.Text = "";
                    //empname table
                    
                    GenCb.SelectedIndex = -1;
                    //gencb
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //deletbutton
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("missing data!!!");
                    //show message box

                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);
                    string Query = "Delete from EmployeeTb1 where Empid= {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Emoloyee Deleted!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    //empnametable
                    string Gender = GenCb.SelectedItem.ToString();
                    //string gender
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    //int dep
                    string DOB = DOBTb.Value.Date.ToString();
                    //string DOB table
                    string JDate = JDateTb.Value.Date.ToString();
                    //string JDate
                   

                    string Query = "Update EmployeeTb1 set EmpName = '{0}',EmpGen='{1}',EmpDep={2},EmpDOB='{3}',Empjdate='{4}',EmpSal={5} where Empid= {6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate,  key);
                    //query
                    Con.SetData(Query);
                    //st data
                    ShowEmp();
                    MessageBox.Show("Emoloyee Updated!!!");
                    //MessageBox
                    EmpNameTb.Text = "";
                    //empnametable
                    

                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;

        public object GenCb { get; private set; }
        //gencb
        public object EmployeeList { get; private set; }
        //employeelist
        public object DepCb { get; private set; }
       //depcb
        public object DOBTb { get; private set; }
        //dobtable
        public object JDateTb { get; private set; }
        //jdatetable
        public object DailySalTb { get; private set; }
        //dailysaltable
        public object EmpNameTb { get; private set; }
        //empnametable

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //employeelist_cellcontent
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            //empnametb
            GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();

            DepCb.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DOBTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            JDateTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            DailySalTb.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
                //employeeelist
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {//lapel9
            login Obj = new login();
            //login
            Obj.Show();
            this.Hide();
        }
    }
}