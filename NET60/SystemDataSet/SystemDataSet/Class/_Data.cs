using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            dt.Columns.Add("Columns5", typeof(int));
            for(int i = 0; i < 5; i++)
            {
                DataRow dr = dt.NewRow ();
                for(int j = 0; j < dr.ItemArray.Length; j++)
                {
                    dr[j] = i * 100 + j;
                }
                dt.Rows.Add(dr);
            }
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
