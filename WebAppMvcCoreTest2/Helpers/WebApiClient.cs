using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebAppMvcCoreTest2.Models;

namespace WebAppMvcCoreTest2.Helpers
{
    public class WebApiClient
    {
        public List<PersonModel> ViewAllPerson()
        {
            List<PersonModel> personList = null;

            try
            {
                HttpWebRequest MyReq = (HttpWebRequest)WebRequest.Create("http://completeaiouserapi.azurewebsites.net/api/UserApi");
                MyReq.ContentType = "application/json";

                HttpWebResponse MyRes = (HttpWebResponse)MyReq.GetResponseAsync().Result;

                if (MyRes.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader sr = new StreamReader(MyRes.GetResponseStream());
                    string res = sr.ReadToEnd();

                    personList = JsonConvert.DeserializeObject<List<PersonModel>>(res);

                    //foreach (var item in personList)
                    //{
                    //    Console.WriteLine(item.UserFirstName);
                    //}
                }
            }
            catch (System.Exception ex)
            {
                //Console.WriteLine(ex.Message);
                personList = null;
            }

            return personList;
        }
    }
}
