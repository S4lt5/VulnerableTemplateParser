using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;

namespace VulnerableParser
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string parms = Request.Form["parameters"];
                if (!String.IsNullOrEmpty(parms))
                {

                    Control c = ParseControl(parms);
                    myPlaceholder.Controls.Add(c);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message + "\n" + ex.StackTrace;
                this.Response.Write(msg);
               
            }
            this.Response.Write("Hi!");
             
            
        }


    }
}