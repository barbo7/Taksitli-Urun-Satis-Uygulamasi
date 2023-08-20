using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TahsilatUyg_
{
    public partial class OdemeTakip : System.Web.UI.Page
    {
        Classes.VeriTabani Vt = new Classes.VeriTabani();


        protected void Page_Load(object sender, EventArgs e)
        {

        }
 
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Vt.AdVeyaIdGoreListeleOT(TextBox1.Text, GridView1,GridView2);
        }
    }
}