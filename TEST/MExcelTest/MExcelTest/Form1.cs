using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//建立excel檔案需宣告
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace MExcelTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FileInfo fi = new FileInfo("Data.xls");
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            if (xlapp == null)
            {
                MessageBox.Show("請安裝office!!");
            }
            xlapp.Visible = false;//不顯示excel程式
            Workbook wb = xlapp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Sheets[1];
            ws.Name = "English";
            Worksheet ws1 = (Worksheet)wb.Worksheets.Add(Type.Missing, ws, Type.Missing, Type.Missing);//建立一個新分頁
            ws1.Name = "Japanese";
            ws.Cells[1, 1] = "word";
            ws.Cells[1, 2] = "translate";
            ws1.Cells[1, 1] = "word";
            ws1.Cells[1, 2] = "translate";
            ws.Cells[2, 1] = "Hello";
            ws.Cells[2, 2] = "哈囉";
            ws1.Cells[2, 1] = "こんにちは";
            ws1.Cells[2, 2] = "你好";
            if (ws == null || ws1 == null)
            {
                MessageBox.Show("建立sheet失敗");
            }
            wb.SaveAs(@fi.DirectoryName + "\\Data.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            wb.Close(false, Type.Missing, Type.Missing);
            xlapp.Workbooks.Close();
            xlapp.Quit();
            //刪除 Windows工作管理員中的Excel.exe process，  
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlapp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ws);
        }
    }
}
