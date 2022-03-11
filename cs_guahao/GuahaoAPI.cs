using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LitJson;

namespace cs_guahao
{
    class GuahaoAPI
    {
        private string cookie = "bT1meiR457AESXsXtcrsCdmkzy7FkvDfUgMLrA..";

        /// <summary>
        /// 医院查询
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="levelId"></param>
        /// <param name="areaId"></param>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public JsonData hospital_list(string keywords,int levelId,int areaId,int pageNo,int pageSize)
        {
            string url = string.Format("https://www.114yygh.com/web/hospital/list?keywords={0}&levelId={1}&areaId={2}&pageNo={3}&pageSize={4}", keywords,
                levelId, areaId, pageNo, pageSize);

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";            myRequest.Referer = "https://webstatic.mihoyo.com/app/community-game-records/index.html?v=6";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = "https://www.114yygh.com/";
            myRequest.Method = "GET";

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }

        /// <summary>
        /// 医院详情
        /// </summary>
        /// <param name="hosCode"></param>
        /// <returns></returns>
        public JsonData hospital_detail(string hosCode)
        {
            string url = string.Format("https://www.114yygh.com/web/hospital/detail?hosCode={0}", hosCode);

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36"; myRequest.Referer = "https://webstatic.mihoyo.com/app/community-game-records/index.html?v=6";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = string.Format("https://www.114yygh.com/hospital/{0}/home", hosCode);
            myRequest.Method = "GET";

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }

        /// <summary>
        /// 获取医院科室
        /// </summary>
        /// <param name="hosCode"></param>
        /// <returns></returns>
        public JsonData hospital_department(string hosCode)
        {
            string url = string.Format("https://www.114yygh.com/web/department/hos/list?hosCode={0}", hosCode);

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36"; myRequest.Referer = "https://webstatic.mihoyo.com/app/community-game-records/index.html?v=6";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = string.Format("https://www.114yygh.com/hospital/{0}/home", hosCode);
            myRequest.Method = "GET";

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }
        /// <summary>
        /// 医院通知
        /// </summary>
        /// <returns></returns>
        public JsonData hospital_notice(string hosCode)
        {
            string url = string.Format("https://www.114yygh.com/web/common/content?hosCode={0}&label=notice&bizType=HOSPITAL", hosCode);

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36"; myRequest.Referer = "https://webstatic.mihoyo.com/app/community-game-records/index.html?v=6";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = string.Format("https://www.114yygh.com/hospital/{0}/notice", hosCode);
            myRequest.Method = "GET";

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }


        /// <summary>
        ///         就诊人列表
        /// </summary>
        public JsonData patient_list()
        {
            string url = "https://www.114yygh.com/web/patient/list?showType=USER_CENTER";

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36"; myRequest.Referer = "https://webstatic.mihoyo.com/app/community-game-records/index.html?v=6";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = "https://www.114yygh.com/personal/patient";
            myRequest.Method = "GET";

            myRequest.Headers.Add("Cookie", "cmi-user-ticket=0ITQ7-jThJzzBx_KyFXMIpYgRpwzkLQtvTU7Hg..");

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }


        public JsonData order_list(string idCardNo)
        {
            string url = string.Format("https://www.114yygh.com/web/order/list?idCardType=IDENTITY_CARD&idCardNo={0}&orderStatus=ALL&pageNo=1&pageSize=1000", idCardNo);

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36"; myRequest.Referer = "https://webstatic.mihoyo.com/app/community-game-records/index.html?v=6";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = "https://www.114yygh.com/personal/patient";
            myRequest.Method = "GET";

         //   myRequest.Headers.Add("Cookie", "cmi-user-ticket=0ITQ7-jThJzzBx_KyFXMIpYgRpwzkLQtvTU7Hg..");

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }
    }
}
