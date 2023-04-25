using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Web.Services;

namespace TeachBoy
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string s)
        {
            return $"Привет, {s}!";
        }

        [WebMethod]
        public string MoreTwo()
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Инсаф\Desktop\123\Лаба7\db.mdb");
            OleDbDataAdapter specAdapter = new OleDbDataAdapter("SELECT * FROM Специальности", connection);
            OleDbDataAdapter predAdapter = new OleDbDataAdapter("SELECT * FROM Предметы", connection);
            OleDbDataAdapter marksAdapter = new OleDbDataAdapter("SELECT * FROM Оценки", connection);

            DataSet dataSet = new DataSet();
            specAdapter.Fill(dataSet, "Специальности");
            predAdapter.Fill(dataSet, "Предметы");
            marksAdapter.Fill(dataSet, "Оценки");   

            dataSet.Relations.Add("specRow", dataSet.Tables["Специальности"].Columns["Код"], dataSet.Tables["Предметы"].Columns["Код_специальности"]);
            dataSet.Relations.Add("predRow", dataSet.Tables["Предметы"].Columns["Код"], dataSet.Tables["Оценки"].Columns["Код_предмета"]);

            Dictionary<String, int> dict = new Dictionary<String, int>();
            DataRow[] marksRows = dataSet.Tables["Специальности"].Select();
            foreach (DataRow markRow in marksRows)
            {
                String specName = (String)markRow.ItemArray[2];
                foreach (DataRow studRow in markRow.GetChildRows("specRow"))
                {
                    foreach (DataRow specRow in studRow.GetChildRows("predRow")) 
                    { 
                        int mark1 = (int)specRow.ItemArray[4];
                        int mark2 = (int)specRow.ItemArray[7];
                        int mark3 = (int)specRow.ItemArray[10];

                        if (mark1 == 2 || mark2 == 2 || mark3 == 2)
                        {
                            if (dict.ContainsKey(specName))
                                dict[specName]++;
                            else
                                dict.Add(specName, 1);
                        }
                    }
                }
            }

            if (dict.Count() == 0)
                return "Двоичников в институте нет!";
            else
                return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }        
    }
}
    

