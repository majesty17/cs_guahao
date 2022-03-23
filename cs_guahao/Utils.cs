using LitJson;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        /// <summary>
        /// aes加密
        /// </summary>
        /// <param name="plaintext"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string AESEncrypt(string plaintext,string key)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(plaintext);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string get_cal_status(string status, ref Color col)
        {
            if (status == "NO_INVENTORY")
            {  col = Color.Gray; return "无号"; }
            if (status == "AVAILABLE")
            { col = Color.Green; return "有号";  }
            if (status == "SOLD_OUT")
            { col = Color.Red; return "挂满"; }
            if (status == "TOMORROW_OPEN")
            { col = Color.Yellow; return "等待放号";  }
            col = Color.White;
            return string.Empty;
        }
    }
}
