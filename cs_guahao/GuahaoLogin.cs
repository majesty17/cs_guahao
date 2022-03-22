using LitJson;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace cs_guahao
{
    class GuahaoLogin
    {
        public string aes_key
        {
            get;set;
        }
        private string agent_login_img_code = "";
        private string imed_session1;
        private string imed_session_tm1;
        private string imed_session2;
        private string imed_session_tm2;
        /// <summary>
        /// 获取验证码图片
        /// </summary>
        public Image getImgCode()
        {
            string url = "https://www.114yygh.com/web/img/getImgCode";

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = "https://www.114yygh.com";
            myRequest.Method = "GET";

            try
            {
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                Stream stream = myResponse.GetResponseStream();
                agent_login_img_code = CookieHelper.GetCookieValueByName(myResponse.Headers["Set-Cookie"], "agent_login_img_code");
                imed_session1 = CookieHelper.GetCookieValueByName(myResponse.Headers["Set-Cookie"], "imed_session");
                imed_session_tm1 = CookieHelper.GetCookieValueByName(myResponse.Headers["Set-Cookie"], "imed_session_tm");



                Console.Out.WriteLine("agent_login_img_code: " + agent_login_img_code);
                Console.Out.WriteLine("imed_session_tm1: " + imed_session_tm1);
                Image image = Image.FromStream(stream);
                return image;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 检查用户输入的code是否合法
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool checkCode(string code)
        {
            string url = "https://www.114yygh.com/web/checkcode?code=" + code;

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            //myRequest.Headers.Add("imed_session_tm", imed_session_tm1);//很重要
            myRequest.Headers.Add("Cookie", string.Format("imed_session={0}; agent_login_img_code={1}; imed_session_tm={2}",
                imed_session1, agent_login_img_code, imed_session_tm1));
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = "https://www.114yygh.com";
            myRequest.Method = "GET";

            try
            {
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                imed_session2 = CookieHelper.GetCookieValueByName(myResponse.Headers["Set-Cookie"], "imed_session");
                imed_session_tm2 = CookieHelper.GetCookieValueByName(myResponse.Headers["Set-Cookie"], "imed_session_tm");
                Console.Out.WriteLine("imed_session: " + imed_session2);
                Console.Out.WriteLine("imed_session_tm: " + imed_session_tm2);

 
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                string content = reader.ReadToEnd();
                reader.Close();
                Console.WriteLine(content);
                return JsonMapper.ToObject(content)["msg"].ToString() == "成功";

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                return false;
            }
        }



        /// <summary>
        /// 发送短信验证码
        /// </summary>
        /// <param name="phone">aes加密后的手机号</param>
        /// <param name="code">图形验证码</param>
        public void sendSMS(string phone,string code)
        {
            string url = string.Format("https://www.114yygh.com/web/common/verify-code/get?mobile={0}&smsKey=LOGIN&code={1}", phone, code);

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            //myRequest.Headers.Add("imed_session_tm", imed_session_tm1);//很重要
            myRequest.Headers.Add("Cookie", string.Format("imed_session={0}; agent_login_img_code={1}; imed_session_tm={2}",
                imed_session2, agent_login_img_code, imed_session_tm2));
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = "https://www.114yygh.com";
            myRequest.Method = "GET";

            try
            {
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                imed_session2 = CookieHelper.GetCookieValueByName(myResponse.Headers["Set-Cookie"], "imed_session");
                imed_session_tm2 = CookieHelper.GetCookieValueByName(myResponse.Headers["Set-Cookie"], "imed_session_tm");
                Console.Out.WriteLine("imed_session: " + imed_session2);
                Console.Out.WriteLine("imed_session_tm: " + imed_session_tm2);


                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                string content = reader.ReadToEnd();
                reader.Close();
                Console.WriteLine(content);
                return;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                return;
            }
        }



        public string login(string phone,string code)
        {
            return "";
        }
    }
}
