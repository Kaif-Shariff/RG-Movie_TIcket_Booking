﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RG_Movie_Website
{
    public partial class MovieElement1 : System.Web.UI.UserControl
    {
        public string MovieTitle { get; set; }
        public string MovieGenre { get; set; }
        public string MovieImg{ get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}