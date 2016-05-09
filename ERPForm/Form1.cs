using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ERPForm.localhost;

namespace ERPForm
{
    public partial class Form1 : Form
    {
        ERPService client = new ERPService();

        public Form1()
        {

            InitializeComponent();
            comboBox1.DataSource = client.EmployeeComboBox();
            comboBoxMetaData.DataSource = client.MetaDataComboBox();
            dataGridViewERP.AllowUserToAddRows = false;
            dataGridViewERP.AllowUserToResizeRows = false;
            dataGridViewERP.AllowUserToResizeColumns = false;
            dataGridViewERP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void Form1_Load(
        object sender, EventArgs e)
        {

        }





        private void btnPopulate_Click(object sender, EventArgs e)
        {
            ClearTable();

            if (comboBox1.SelectedIndex == 0)
            {
                string[][] dalList = client.GetEmployee();
                string[] colList = client.GetEmployeeMetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
                dataGridViewERP.Columns[0].ReadOnly = true;

            }

            if (comboBox1.SelectedIndex == 1)
            {
                string[][] dalList = client.GetEmpRelativeData();
                string[] colList = client.GetEmpRelativeMetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }

            if (comboBox1.SelectedIndex == 2)
            {
                string[][] dalList = client.GetEmpAbsData();
                string[] colList = client.GetEmpAbsMetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }

            if (comboBox1.SelectedIndex == 3)
            {
                string[][] dalList = client.GetEmpTopAbs();
                string[] colList = client.GetEmpTopAbsMetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }


        }

        private void buttonMetaData_Click(object sender, EventArgs e)
        {
            dataGridViewERP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (comboBoxMetaData.SelectedIndex == 0)
            {
                string[][] dalList = client.GetAllPK();
                string[] colList = client.GetAllPKMetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }

            if (comboBoxMetaData.SelectedIndex == 1)
            {
                string[][] dalList = client.GetIndexes();
                string[] colList = client.GetIndexesMetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }

            if (comboBoxMetaData.SelectedIndex == 2)
            {
                string[][] dalList = client.GetAllConstraints();
                string[] colList = client.GetAllConstraintsMetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }

            if (comboBoxMetaData.SelectedIndex == 3)
            {
                string[][] dalList = client.GetTable1();
                string[] colList = client.GetTable1MetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }

            if (comboBoxMetaData.SelectedIndex == 4)
            {
                string[][] dalList = client.GetTable2();
                string[] colList = client.GetTable2MetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }

            if (comboBoxMetaData.SelectedIndex == 5)
            {
                string[][] dalList = client.GetEmpColumns1();
                string[] colList = client.GetEmpColumns1MetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }

            if (comboBoxMetaData.SelectedIndex == 6)
            {
                string[][] dalList = client.GetEmpColumns2();
                string[] colList = client.GetEmpColumns2MetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
            }

        }

        public DataTable FillTable(string[][] dalList, string[] colList)
        {
            int colcount = colList.Count();
            int rowcount = dalList.Count();

            DataTable table = new DataTable();
            for (int i = 0; i < colcount; i++)
            {
                table.Columns.Add(colList[i].ToString());
            }

            foreach (string[] sa in dalList)
            {
                table.Rows.Add(sa);
            }
            return table;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow row = dataGridViewERP.SelectedRows[0];

            if (row.Cells.Count > 0)
            {
                bool rowIsEmpty = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        rowIsEmpty = false;
                        break;
                    }
                }

                if (rowIsEmpty)
                    labelMessage.Text = "Select a non NULL row";
                else
                {
                    string firstName = row.Cells["First Name"].Value.ToString();
                    string no = row.Cells["No_"].Value.ToString();

                    if (client.UpdateEmployee(firstName, no))
                    {
                        dataGridViewERP.ClearSelection();
                        btnPopulate.PerformClick();
                        labelMessage.Text = "SUCCESS! Employee with No_ " + no + " has been updated!";
                    }

                }

            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            ClearTable();
            buttonInsert.Visible = false;

        }

        private void buttonInsertConfirm_Click(object sender, EventArgs e)
        {
            ClearTable();
            dataGridViewERP.AllowUserToAddRows = true;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ClearTable();
            DataGridViewRow row = dataGridViewERP.SelectedRows[0];

            if (row.Cells.Count > 0)
            {
                bool rowIsEmpty = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        rowIsEmpty = false;
                        break;
                    }
                }

                if (rowIsEmpty)
                    labelMessage.Text = "Select a non NULL row";
                else
                {
                    string no = row.Cells["No_"].Value.ToString();

                    if (client.DeleteEmployee(no))
                    {
                        dataGridViewERP.ClearSelection();
                        btnPopulate.PerformClick();
                        labelMessage.Text = "SUCCESS! Employee with No_ " + no + " has been updated!";
                        
                    }

                }

            }

        }

        private void ClearTable()
        {
            dataGridViewERP.DataSource = null;
            dataGridViewERP.Rows.Clear();
            labelMessage.ResetText();
        }
    }
}
