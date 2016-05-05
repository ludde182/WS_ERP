using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERPForm.ServiceReference1;

namespace ERPForm
{
    public partial class Form1 : Form
    {
        ERPServiceSoapClient client = new ERPServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = client.GetEmpTbl();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

           foreach(List<string> list in client.ShowAbsData() ){
                for (int i = 0; i < list.Count; i++)
                {
                    string s = list[i] + "\n";
                    richTextBox1.Text += s;
                }
            }
            }
    }
}
