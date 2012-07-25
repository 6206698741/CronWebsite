﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CronWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CurrentAccount"] != null)
            {
                Response.Redirect("~/dashboard.aspx");
            }
        }

        protected void btnLearnMore_Click(object sender, EventArgs e)
        {

        }
    }
}