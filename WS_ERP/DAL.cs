using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace WS_ERP
{
    public class DAL
    {
        SqlConnection con = new SqlConnection();

        public DAL()
        {
            con.ConnectionString =
    "user id=cronus;" +
    "password=cronus;server=localhost;" +
    "Trusted_Connection=yes;" +
    "database=Demo Database NAV (5-0); " +
    "connection timeout=30";
        }
        //---------------------- SHOW DATA METHOD ----------------------//

        public List<List<string>> ShowData(string s)
        {
            try
            {
                con.Open();
                string query = s;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader datareader = cmd.ExecuteReader();
                List<List<string>> list = new List<List<string>>();

                if (datareader != null)
                {

                    while (datareader.Read())
                    {
                        List<string> tmp = new List<string>();
                        string data = "";
                        for (int i = 0; i < datareader.FieldCount; i++)
                        {
                            if (!datareader.IsDBNull(i))
                            {

                                if (datareader.GetFieldType(i) == typeof(string))
                                {

                                    data = (string)datareader.GetString(i);
                                }

                                if (datareader.GetFieldType(i) == typeof(int))
                                {

                                    int integer = datareader.GetInt32(i);
                                    data = integer.ToString();
                                }

                                tmp.Add(data);
                            }
                            else if(datareader.IsDBNull(i))
                            {
                                data = "NULL";
                                tmp.Add(data);
                            }
                        }
                        list.Add(tmp);
                    }
                    return list;
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.ToString());
                return null;

            }
        }


        //---------------------- VIEW COMBO BOX METHODS ----------------------//

        public string[] EmployeeComboBox()
        {
            string[] list = new string[4];
            list[0] = "Employee data & metadata";
            list[1] = "Employee relative data";
            list[2] = "Employee abscence due to sickness: 2004";
            list[3] = "Employee names - most abscent";
            return list;

        }

        public string[] MetaDataComboBox()
        {
            string[] list = new string[7];
            list[0] = "Get all keys";
            list[1] = "Get all indexes";
            list[2] = "Get all constraints";
            list[3] = "Get all tables #1";
            list[4] = "Get all tables #2";
            list[5] = "Get all columns #1";
            list[6] = "Get all columns #2";
            return list;
        }


        //---------------------- VIEW COMBO BOX METHODS ----------------------//
        public List<string> GetTableMetaData(string s)
        {
            con.Open();
            string query = s;
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            List<string> columnList = new List<string>();
            if (ds != null)
            {
                foreach (DataColumn dc in ds.Columns)
                {
                    columnList.Add(dc.ColumnName.ToString());
                }
                return columnList;
            }
            return columnList;
        }

        //---------------------- INSERT/UPDATE/DELETE QUERIES ----------------------//






        //---------------------- SELECT QUERIES ----------------------//

        //EMPLOYEE DATA
        public List<List<string>> GetEmployee()
        {
            string s = "SELECT [First Name],[No_] from[CRONUS Sverige AB$Employee];";
            return ShowData(s);
        }

        //METADATA
        public List<string> GetEmployeeMetaData()
        {
            string s = "SELECT [First Name],[No_] from[CRONUS Sverige AB$Employee]; ";
            return GetTableMetaData(s);
        }



        //PERSONAL OCH SLÄKTINGAR 
        public List<List<string>> GetEmpRelativeData()
        {
            string s = "SELECT[CRONUS Sverige AB$Employee].[First Name],[CRONUS Sverige AB$Employee].[Last Name], No_, [Relative Code],"
                                                + "[CRONUS Sverige AB$Employee Relative].[First Name], [CRONUS Sverige AB$Employee Relative].[Last Name] FROM [CRONUS Sverige AB$Employee] "
                                                + "INNER JOIN [CRONUS Sverige AB$Employee Relative] ON  No_ = [Employee No_];";
            return ShowData(s);
        }

        //METADATA
        public List<string> GetEmpRelativeMetaData()
        {
            string s = "SELECT[CRONUS Sverige AB$Employee].[First Name],[CRONUS Sverige AB$Employee].[Last Name], No_, [Relative Code],"
                                                + "[CRONUS Sverige AB$Employee Relative].[First Name], [CRONUS Sverige AB$Employee Relative].[Last Name] FROM [CRONUS Sverige AB$Employee] "
                                                + "INNER JOIN [CRONUS Sverige AB$Employee Relative] ON  No_ = [Employee No_];";
            return GetTableMetaData(s);
        }

        //FRÅNVARO PGA SJUKDOM 2004
        public List<List<string>> GetEmpAbsData()
        {
            string s = "SELECT * from [CRONUS Sverige AB$Employee Absence] WHERE [From Date] LIKE '%2004%' AND [Cause of Absence Code] = 'SJUK';";
            return ShowData(s);
        }

        //METADATA
        public List<string> GetEmpAbsMetaData()
        {
            string s = "SELECT * from [CRONUS Sverige AB$Employee Absence] WHERE [From Date] LIKE '%2004%' AND [Cause of Absence Code] = 'SJUK';";
            return GetTableMetaData(s);
        }

        //ANSTÄLLDA SOM VARIT MEST SJUKA
        public List<List<string>> GetEmpTopAbs()
        {
            string s = "SELECT TOP 3 E.[First Name] ,COUNT([Employee No_]) AS 'Antal dagar' FROM [CRONUS Sverige AB$Employee Absence] A inner join [CRONUS Sverige AB$Employee] E ON [Employee No_] = [No_] WHERE A.[Cause of Absence Code] = 'SJUK' GROUP BY E.[First Name] ORDER BY 'Antal dagar' DESC;";
            return ShowData(s);
        }

        //METADATA
        public List<string> GetEmpTopAbsMetaData()
        {
            string s = "SELECT TOP 3 E.[First Name] ,COUNT([Employee No_]) AS 'Antal dagar' FROM [CRONUS Sverige AB$Employee Absence] A inner join [CRONUS Sverige AB$Employee] E ON [Employee No_] = [No_] WHERE A.[Cause of Absence Code] = 'SJUK' GROUP BY E.[First Name] ORDER BY 'Antal dagar' DESC;";
            return GetTableMetaData(s);
        }


        //ALL PRIMARY KEYS
        public List<List<string>> GetAllPK()
        {
            string s = "SELECT name, type_desc FROM sys.key_constraints;";
            return ShowData(s);
        }

        //ALL PRIMARY KEYS METADATA
        public List<string> GetAllPKMetaData()
        {
            string s = "SELECT name, type_desc FROM sys.key_constraints;";
            return GetTableMetaData(s);
        }

        //ALL INDEXES
        public List<List<string>> GetIndexes()
        {
            string s = "select * from sys.indexes; ";
            return ShowData(s);
        }

        //ALL INDEXES METADATA
        public List<string> GetIndexesMetaData()
        {
            string s = "select * from sys.indexes; ";
            return GetTableMetaData(s);
        }

        //ALL TABLE_CONSTRAINTS
        public List<List<string>> GetAllConstraints()
        {
            string s = "SELECT TOP 150 * from  INFORMATION_SCHEMA.TABLE_CONSTRAINTS;";
            return ShowData(s);
        }

        //ALL TABLE_CONSTRAINTS METADATA
        public List<string> GetAllConstraintsMetaData()
        {
            string s = "SELECT TOP 150 * from  INFORMATION_SCHEMA.TABLE_CONSTRAINTS;";
            return GetTableMetaData(s);
        }

        //ALL TABLES IN DB
        public List<List<string>> GetTable1()
        {
            string s = "SELECT TOP 150 * from INFORMATION_SCHEMA.TABLES;";
            return ShowData(s);
        }

        //ALL TABLES IN DB METADATA
        public List<string> GetTable1MetaData()
        {
            string s = "SELECT TOP 150 * from INFORMATION_SCHEMA.TABLES;";
            return GetTableMetaData(s);
        }

        //ALL TABLES IN DB
        public List<List<string>> GetTable2()
        {
            string s = "SELECT TOP 150 * FROM sys.tables;";
            return ShowData(s);
        }

        //ALL TABLES IN DB METADATA #2
        public List<string> GetTable2MetaData()
        {
            string s = "SELECT TOP 150 * FROM sys.tables;";
            return GetTableMetaData(s);
        }

        //ALL COLUMNS IN EMPLOYEE
        public List<List<string>> GetEmpColumns1()
        {
            string s = "SELECT * FROM sys.all_columns WHERE object_id = OBJECT_ID('[CRONUS Sverige AB$Employee]');";
            return ShowData(s);
        }

        //ALL EMP_COLUMNS METADATA #1
        public List<string> GetEmpColumns1MetaData()
        {
            string s = "SELECT * FROM sys.all_columns WHERE object_id = OBJECT_ID('[CRONUS Sverige AB$Employee]');";
            return GetTableMetaData(s);
        }

        //ALL COLUMNS IN EMPLOYEE
        public List<List<string>> GetEmpColumns2()
        {
            string s = "sp_columns [CRONUS Sverige AB$Employee];";
            return ShowData(s);
        }

        //ALL EMP_COLUMNS METADATA#2
        public List<string> GetEmpColumns2MetaData()
        {
            string s = "sp_columns [CRONUS Sverige AB$Employee];";
            return GetTableMetaData(s);
        }
    }
}
