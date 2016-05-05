using System;
using System.Collections.Generic;
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
    "password=cronus;server=DESKTOP-LAMR8JS;" +
    "Trusted_Connection=yes;" +
    "database=Demo Database NAV (5-0); " +
    "connection timeout=30";
        }
        //---------------------- SHOW DATA METHOD ----------------------//

        public List<List<string>> ShowData(string s)
        {
            con.Open();
            string query = s;
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader result =  cmd.ExecuteReader();

            if (result != null)
            {
                List<List<string>> list = new List<List<string>>();

                while (result.Read())
                {
                    List<string> tmp = new List<string>();
                    for (int i = 0; i < result.FieldCount; i++)
                    {
                        string data = "";
                        if(result.GetFieldType(i) == typeof(string))
                        {
                            data = (string)result.GetString(i);
                        }
                        if(result.GetFieldType(i) == typeof(int))
                        {
                            int integer = result.GetInt32(i);
                            data = integer.ToString();
                        }
                        tmp.Add(data);
                    }
                    list.Add(tmp);
                }
                return list;
            }
            return null;
        }

        //---------------------- INSERT/UPDATE/DELETE QUERIES ----------------------//






        //---------------------- SELECT QUERIES ----------------------//

        //EMPLOYEE DATA
        public List<List<string>> GetEmployee()
        {
            string s = "select[First Name],[No_] from[CRONUS Sverige AB$Employee]";
            return ShowData(s);
        }

        //PERSONAL OCH SLÄKTINGAR 
        public List<List<string>> GetEmpRelativeData()
        {
            string s = "SELECT[CRONUS Sverige AB$Employee].[First Name],[CRONUS Sverige AB$Employee].[Last Name], No_, [Relative Code],"
                                                + "[CRONUS Sverige AB$Employee Relative].[First Name], [CRONUS Sverige AB$Employee Relative].[Last Name] FROM [CRONUS Sverige AB$Employee] "
                                                + "INNER JOIN [CRONUS Sverige AB$Employee Relative] ON  No_ = [Employee No_]";
            return ShowData(s);
        }


        //FRÅNVARO PGA SJUKDOM 2004
        public List<List<string>> GetEmpAbsData() {
            string s = "SELECT * from [CRONUS Sverige AB$Employee Absence] WHERE [From Date] LIKE '%2004%' AND [Cause of Absence Code] = 'SJUK'";
            return ShowData(s);
        }

        //ANSTÄLLDA SOM VARIT MEST SJUKA
        public List<List<string>> GetEmpTopAbs()
        {
            string s = "SELECT TOP 3 E.[First Name] ,COUNT([Employee No_]) AS 'Antal dagar' FROM [CRONUS Sverige AB$Employee Absence] A inner join [CRONUS Sverige AB$Employee] E ON [Employee No_] = [No_] WHERE A.[Cause of Absence Code] = 'SJUK' GROUP BY E.[First Name] ORDER BY 'Antal dagar' DESC";
            return ShowData(s);
        }


        //ALL PRIMARY KEYS
        public List<List<string>> GetAllPK()
        {
            string s = "SELECT name, type_desc FROM sys.key_constraints;";
            return ShowData(s);
        }

        //ALL INDEXES
        public List<List<string>> GetIndexes()
        {
            string s = "SELECT * FROM sys.indexes;";
            return ShowData(s);
        }

        //ALL TABLE_CONSTRAINTS
        public List<List<string>> GetAllConstraints()
        {
            string s = "SELECT * from  INFORMATION_SCHEMA.TABLE_CONSTRAINTS";
            return ShowData(s);
        }

        //ALL TABLES IN DB
        public List<List<string>> GetTable1()
        {
            string s = "SELECT * from INFORMATION_SCHEMA.TABLES;";
            return ShowData(s);
        }

        //ALL TABLES IN DB
        public List<List<string>> GetTable2()
        {
            string s = "SELECT* FROM sys.tables;";
            return ShowData(s);
        }

        //ALL COLUMNS IN EMPLOYEE
        public List<List<string>> GetEmpColumns1()
        {
            string s = "SELECT * FROM INFORMATION_SCHEMA.COLUMN WHERE TABLE_NAME = [CRONUS Sverige AB$Employee]";
            return ShowData(s);
        }

        //ALL COLUMNS IN EMPLOYEE
        public List<List<string>> GetEmpColumns2()
        {
            string s = "sp_columns [CRONUS Sverige AB$Employee]";
            return ShowData(s);
        }





        /*public List<string> GetEmpTables()
        {
            con.Open();
            string s = "SELECT TABLE_NAME FROM[INFORMATION_SCHEMA].TABLES WHERE TABLE_NAME LIKE '%Employee%'";
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> result = new List<string>();
            while(reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                   string tmp = reader.GetString(i);
                    result.Add(tmp);
                }
            }
            return result;
        }
        */








    }
}