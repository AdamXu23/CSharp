using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.IO;

namespace ExcelTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
			//建立Excel 2003檔案
			IWorkbook wb = new HSSFWorkbook();
			

			//建立Excel 2007檔案
			//IWorkbook wb = new XSSFWorkbook();
			ISheet ws = wb.CreateSheet("Class");

			ws.CreateRow(0);//第一行為欄位名稱
			ws.GetRow(0).CreateCell(0).SetCellValue("name");
			ws.GetRow(0).CreateCell(1).SetCellValue("score");
			ws.CreateRow(1);//第二行之後為資料
			ws.GetRow(1).CreateCell(0).SetCellValue("abey");
			ws.GetRow(1).CreateCell(1).SetCellValue(85);
			ws.CreateRow(2);
			ws.GetRow(2).CreateCell(0).SetCellValue("tina");
			ws.GetRow(2).CreateCell(1).SetCellValue(82);
			ws.CreateRow(3);
			ws.GetRow(3).CreateCell(0).SetCellValue("boi");
			ws.GetRow(3).CreateCell(1).SetCellValue(84);
			ws.CreateRow(4);
			ws.GetRow(4).CreateCell(0).SetCellValue("hebe");
			ws.GetRow(4).CreateCell(1).SetCellValue(86);
			ws.CreateRow(5);
			ws.GetRow(5).CreateCell(0).SetCellValue("paul");
			ws.GetRow(5).CreateCell(1).SetCellValue(82);
			FileStream file = new FileStream(@"C:\tmp\npoi.xls", FileMode.Create);//產生檔案
			wb.Write(file);
			file.Flush();
			file.Close();
		
	}

        private void Stop_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
