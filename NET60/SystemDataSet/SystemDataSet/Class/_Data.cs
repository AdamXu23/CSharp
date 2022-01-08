using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace SystemDataSet
{
    public class _Data
    {
        public DataSet dataset;

        public _Data (string dsName)
        {
            dataset = new DataSet (dsName);
            DataTable dt = new DataTable ("Table1");
            dt.Columns.Add("Columns1", typeof(int));
            dt.Columns.Add("Columns2", typeof(int));
            dt.Columns.Add("Columns3", typeof(int));
            dt.Columns.Add("Columns4", typeof(int));
            dt.Columns.Add("Columns5", typeof(DataTable));

            DataTable dt1 = new DataTable("Table2");
            dt1.Columns.Add("Columns1", typeof(int));
            dt1.Columns.Add("Columns2", typeof(int));
            dt1.Columns.Add("Columns3", typeof(int));
            dt1.Columns.Add("Columns4", typeof(int));

            DataRow dr1 = dt1.NewRow ();
            dr1["Columns1"] = 1;
            dr1["Columns2"] = 2;
            dr1["Columns3"] = 3;
            dr1["Columns4"] = 4;
            dt1.Rows.Add (dr1);

            DataRow dr = dt.NewRow();
            dr["Columns1"] = 1;
            dr["Columns2"] = 2;
            dr["Columns3"] = 3;
            dr["Columns4"] = 4;
            dr["Columns5"] = dt1;
            dt.Rows.Add(dr);

            dataset.Tables.Add (dt);
        }

        public string GetString()
        {
            return dataset.DataSetName;
        }
        public object[] GetDataTable()
        {
            string[] str = new string[dataset.Tables.Count];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = dataset.Tables[i].TableName;
            }
            return str;
        }
    }
}
