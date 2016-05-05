using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_ERP
{
    public class Controller
    {

        private DAL dal = new DAL();
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