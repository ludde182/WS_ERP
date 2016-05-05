using System;
using System.Collections.Generic;
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

        private DAL dal = new DAL();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<List<string>> Fill(string s)
        {
            return dal.ShowData(s);
        }

        [WebMethod]
        public List<string> GetEmpTbl()
        {
            return null;
        }

        [WebMethod]
        public List<List<string>> ShowAbsData() {
            return dal.GetEmpAbsData();
        }
    }
}
