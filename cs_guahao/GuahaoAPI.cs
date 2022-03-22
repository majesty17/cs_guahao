using System;
using System.Collections.Generic;
using System.Drawing;
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
        private string cookie; //= "bT1meiR457AESXsXtcrsCdmkzy7FkvDfUgMLrA..";

        


        public GuahaoAPI(string cookie)
        {
            this.cookie = cookie;
        }

        public void set_cookie(string c)
        {
            this.cookie = c;
        }


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
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";
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
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36"; 
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
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";
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
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36"; 
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
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = "https://www.114yygh.com/personal/patient";
            myRequest.Method = "GET";

            myRequest.Headers.Add("Cookie", "cmi-user-ticket=" + this.cookie);

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }

        /// <summary>
        /// 订单列表
        /// </summary>
        /// <param name="idCardNo"></param>
        /// <returns></returns>
        public JsonData order_list(string idCardNo)
        {
            string url = string.Format("https://www.114yygh.com/web/order/list?idCardType=IDENTITY_CARD&idCardNo={0}&orderStatus=ALL&pageNo=1&pageSize=1000", idCardNo);

            Console.WriteLine(url);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36"; 
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = "https://www.114yygh.com/personal/patient";
            myRequest.Method = "GET";

            myRequest.Headers.Add("Cookie", "cmi-user-ticket=" + this.cookie);

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }

        /// <summary>
        /// 日历列表
        /// </summary>
        /// <param name="hosCode"></param>
        /// <param name="firstDeptCode"></param>
        /// <param name="secondDeptCode"></param>
        /// <returns></returns>
        public JsonData product_list(string hosCode,string firstDeptCode,string secondDeptCode)
        {
            string url = "https://www.114yygh.com/web/product/list";

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            string data = "{\"firstDeptCode\":\"" + firstDeptCode + "\",\"secondDeptCode\":\"" + secondDeptCode + "\",\"hosCode\":\"" + hosCode + "\",\"week\":1}";
            Console.WriteLine(data);


            byte[] bs = Encoding.UTF8.GetBytes(data);

            myRequest.ContentType = "application/json;charset=UTF-8";
            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = string.Format("https://www.114yygh.com/hospital/{0}/{1}/{2}/source", hosCode, firstDeptCode, secondDeptCode);
            myRequest.Method = "POST";

            myRequest.Headers.Add("Cookie", "cmi-user-ticket=" + this.cookie);
            Stream reqStream = myRequest.GetRequestStream();
            reqStream.Write(bs, 0, bs.Length);
            reqStream.Close();

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();

            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }

        /// <summary>
        /// 日历当天详情
        /// </summary>
        /// <param name="hosCode"></param>
        /// <param name="firstDeptCode"></param>
        /// <param name="secondDeptCode"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public JsonData product_detail(string hosCode, string firstDeptCode, string secondDeptCode,string target)
        {
            string url = "https://www.114yygh.com/web/product/list";

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

            string data = "{\"firstDeptCode\":\"" + firstDeptCode + "\",\"secondDeptCode\":\"" + 
                secondDeptCode + "\",\"hosCode\":\"" + hosCode + "\",\"target\":\"" +
                target + "\"}";
            Console.WriteLine(data);


            byte[] bs = Encoding.UTF8.GetBytes(data);

            myRequest.ContentType = "application/json;charset=UTF-8";
            myRequest.Headers.Add("Request-Source", "PC");
            myRequest.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36";
            myRequest.Accept = "application/json, text/plain, */*";
            myRequest.Referer = string.Format("https://www.114yygh.com/hospital/{0}/{1}/{2}/source", hosCode, firstDeptCode, secondDeptCode);
            myRequest.Method = "POST";

            myRequest.Headers.Add("Cookie", "cmi-user-ticket=" + this.cookie);
            Stream reqStream = myRequest.GetRequestStream();
            reqStream.Write(bs, 0, bs.Length);
            reqStream.Close();

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();

            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(content);
            return JsonMapper.ToObject(content);
        }


    }
}
