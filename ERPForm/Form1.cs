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
        }

        private void Form1_Load(
        object sender, EventArgs e)
        {
        }


        private void btnPopulate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string[][] dalList = client.GetEmployee();
                string[] colList = client.GetEmployeeMetaData();
                dataGridViewERP.DataSource = FillTable(dalList, colList);
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
            var colcount = colList.Count();
            var rowcount = dalList.Count();

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




        public DataTable PopulateTable(string[][] dalList)
        {
            var colcount = dalList[0].Count();
            var rowcount = dalList.Count();

            DataTable table = new DataTable();
            for (int i = 0; i < colcount; i++)
            {
                table.Columns.Add();
            }

            foreach (string[] sa in dalList)
            {
                table.Rows.Add(sa);
            }
            return table;
        }
    }
}
