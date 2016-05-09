using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WS_ERP
{
    public class Controller
    {

        private DAL dal = new DAL();

        //----- COMBO BOX METHOD ---- //

        public string[] EmployeeComboBox()
        {
            return dal.EmployeeComboBox();
        }

        public string[] MetaDataComboBox()
        {
            return dal.MetaDataComboBox();
        }

        // ------ METADATA METHODS ----- //

        public List<string> GetEmployeeMetaData()
        {
            return dal.GetEmployeeMetaData();
        }

        public List<string> GetEmpRelativeMetaData() { return dal.GetEmpRelativeMetaData(); }

        public List<string> GetEmpAbsMetaData() { return dal.GetEmpAbsMetaData(); }

        public List<string> GetEmpTopAbsMetaData() { return dal.GetEmpTopAbsMetaData(); }

        public List<string> GetAllPKMetaData() { return dal.GetAllPKMetaData(); }

        public List<string> GetIndexesMetaData() { return dal.GetIndexesMetaData(); }

        public List<string> GetAllConstraintsMetaData() { return dal.GetAllConstraintsMetaData(); }

        public List<string> GetTable1MetaData() { return dal.GetTable1MetaData(); }

        public List<string> GetTable2MetaData() { return dal.GetTable2MetaData(); }

        public List<string> GetEmpColumns1MetaData() { return dal.GetEmpColumns1MetaData(); }

        public List<string> GetEmpColumns2MetaData() { return dal.GetEmpColumns2MetaData(); }



        //--------------------------------
        //Add update delete osv

        public void UpdateEmployee()
        {

        }


        //---------------------------------
        //Data om employee, relative och abscense samt mest sjuk

        //Anställda info
        public List<List<string>> GetEmployee()
        {
            return dal.GetEmployee();

        }






        //Hämta Anställda sjuk-data
        public List<List<string>> GetEmpAbsData()
        {
            return dal.GetEmpAbsData();

        }

        //Hämta Anställdas släkt-data
        public List<List<string>> GetEmpRelativeData()
        {
            return dal.GetEmpRelativeData();

        }

        //Hämta mest sjuka anställda
        public List<List<string>> GetEmpTopAbs()
        {
            return dal.GetEmpTopAbs();

        }


        // Hämta all metmetaData
        //--------------------------------------------------------
        //Hämta Alla Nycklar
        public List<List<string>> GetAllPK()
        {
            return dal.GetAllPK();

        }

        // Hämta alla indexes
        public List<List<string>> GetIndexes()
        {
            return dal.GetIndexes();

        }


        // Hämta alla tableConstraints
        public List<List<string>> GetAllConstraints()
        {
            return dal.GetAllConstraints();

        }



        // Hämta alla tabeller LÖSNING 1
        public List<List<string>> GetTable1()
        {
            return dal.GetTable1();

        }

        //Hämta alla tabeller lösning 2
        public List<List<string>> GetTable2()
        {
            return dal.GetTable2();

        }


        // Hämta alla kolumner i employee LÖSNING 1
        public List<List<string>> GetEmpColumns1()
        {
            return dal.GetEmpColumns1();

        }


        //Hämta alla kolumner i Employee LÖSNING 2
        public List<List<string>> GetEmpColumns2()
        {
            return dal.GetEmpColumns2();

        }
    }
}