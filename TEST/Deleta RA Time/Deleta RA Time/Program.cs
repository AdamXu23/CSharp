using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Deleta_RA_Time
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string srcPath = @"C:\Documents and Settings\All Users\Application Data\Rockwell Automation\FactoryTalk Activation";
            if (Directory.Exists(srcPath))
            {
                DelectDir(srcPath);
            }
        }
        public static void DelectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
