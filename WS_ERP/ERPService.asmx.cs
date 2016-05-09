using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_ERP
{
    /// <summary>
    /// Summary description for ERPService
    /// </summary>
    [WebService(Namespace = "http://erpimlement.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ERPService : System.Web.Services.WebService
    {

        Controller ctrl = new Controller();

        [WebMethod]
        public string[] EmployeeComboBox()
        {
            return ctrl.EmployeeComboBox();
        }

        [WebMethod]
        public string[] MetaDataComboBox()
        {
            return ctrl.MetaDataComboBox();
        }

        [WebMethod]
        public List<string> GetEmployeeMetaData()
        {
            return ctrl.GetEmployeeMetaData();
        }

        [WebMethod]
        public List<string> GetEmpRelativeMetaData() { return ctrl.GetEmpRelativeMetaData(); }
        [WebMethod]
        public List<string> GetEmpAbsMetaData() { return ctrl.GetEmpAbsMetaData(); }
        [WebMethod]
        public List<string> GetEmpTopAbsMetaData() { return ctrl.GetEmpTopAbsMetaData(); }
        [WebMethod]
        public List<string> GetAllPKMetaData() { return ctrl.GetAllPKMetaData(); }
        [WebMethod]
        public List<string> GetIndexesMetaData() { return ctrl.GetIndexesMetaData(); }
        [WebMethod]
        public List<string> GetAllConstraintsMetaData() { return ctrl.GetAllConstraintsMetaData(); }
        [WebMethod]
        public List<string> GetTable1MetaData() { return ctrl.GetTable1MetaData(); }
        [WebMethod]
        public List<string> GetTable2MetaData() { return ctrl.GetTable2MetaData(); }
        [WebMethod]
        public List<string> GetEmpColumns1MetaData() { return ctrl.GetEmpColumns1MetaData(); }
        [WebMethod]
        public List<string> GetEmpColumns2MetaData() { return ctrl.GetEmpColumns2MetaData(); }


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

   /*     [WebMethod]
        //GET COLUMN NAMES
        public List<string> GetColumns(string s)
        {
            return ctrl.GetColumns(s);
        } */

        [WebMethod]
        //EMPLOYEE DATA
        public List<List<string>> GetEmployee()
        {
            return ctrl.GetEmployee();
        }

        [WebMethod]
        //PERSONAL OCH SLÄKTINGAR 
        public List<List<string>> GetEmpRelativeData()
        {
            return ctrl.GetEmpRelativeData();
        }

        [WebMethod]
        //FRÅNVARO PGA SJUKDOM 2004
        public List<List<string>> GetEmpAbsData()
        {
            return ctrl.GetEmpAbsData();
        }

        [WebMethod]
        //ANSTÄLLDA SOM VARIT MEST SJUKA
        public List<List<string>> GetEmpTopAbs()
        {
            return ctrl.GetEmpTopAbs();
        }

        [WebMethod]
        //ALL PRIMARY KEYS
        public List<List<string>> GetAllPK()
        {
            return ctrl.GetAllPK();
        }

        [WebMethod]
        //ALL INDEXES
        public List<List<string>> GetIndexes()
        {
            return ctrl.GetIndexes();
        }


        [WebMethod]
        //ALL TABLE_CONSTRAINTS
        public List<List<string>> GetAllConstraints()
        {
            return ctrl.GetAllConstraints();
        }


        [WebMethod]
        //ALL TABLES IN DB
        public List<List<string>> GetTable1()
        {
            return ctrl.GetTable1();
        }


        [WebMethod]
        //ALL TABLES IN DB #2
        public List<List<string>> GetTable2()
        {
            return ctrl.GetTable2();
        }


        [WebMethod]
        //ALL COLUMNS IN EMPLOYEE
        public List<List<string>> GetEmpColumns1()
        {
            return ctrl.GetEmpColumns1();
        }

        [WebMethod]
        //ALL COLUMNS IN EMPLOYEE - #2
        public List<List<string>> GetEmpColumns2()
        {
            return ctrl.GetEmpColumns2();
        }




    }
}
