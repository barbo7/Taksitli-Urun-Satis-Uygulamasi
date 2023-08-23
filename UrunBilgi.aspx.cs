using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TahsilatUyg_.Classes;

namespace TahsilatUyg_
{
    public partial class UrunBilgi : System.Web.UI.Page
    {
        VeriTabani vt = new VeriTabani();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RequiredFieldValidator1.ControlToValidate = TextBox1.ID;
                RequiredFieldValidator1.InitialValue = "";
                RequiredFieldValidator2.ControlToValidate = TextBox2.ID;
                RequiredFieldValidator2.InitialValue = "";

                RegularExpressionValidator1.ControlToValidate = TextBox1.ID;
                RegularExpressionValidator1.ValidationExpression = @"^[\wçğıöşüÇĞİÖŞÜ]+( [\wçğıöşüÇĞİÖŞÜ]+)?$";

                RegularExpressionValidator2.ControlToValidate = TextBox2.ID;
                RegularExpressionValidator2.ValidationExpression = @"^\d+(\.\d*)?$";
                RegularExpressionValidator2.Text = "Geçerli Ürün Fiyatı Giriniz";

                Literal1.Text = vt.UrunB();
            }
        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sqlc = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringGenel"].ConnectionString;
            SqlConnection con = new SqlConnection(sqlc);
            con.Open();
            SqlCommand cmdcontrol = new SqlCommand("SELECT Count(*) FROM TBL_URUNLER WHERE urun_ad='"+TextBox1.Text+"'",con);
            int urunAdControl = (int)cmdcontrol.ExecuteScalar();
            if(urunAdControl>0)
                Response.Write("Aynı isimde ürün var. Kayıt Yapılmadı!");
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TBL_URUNLER(urun_ad,fiyat) VALUES('" + TextBox1.Text + "'," + double.Parse(TextBox2.Text) + ")", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("İşlem başarıyla tamamlandı!");

                Literal1.Text = vt.UrunB();
                TextBox1.Text = "";
                TextBox2.Text = "";
                successAlert.Style["display"] = "block";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}