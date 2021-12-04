using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace AppBoii
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            String UrlPath = "https://appboii.com";
            MyIframe.Src = UrlPath;

            if (Request.RawUrl != "/Default.aspx")
            {
                UrlPath += Request.RawUrl;
                Debug.WriteLine(Request.RawUrl);

                MyIframe.Src = UrlPath;
            }
        }
    }
}