using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interviews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Variables
        int slnos;
        bool active = true;
        string company;
        string recruiter;
        string date;
        string status;
        string result;
        string time;
        string[] allfiles = new string[]
            {
                "Interview Status.xlsx"
            };
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable data = DataAccess.GetLastIdInt();
            {
                slnos = int.Parse(data.Rows[0]["Expr1000"].ToString()) + 1;
            }
            bool restorefromgooglederive = Utilities.RestoreItFromGoogleDrive(allfiles);
            if (restorefromgooglederive)
            {
                MessageBox.Show("Restored from Google Drive");
            }
            else { MessageBox.Show("Error in restoring"); }
            txtSlnos.Text = slnos.ToString();
            rbtnActive.Checked = true;

            LoadGridView();
            txtCompany.Focus();
        }

        private void LoadGridView()
        {
            dgvInterview.DataSource = null;
            DataTable records = DataAccess.GetAllRecordsIntActive();
            dgvInterview.DataSource = records;
        }

        private void btnIntAdd_Click(object sender, EventArgs e)
        {
            slnos = int.Parse(txtSlnos.Text);
            if (txtCompany.Text == string.Empty || txtRecruiter.Text == string.Empty || cmbStatusInt.Text == "Select")
            {
                MessageBox.Show("Check the Company Name" + Environment.NewLine + "Check the Recruiter Name" + Environment.NewLine + "Check the Status" + Environment.NewLine + "Check the Result");
            }
            else
            {
                company = txtCompany.Text.Trim();
                recruiter = txtRecruiter.Text.Trim();
                date = dtpDate.Value.ToShortDateString();
                time = dtpTime.Value.ToShortTimeString();
                status = cmbStatusInt.SelectedItem.ToString();
                if (cmbResult.SelectedText.ToString() == "")
                {
                    result = "Awaiting";
                }

            }

            InterviewModel interview = new InterviewModel()
            {
                SlNo = slnos,
                Company = company,
                Recruiter = recruiter,
                EventDate = date,
                EventTime = time,
                Status = status,
                Result = result,
                Active = active,
                InterviewMonth = DataAccess.ConvertIntToMonth(dtpDate.Value.Month),
                InterviewYear = dtpDate.Value.Year
            };

            var success = DataAccess.AddDetailsInt(interview);
            if (success)
            {
                MessageBox.Show("Added successfully");
                txtCompany.Text = "";
                txtRecruiter.Text = "";
                cmbStatusInt.Text = "Select";
                cmbResult.Text = "Awaiting";
                btnIntDelete.Enabled = true;
                DataTable data = DataAccess.GetLastIdInt();
                {
                    slnos = int.Parse(data.Rows[0]["Expr1000"].ToString()) + 1;
                }
                txtSlnos.Text = slnos.ToString();
                txtCompany.Focus();
                LoadGridView();
            }
            else { MessageBox.Show("Check the error"); }
        }

        private void btnIntUpdate_Click(object sender, EventArgs e)
        {
            //company = txtCompany.Text.Trim();
            date = dtpDate.Value.ToShortDateString();
            time = dtpTime.Value.ToShortTimeString();
            status = cmbStatusInt.SelectedItem.ToString();
            if (cmbResult.SelectedText.ToString() != String.Empty)
            {
                result = cmbResult.SelectedText.ToString();
            }else { result = "Awaiting"; }

            try
            {
                InterviewModel interview = new InterviewModel()
                {
                    //Company = company,
                    EventDate1 = date,
                    EventTime1 = time,
                    Status1 = status,
                    //Active = active,
                    Result = result,
                    InterviewMonth = DataAccess.ConvertIntToMonth(dtpDate.Value.Month),
                    InterviewYear = dtpDate.Value.Year,
                    SlNo = int.Parse(txtSlnos.Text)
                };
                bool flag = DataAccess.UpdateInterview(interview);
                if (flag)
                {
                    DataTable data = DataAccess.GetAllRecordsInt(true);
                    //this.LoadDataGridView(data);
                    MessageBox.Show("Updated Successfully");
                    DataTable intdata = DataAccess.GetLastIdInt();
                    {
                        slnos = int.Parse(intdata.Rows[0]["Expr1000"].ToString()) + 1;
                    }
                    txtSlnos.Text = slnos.ToString();
                    txtCompany.Text = "";
                    txtRecruiter.Text = "";
                    cmbStatusInt.Text = "Select";
                    cmbResult.Text = "Awaiting";
                    dtpDate.Text = DateTime.Now.ToShortDateString();
                    dtpTime.Text = DateTime.Now.ToShortDateString();
                    btnIntAdd.Enabled = true;
                    btnIntUpdate.Enabled = false;
                    btnIntDelete.Enabled = false;
                    LoadGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtCompany.Text = "";
            }
        }

        private void btnIntDelete_Click(object sender, EventArgs e)
        {


            bool flag = DataAccess.DeleteInterview(slnos);

            if (flag)
            {
                DataTable data = DataAccess.GetAllRecordsInt(true);
                //this.LoadDataGridView(data);
                MessageBox.Show("Deleted Successfully");
                txtSlnos.Text = txtCompany.Text = "";
                DataTable datas = DataAccess.GetLastIdInt();
                {
                    slnos = int.Parse(datas.Rows[0]["Expr1000"].ToString()) + 1;
                }
                txtSlnos.Text = slnos.ToString();
                cmbStatusInt.Text = "Select";
            }
        }

        private void btnShowAllInt_Click(object sender, EventArgs e)
        {
            dgvInterview.DataSource = null;
            DataTable records = DataAccess.GetAllRecordsInt(true);
            if (records.Rows.Count > 0)
            {
                dgvInterview.DataSource = records;
                rbtnActive.Checked = false;
                rbtnDeActive.Checked = false;
            }
            else { MessageBox.Show("No Records found"); }
        }

        private void rbtnActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnActive.Checked == true)
            {
                dgvInterview.DataSource = null;
                DataTable records = DataAccess.GetAllRecordsIntActive();
                active = true;
                if (records.Rows.Count > 0)
                {

                    dgvInterview.DataSource = records;
                    rbtnActive.Checked = true;
                    rbtnDeActive.Checked = false;
                }
                else { MessageBox.Show("No Records found"); }
            }
        }

        private void rbtnDeActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDeActive.Checked == true)
            {
                dgvInterview.DataSource = null;
                DataTable records = DataAccess.GetAllRecordsIntDeActive();
                active = false;
                if (records.Rows.Count > 0)
                {

                    dgvInterview.DataSource = records;
                    rbtnActive.Checked = false;
                    rbtnDeActive.Checked = true;
                }
                else { MessageBox.Show("No Records found"); }
            }
        }

        private void btnShowByMonths_Click(object sender, EventArgs e)
        {

            dgvInterview.DataSource = null;
            DataTable records = DataAccess.GetAllRecordsByMonth(mth);
            if (records.Rows.Count > 0)
            {

                dgvInterview.DataSource = records;
                rbtnActive.Checked = false;
                rbtnDeActive.Checked = true;
            }
            else { MessageBox.Show("No Records found"); }
        }

        string mth;
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            mth = cmbMonth.SelectedItem.ToString();
            btnShowByMonths.PerformClick();
        }

        private void dgvInterview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int currentRow = dgvInterview.SelectedCells[0].RowIndex;
            ////MessageBox.Show("cell content click");
            //try
            //{
            //    string Id = dgvInterview[0, currentRow].Value.ToString();
            //    slnos = int.Parse(Id);
            //    txtSlnos.Text = Id;
            //    txtCompany.Text = dgvInterview[1, currentRow].Value.ToString();
            //    dtpDate.Value = Convert.ToDateTime(dgvInterview[2, currentRow].Value);
            //    dtpTime.Value = dgvInterview[3, currentRow].Value;
            //    cmbStatusInt.Text = dgvInterview[4, currentRow].Value.ToString();
            //    cmbResult.Text = dgvInterview[5, currentRow].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dgvInterview_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string Id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    slnos = int.Parse(Id);

                    DataRow dataRow = DataAccess.GetInterviewDetailsById(slnos);

                    txtSlnos.Text = dataRow["SlNo"].ToString();
                    txtCompany.Text = dataRow["Company"].ToString();
                    dtpDate.Value = Convert.ToDateTime(dataRow["EventDate"]);
                    dtpTime.Value = Convert.ToDateTime(dataRow["EventTime"]);
                    cmbStatusInt.Text = dataRow["Status"].ToString();
                    txtRecruiter.Text = dataRow["Recruiter"].ToString();
                    //cmbResult.Text = dataRow["Result"].ToString();
                    //txtItem1.Text = dataRow["Item"].ToString();
                    //txtExpense1.Text = dataRow["Expense"].ToString();
                    //Dtp1.Value = Convert.ToDateTime(dataRow["DateSpent"]);
                    //txt2Salary.Text = dataRow["Salary"].ToString() == "0.0000" ? string.Empty : dataRow["Salary"].ToString();
                    btnIntAdd.Enabled = false;
                    btnIntUpdate.Enabled = true;
                    btnIntDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bool saveittogoogle = Utilities.SaveItToGoogleDrive(allfiles);
            bool saveittoDbBackup = Utilities.SaveItToDbBackup(allfiles);
            if (saveittogoogle == true && saveittoDbBackup == true)
            {
                MessageBox.Show("Updated in Google Drive and Local Database");
            }
            else { MessageBox.Show("Error in saving"); }

            //if (saveittoDbBackup)
            //{
            //    MessageBox.Show("Updated in Local Backup");
            //}
            //else { MessageBox.Show("Error in saving"); }
            Application.Exit();
        }
    }
}
