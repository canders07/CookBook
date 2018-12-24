using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using CookBook.Models;

namespace CookBook
{
    public class ApiCall
    {
        public string url = "http://ec2-18-221-8-121.us-east-2.compute.amazonaws.com:8080/api/";

        public List<string> GetFolders()
        {
            string command = url + "Values/5";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(command);
            string json = GET(request);
            List<string> folders= JsonConvert.DeserializeObject<List<string>>(json);
            return folders;
        }

        public List<string> GetRecipesInFolder(string folder)
        {
            string command = url + "Values?directory="+folder;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(command);
            string json = GET(request);
            List<string> recipes= JsonConvert.DeserializeObject<List<string>>(json);
            return recipes;
        }

        public Recipe GetRecipe(string file)
        {
            string command = url + "SendRecipe?path=" + file;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(command);
            string json = GET(request);
            Recipe recipe = JsonConvert.DeserializeObject<Recipe>(json);
            return recipe;
        }


        public static string GET(HttpWebRequest request)
        {
            request.Method = "GET";
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                }
                throw;
            }

        }
    }
}
