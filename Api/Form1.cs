using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44318/");
            HttpResponseMessage response = await client.GetAsync("api/Kisi");//asenkronda olur. asenkron demek bir işlem bitmeden diğer işlem başlanabilir
            string result = await response.Content.ReadAsStringAsync();
            label1.Text = result;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Web Api Veri çekmek için kullandığımız kod 
            var client = new RestClient("http://localhost:44318/api/Kisi");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "759eb826-dfc4-4ca6-8421-030ef2edfd63");
            request.AddHeader("Ad", "Soyad"); //Buraya ne yazacağımı bilemedim
            IRestResponse response = client.Execute(request);

            //Json formatında çıktı oluşturmak için JToken 
            JToken j = JToken.Parse(response.Content);
            richTextBox1.Text = j.ToString();
        }
    }
}
