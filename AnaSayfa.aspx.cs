using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TahsilatUyg_
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MusteriBilgi.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UrunBilgi.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tahsilat.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("KefilBilgi.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("MusteriTakip.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("OdemeTakip.aspx");

        }
    }
}