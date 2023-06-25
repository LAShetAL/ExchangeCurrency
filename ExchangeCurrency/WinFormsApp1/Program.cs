using RestSharp;
using Newtonsoft.Json;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());




        }
        
        public static async Task<double> GetData(int amount, string firstOptionValue, double secondOptionValue)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "url" + firstOptionValue;

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string returned = await response.Content.ReadAsStringAsync();
                        var data = Newtonsoft.Json.JsonConvert.DeserializeObject<ExchangeRates>(returned);

                        double[] dataValues = data.data.Values.ToArray();
                        int secondOV = Convert.ToInt32(secondOptionValue);
                        double exchangedResult = amount * dataValues.ElementAt(secondOV);
                        return exchangedResult;
                    }
                    else
                    {
                        Console.WriteLine("Error code: {0}", response.StatusCode);
                        return 0.0;
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("HTTP request exception: {0}", e.Message);
                    return 0.0;
                }
            }
        }

        private static async Task<string> GetResponse(string url)
        {
            string jsonString;
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response;
                try
                {
                    response = await client.GetAsync(url);
                }
                catch(HttpRequestException e)
                {
                    MessageBox.Show("HTTP request exception: {0}",e.Message);
                    return null;
                }

                if(response.IsSuccessStatusCode)
                {
                    jsonString = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    MessageBox.Show("Error code: {0}", response.StatusCode.ToString());
                    jsonString = null;
                }
            }
            return null;
        }

    }
    public class ExchangeRates
    {
        public Dictionary<string,double> data { get; set; }
    }
   

}