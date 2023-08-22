using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace TahsilatUyg_
{
    public partial class MusteriBilgi : System.Web.UI.Page
    {
        string connectionStringGenel = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringGenel"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                RequiredFieldValidator1.ControlToValidate = TextBox1.ID;
                RequiredFieldValidator1.InitialValue = "";
                RequiredFieldValidator1.Text = "Ad-Soyad alanı Boş bırakılamaz.";
                RegularExpressionValidator1.ControlToValidate = TextBox1.ID;
                RegularExpressionValidator1.ValidationExpression = @"^[\wçğıöşüÇĞİÖŞÜ]+( [\wçğıöşüÇĞİÖŞÜ]+){1,2}$";
                RegularExpressionValidator1.Text = "Lütfen sadece harf kullanın.";

                RequiredFieldValidator2.ControlToValidate = TextBox2.ID;
                RequiredFieldValidator2.InitialValue = "";
                RequiredFieldValidator2.Text = "Tc No alanı Boş bırakılamaz.";
                RegularExpressionValidator2.ControlToValidate = TextBox2.ID;
                RegularExpressionValidator2.ValidationExpression = @"^\d{11}$";
                RegularExpressionValidator2.Text = "11 Haneli TC giriniz.";

                RequiredFieldValidator3.ControlToValidate = TextBox3.ID;
                RequiredFieldValidator3.InitialValue = "";
                RequiredFieldValidator3.Text = "Cep telefonu alanı Boş bırakılamaz.";
                RegularExpressionValidator3.ControlToValidate = TextBox3.ID;
                RegularExpressionValidator3.ValidationExpression = @"^\d{11}$";
                RegularExpressionValidator3.Text = "11 Haneli Telefon numarasını giriniz.";

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            string sqlC = String.Format("Insert Into TBL_MUSTERI(ad_soyad,tc,telno,vergi_kimlik_no,adres) VALUES('{0}','{1}','{2}','{3}','{4}')", TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            SqlCommand cmd = new SqlCommand(sqlC, con);
            cmd.ExecuteNonQuery();
            con.Close();
            successAlert.Style["display"] = "block";
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if(TextBox4.Text.Length>10)
            TextBox4.Text =TextBox4.Text.Substring(0, 10); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");
        }
    }
}
