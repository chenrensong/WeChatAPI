using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SS.WeChat.WebApi;
namespace SS.WeChat.Robot
{
    public class FileLog
    {
        private static string FileName = "log.txt";
        private static string CurrentDirectory = Path.GetDirectoryName(typeof(FileLog).Assembly.Location);

        public static void Log(string message)
        {
            try
            {
                var fileName = Path.Combine(CurrentDirectory, FileName);
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine($"{DateTime.Now.ToString()} {message} \n\r");
                    writer.WriteLine();
                    writer.Flush();
                }
            }
            catch (Exception innerEx)
            {

            }
        }

        public static void Exception(string errmsg, Exception ex)
        {
            try
            {
                var fileName = Path.Combine(CurrentDirectory, FileName);
                using (var writer = File.AppendText(fileName))
                {
                    string msg = $"{DateTime.Now.ToString()} [{errmsg}] Exception  \n\r";
                    writer.WriteLine(msg);
                    writer.WriteLine(ex.ToDetailedString());
                    writer.WriteLine("\n\r");
                    writer.Flush();
                }
            }
            catch (Exception innerEx)
            {

            }
        }

    }
}
