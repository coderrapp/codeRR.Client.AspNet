﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coderr.Client.AspNet.Demo.Errors
{
    public partial class NotFound : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Exception Exception { get; set; }

        public HttpErrorReporterContext ErrorContext { get; set; }
    }
}