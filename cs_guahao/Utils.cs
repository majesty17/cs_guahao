using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_guahao
{
    class Utils
    {
        private static string configFile = ".config";
        //尝试从本地文件读取config
        public static JsonData loadConfig()
        {
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "/" + configFile;
            JsonData ret = new JsonData();

            try
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] l = line.Trim().Split(new char[] { '=' });
                    if (l.Length == 2)
                    {
                        ret[l[0].Trim()] = l[1].Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("load no config error!" + ex.Message);
            }
            return ret;
        }

        //保存用户输入的config
        public static void saveConfig(JsonData config)
        {
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "/" + configFile;
            string content = "";

            try
            {
                foreach (string key in config.Keys)
                {
                    content += key + "=" + config[key].ToString() + Environment.NewLine;
                }
                File.WriteAllText(path, content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("写入cookie失败！");
            }
        }
    }
}
