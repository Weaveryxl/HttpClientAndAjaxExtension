using HTTPClientTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTPClientTest
{
    public partial class HTTPClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        async protected void btn1_Click(object sender, EventArgs e)
        {
            var name = txt1.Text;
            var url = "http://localhost:64763/api/Users/";
            var user = new User()
            {
                Name = name
            };
        
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(url, user);
                response.EnsureSuccessStatusCode();
                response.Dispose();
            }
            Label1.Text = name + " has been added to database.";
        }
    }
}